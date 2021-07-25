using System;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {

             string opcion = "";
            Datos datos = new Datos();
            DatosAves datosdeaves = new DatosAves();
            DatosPeces datosPeces = new DatosPeces();
            while (true)
             {
                 Console.Clear();
                 Console.WriteLine("Bienvenido a planeta animal");
                 Console.WriteLine("*****************************");
                 Console.WriteLine("");
                 Console.WriteLine("1 - Animales Mamiferos");
                 Console.WriteLine("2 - Animales de tipo Ave");
                 Console.WriteLine("3 - Animales Acuaticos");
                 Console.WriteLine("0 - Salir");
                 Console.WriteLine("Elija una opcion: ");
                 opcion = Console.ReadLine();

                 switch (opcion)
                 {
                     case "1":
                        datos.CargarMamiferos();

                        break;
                     case "2":
                        datosdeaves.CargarAves();
                        break;
                     case "3":
                        datosPeces.CargarPeces();
                        break;
                     default:
                         break;
                 }

                 if (opcion == "0")
                 {
                     break;
                }
           }
        }
    }
 }
