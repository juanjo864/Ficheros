using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    public class Lecturayescritura
    {
        public void escritura()
        {
            try
            {
                Console.WriteLine("escribe algo en el archivo");
                String escribire = Console.ReadLine();
                // en el using lo que hace es que el streamwrite cierre de manera segura
                //y libere recurso,el streamwriter se utiliza para escribir fichero
                //dentro del streamwriter devuelve la ruta del directorio actual en el que se está ejecutando el programa
                using (StreamWriter escribir = new StreamWriter(Directory.GetCurrentDirectory() + "/texto.txt"))
                {
                    escribir.WriteLine(escribire);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("error de entrada y salida de fichero");
            }
        }
        public void lectura()
        {
            try
            {
                
                // en el using lo que hace es que el streamwReader cierre de manera segura
                //y libere recurso,el streamReader se utiliza para leerfichero
                //dentro del streamwriter devuelve la ruta del directorio actual en el que se está ejecutando el programa
                using (StreamReader lectura = new StreamReader(Directory.GetCurrentDirectory() + "/texto.txt"))
                {
                    String lineas;
                    //lee hasta el final del fichero
                    while ((lineas=lectura.ReadLine())!=null)
                    {
                        Console.WriteLine (lineas);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("error de entrada y salida de fichero");
            }
        }
    }
}
