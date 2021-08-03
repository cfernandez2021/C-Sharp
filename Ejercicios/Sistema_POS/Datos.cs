using System;
using System.Collections.Generic;
public class Datos
{
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }

    public List<Productos> ListadeProductos { get; set; }

    public Datos()
    {
        ListadeClientes = new List<Cliente>();
        CargarLosClientes();
        ListadeVendedores = new List<Vendedor>();
        CargarLosVendedores();
        ListadeProductos = new List<Productos>();
        CargarLosProductos();
    }
                                    //Clientes///
    private void CargarLosClientes() //Encapsulamiento
    {
        Cliente clie1 = new Cliente(1, "Carlos Perez", "Col.Cerro Verde", "9090-8989", 25);
        ListadeClientes.Add(clie1);

        Cliente clie2 = new Cliente(2, "Tania Garcia", "Col.Lopez Arellano", "9595-8989", 35);
        ListadeClientes.Add(clie2);

        Cliente clie3 = new Cliente(3, "Elvin Acosta", "Col.Cascada", "8895-9898", 30);
        ListadeClientes.Add(clie3);

        Cliente clie4 = new Cliente(4, "Denis Fernandez", "Col.Trincheras", "9594-9693", 25);
        ListadeClientes.Add(clie4);

        Cliente clie5 = new Cliente(5, "Diana Alvarado", "Col.Cerro Verde", "9563-6363", 25);
        ListadeClientes.Add(clie5);

    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("Listado de Clientes");
        Console.WriteLine("========================");
        Console.WriteLine("");
        Console.WriteLine("Id | Nombre y Apellido | Direccion | Telefono | Edad");
        Console.WriteLine("");

        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Id + " | " + cliente.Nombre + " | " + cliente.Direccion + " | " + cliente.Telefono + " | " + cliente.Edad);
        }

        Console.ReadLine();
    }

                                            //Vendedores//
    private void CargarLosVendedores() //Encapsulamiento
    {
        Vendedor v1 = new Vendedor(1,"Dana Fernandez","Col.Lopez Arellano","9895-0011","16000");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Francisco Pineda", "Col. Planeta", "8855-0101", "10000");
        ListadeVendedores.Add(v2);

        Vendedor v3 = new Vendedor(3, "Anderson Morales", "Col.La Jutosa", "3356-9898", "11500");
        ListadeVendedores.Add(v3);

        Vendedor v4 = new Vendedor(4, "Mauricio Alvarado", "Res.Rancho Tara", "9898-7145", "25000");
        ListadeVendedores.Add(v4);
       
       
    }
    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("Listado de Vendedores");
        Console.WriteLine("==========================");
        Console.WriteLine("");
        Console.WriteLine("Id | Nombre y Apellido | Direccion | Telefono | Salario");
        Console.WriteLine("");
        foreach (var ven in ListadeVendedores)
        {
            Console.WriteLine(ven.Id + " | " + ven.Nombre + " | " + ven.Direccion + " | " + ven.Telefono + " | " + ven.Salario);

            

        }
        Console.ReadLine();
    }
                                                     //Productos///
        private void CargarLosProductos()
        {
        Productos p1 = new Productos(1,"Computadora Dell Inspiron",18500,10);
        ListadeProductos.Add(p1);

        Productos p2 = new Productos(2, "Impresora Samsung", 7000, 5);
        ListadeProductos.Add(p2);

        Productos p3 = new Productos(3, "Audifonos Redmi Xiaomi", 700, 15);
        ListadeProductos.Add(p3);

        Productos p4 = new Productos(4, "Smartwatch Xiaomi", 3000, 4);
        ListadeProductos.Add(p4);

        Productos p5 = new Productos(5, "Maquillaje Todo en uno", 1500, 7);
        ListadeProductos.Add(p5);

        Productos p6 = new Productos(6, "Tenis de Dama Nike (Par)", 2500, 4);
        ListadeProductos.Add(p6);

        Productos p7 = new Productos(7, "Camisa deportiva para dama", 250, 5);
        ListadeProductos.Add(p7);

        Productos p8 = new Productos(8, "Parlante LG", 4500, 3);
        ListadeProductos.Add(p8);

        Productos p9 = new Productos(9, "Paleta de Colores PaperMate", 80, 4);
        ListadeProductos.Add(p9);

        Productos p10 = new Productos(10, "Cuadernos Copan una materia", 50 , 20);
        ListadeProductos.Add(p10);

        
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("Listado de Productos Disponibles");
        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("Codigo | Descripcion | Precio | Existencia");
        Console.WriteLine("");
        foreach (var pro in ListadeProductos)
        {
            Console.WriteLine(pro.Codigo + " | " + pro.Descripcion + " | " + pro.Precio + " | " + pro.Existencia);

        }
        Console.ReadLine();
    }
    
}
