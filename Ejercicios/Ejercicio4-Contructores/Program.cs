using System;

namespace contructores
{
    class Program
    {
        static void Main(string[] args)
        {
         Alumno a = new Alumno(); //Copia en memoria de mi clase//
            a.Id = 1;
            a.PrimerNombre="Juan";       //Campos rellenados de la clase//
            a.SegundoNombre="Perez";

          Alumno b=new Alumno();
          b.Id=2;
          b.PrimerNombre="Maria";  
          b.SegundoNombre="Martinez";

          Alumno c=new Alumno(3);

          Alumno d = new Alumno("Juan","Jimenez");

        Console.WriteLine(a.Id);
        Console.WriteLine(b.Id);
        Console.WriteLine(c.Id);
        Console.WriteLine(d.PrimerNombre +" "+d.SegundoNombre);
        }
    }
}
