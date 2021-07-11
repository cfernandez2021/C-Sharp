using System;

namespace contructores
{
    class Program
    {
        static void Main(string[] args)
        {


        Alumno e = new Alumno(1,"Carlos","Fernandez");
        Alumno b = new Alumno(2,"Dana","Fernandez");


        e.inactivarAlumno();
       Console.WriteLine(e.nombreCompleto());
       Console.WriteLine(b.nombreCompleto());
        }
    }
}
