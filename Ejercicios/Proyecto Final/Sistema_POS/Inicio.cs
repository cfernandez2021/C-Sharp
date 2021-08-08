using System;

public class Inicio
{
    public void Login()
    {
       

        for (var i = 1; i <= 3; i++)
        {
            string usr ; //Usuario Correcto//
            string contra; //Contraseña Correcto//
            Console.Clear();
            Console.WriteLine("\t\t\t\t\t\t\t\t\t   »»»»»»»»»»»»»»»»»»»»»»»»»");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t      Importaciones CarDi7  ");
            Console.WriteLine("\t\t\t\t\t\t\t\t\t   »»»»»»»»»»»»»»»»»»»»»»»»»");
            Console.WriteLine("");

            Console.Write("\t\t\t\t\t\t\t Ingrese el Usuario: ");
            usr = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("\t\t\t\t\t\t\t Ingrese la Contraseña: ");
            contra = Console.ReadLine();

            if (usr == "Admin1" && contra == "unahvs")
            {
                Console.Clear();
                break;
                
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t ===========================");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t      Intento Fallado! ");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t            " + i + " " + "De 3");

                if (i == 3)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t ===========================");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t      Acceso Denegado!");
                    Console.WriteLine("\t\t\t\t\t\t\t\t\t ===========================");
                }
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;

            }

        }

    }

    }
    
 

