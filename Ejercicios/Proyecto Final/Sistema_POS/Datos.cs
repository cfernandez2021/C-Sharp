using System.Collections.Specialized;
using System;
using System.Collections.Generic;
public class Datos
{
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }

    public List<Producto> ListadeProductos { get; set; }
    public List<Orden> ListaOrdenes { get; set; }


    public Datos()
    {
        ListadeClientes = new List<Cliente>();
        CargarLosClientes();
        ListadeVendedores = new List<Vendedor>();
        CargarLosVendedores();
        ListadeProductos = new List<Producto>();
        CargarLosProductos();
        ListaOrdenes = new List<Orden>();

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
        Vendedor v1 = new Vendedor(1, "Dana Fernandez", "Col.Lopez Arellano", "9895-0011", "16000");
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
    public void CargarLosProductos()
    {
        Producto p1 = new Producto("1", "Computadora Dell Inspiron", 18500, 10);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto("2", "Impresora Samsung", 7000, 5);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto("3", "Audifonos Redmi Xiaomi", 700, 15);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto("4", "Smartwatch Xiaomi", 3000, 4);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto("5", "Maquillaje Todo en uno", 1500, 7);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto("6", "Tenis de Dama Nike (Par)", 2500, 4);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto("7", "Camisa deportiva para dama", 250, 5);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto("8", "Parlante LG", 4500, 3);
        ListadeProductos.Add(p8);

        Producto p9 = new Producto("9", "Paleta de Colores PaperMate", 80, 4);
        ListadeProductos.Add(p9);

        Producto p10 = new Producto("10", "Cuadernos Copan una materia", 50, 20);
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

    public void MenuFactura()
    {
        string opc;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Factura de Venta");
            Console.WriteLine("=======================");
            Console.WriteLine("Digite la opcion deseada: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Crear Nueva Factura de Venta");
            Console.WriteLine("2 - Listado de Facturas");
            Console.WriteLine("0 - Salir");
            opc = Console.ReadLine();

            switch (opc)
            {
                case "1":
                    CrearOrden();

                    break;
                case "2":
                    ListarOrdenes();


                    break;
            }

            if (opc == "0")
            {
                break;
            }
        }


    }

    public void CrearOrden()
    {
        Console.Clear();
        Console.WriteLine("Creando Nueva Factura de Venta");
        Console.WriteLine("================================");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el Id del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Id.ToString() == codigoCliente);
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el Id del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Id.ToString() == codigoVendedor);
        if (vendedor == null)
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        }
        else
        {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "Choloma" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while (true)
        {
            Console.WriteLine("Ingrese el Codigo del producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);


            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n")
            {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("El subtotal es: " + nuevaOrden.Subtotal);
        Console.WriteLine("El ISV es: " + nuevaOrden.ISV);
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.ReadLine();

    }


    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Facturas Generadas");
        Console.WriteLine("=============================");
        Console.WriteLine("");
        Console.WriteLine("Codigo| Fecha | Vendedor | Cliente  | Subtotal | ISV | Total a Pagar ");
        Console.WriteLine("======================================================================");

        Console.WriteLine("");

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.Vendedor.Nombre + " | " + orden.Cliente.Nombre + " | " + orden.Subtotal + " | " + orden.ISV + " | " + orden.Total);
            Console.WriteLine();

            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("    " + " Producto |  Cantidad  | Precio   ");
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }

    public void MenuInventario()
    {
        string opc;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Inventario");
            Console.WriteLine("=======================");
            Console.WriteLine("Digite la opcion deseada: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Ingreso de productos al inventario");
            Console.WriteLine("2 - Listado de Productos en el Inventario");
            Console.WriteLine("3 - Eliminar Productos en el Inventario");
            Console.WriteLine("0 - Salir");
            opc = Console.ReadLine();
            switch (opc)
            {
                case "1":
                    ingresoDeInventario();
                    break;
                case "2":
                    listarProductos();
                    break;
                case "3":
                    salidaDeInventario();
                    break;
            }
            if (opc == "0")
            {
                break;
            }
        }
    }

    public void ingresoDeInventario()
    {
        string codigo = "";
        string cantidad = "";
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("==================================");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }


    public void salidaDeInventario()
    {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Salida de Productos al Inventario");
        Console.WriteLine("==================================");
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }

    private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento)
    {
        foreach (var producto in ListadeProductos)
        {
            if (producto.Codigo == codigo)
            {
                if (tipoMovimiento == "+")
                {
                    producto.Existencia = producto.Existencia + cantidad;
                }
                else
                {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }
        }

    }

    public void listarProductos()
    { //Funcion de listarproductos//
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Listado de Productos");
        Console.WriteLine("======================");
        Console.WriteLine("Codigo, Descripcion y Existencia");

        foreach (var producto in ListadeProductos) //Foreach que muestra los productos
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }

        Console.ReadLine();
    }
}
