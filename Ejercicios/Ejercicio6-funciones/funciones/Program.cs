using System;

namespace funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a=new Alumno(1,"Juan","Perez");
            Alumno b=new Alumno(2,"Diana","Madrid");
            a.InactivarAlumno();

            Console.WriteLine(a.nombreCompleto()); 
            Console.WriteLine(b.nombreCompleto()); 
            Console.WriteLine("***************");
            a.activarAlumno();
            Console.WriteLine("Activando Alumno");
            Console.WriteLine(a.nombreCompleto()); 
            Console.WriteLine(b.nombreCompleto());
        }
    }
}
