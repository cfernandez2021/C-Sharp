using System;
using System.Collections.Generic;

public class Inventario
{
 
public List<Producto> ListadeProductos { get; set; }

public Inventario() //contructor//
{
    ListadeProductos=new List<Producto>();
    Producto a = new Producto("001","IphoneX",0);
    Producto b = new Producto("002","Laptop DELL",5);
    Producto c = new Producto("003","Monitor Samsung",2);
    Producto d = new Producto("004","Mouse",100);
    Producto e = new Producto("005","HetSet",20);

    ListadeProductos.Add(a);
    ListadeProductos.Add(b);
    ListadeProductos.Add(c);
    ListadeProductos.Add(d);
    ListadeProductos.Add(e);

}

//Funciones//

//funcion de listar productos//
        public void listarProductos()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");    
            Console.WriteLine("*********************");
            Console.WriteLine("Codigo, Descripcion, y existencia");

            foreach (var producto in ListadeProductos)
            {
                Console.WriteLine(producto.Codigo + "| "+ producto.Descripcion + "|" + producto.Existencia.ToString());
            }
            Console.ReadLine();

        }

        //funcion de movimiento de inventarios//
            private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
           
            foreach (var producto in ListadeProductos)
            {
                 if (producto.Codigo == codigo) {
                    if (tipoMovimiento == "+") {
                        producto.Existencia = producto.Existencia + cantidad;
                    } else {
                        producto.Existencia = producto.Existencia - cantidad;
                    }

                }
            }
        
}

            //funcion ingreso de inventario//
            public void ingresoDeInventario() {
                string codigo = "";
                string cantidad = "";

                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("Ingreso de Productos al Inventario");
                Console.WriteLine("**********************************");
                Console.Write("Ingrese el codigo del producto: ");
                codigo=Console.ReadLine();


                
                Console.Write("Ingrese la cantidad del producto: ");
                cantidad=Console.ReadLine();
            

                movimientoInventario(codigo,Int32.Parse(cantidad), "+");
            }


        


}