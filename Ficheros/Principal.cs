using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficheros
{
    public class Principal
    {
        static void Main(string[] args)
        {
            try
            {
                Lecturayescritura lecturayescritura = new Lecturayescritura();
                int numero;
                do
                {
                    Console.WriteLine("elige una de las opciones para practicar ficheros");
                    Console.WriteLine("1. escritura");
                    Console.WriteLine("2. lectura");
                    Console.WriteLine("3. exit");
                    numero = Convert.ToInt32(Console.ReadLine());

                    switch (numero)
                    {
                        case 1:
                            lecturayescritura.escritura();
                            break;
                        case 2:
                            lecturayescritura.lectura();
                            break;
                        case 3:
                            Environment.Exit(0);
                             break;
                        default:
                            Console.WriteLine("fuera de los limites");
                            break;
                    }

                } while (numero != 3);

            }
            catch (IOException ex)
            {
                Console.WriteLine("error de entrada y salida");
            }
        }
            
          
        
    }
}
