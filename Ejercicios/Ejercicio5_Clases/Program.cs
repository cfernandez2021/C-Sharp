using System;

namespace Ejercicio5_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumnos a= new Alumnos();
            a.Id=1;
            a.PrimerNombre="Carlos";
            a.SegundoNombre="Daniel";

            Alumnos b=new Alumnos();
            b.Id=2;
            b.PrimerNombre="Maria";
            b.SegundoNombre="Victoria";


            Alumnos c=new Alumnos(3);
            c.PrimerNombre="Pedro";

            Alumnos d=new Alumnos("Juan", "Jimenez");
            
            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);

            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);

        }
    }
}
