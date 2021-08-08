using System.Diagnostics.Tracing;
using System;

namespace Sistema_POS
{
    class Program
    {

        static void Main(string[] args)
        {

            Inicio login = new Inicio();
            Datos datos = new Datos();
            
            login.Login();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\t\t\t Bienvenido(a) al Sistema Pos de Importaciones CarDi7");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t By: Carlos Daniel Fernandez Dominguez");
                Console.WriteLine("");
                Console.WriteLine("                                                                  ████████████████████████████████████████████████████             ");
                Console.WriteLine("                                                                  █                                                  █                  ");
                Console.WriteLine("                                                                  █         Listado de opciones disponibles          █                  ");
                Console.WriteLine("                                                                  █                                                  █                  ");
                Console.WriteLine("                                                                  █        1. Clientes                               █                  ");
                Console.WriteLine("                                                                  █        2. Vendedores                             █                  ");
                Console.WriteLine("                                                                  █        3. Productos                              █                  ");
                Console.WriteLine("                                                                  █        4. Ventas                                 █                  ");
                Console.WriteLine("                                                                  █        5. Inventario                             █                ");
                Console.WriteLine("                                                                  █        0. Salir                                  █                 ");
                Console.WriteLine("                                                                  █                                                  █                  ");
                Console.WriteLine("                                                                  █                                                  █                ");
                Console.WriteLine("                                                                  █                                                  █                  ");
                Console.WriteLine("                                                                  █                                                  █                 ");
                Console.WriteLine("                                                                  █                                                  █                  ");
                Console.WriteLine("                                                                  ████████████████████████████████████████████████████                 ");
                Console.WriteLine("                                                                                            █   █                                          ");
                Console.WriteLine("                                                                                            █   █                                          ");
                Console.WriteLine("                                                                                            █   █                                          ");
                Console.WriteLine("                                                                                            █   █                                          ");
                Console.WriteLine("                                                                                   ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀                                ");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t Digite una opcion del menu: ");
                Console.SetCursorPosition((Console.WindowWidth) / 2, Console.CursorTop);
                opcion = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("");
                switch (opcion)
                {

                    case "1":
                        datos.ListarClientes();
                        break;
                    case "2":
                        datos.ListarVendedores();
                        break;
                    case "3":
                        datos.ListarProductos();
                        break;
                    case "4":
                        datos.MenuFactura();
                        break;
                    case "5":
                        datos.MenuInventario();
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

