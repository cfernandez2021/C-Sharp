using System;
public class DatosPeces
{
        private void CargarPezGlobo() //Encapsulamiento//
    {
        Console.Clear();
        Console.WriteLine("Pez Globo");
        Console.WriteLine("***************");
        Console.WriteLine("");
        PezGlobo pes1 = new PezGlobo("Pez Globo Leopardo Verde ","Pao turgidus","Plantum",6,"Verde");
        Console.WriteLine("Nombre del Pez: " + pes1.Nombre);
        Console.WriteLine("Nombre Cientifico del Pez: " + pes1.NombreCientifico);
        Console.WriteLine("Comida Favorita: " + pes1.TipodeComida);
        Console.WriteLine("Numero de aletas: " + pes1.NumerodeAlestas);
        Console.WriteLine("Color del pez : " + pes1.Color);
        pes1.Nadar();
        pes1.Inflarse();

        Console.ReadLine();

    }

        private void CargarPezPayaso() //Encapsulamiento//
    {
        Console.Clear();
        Console.WriteLine("Pez Payaso");
        Console.WriteLine("***************");
        Console.WriteLine("");
        PezPayaso pes2 = new PezPayaso("Pez Payaso", "Amphiprioninae", "Moluscos", 6, "Naranja y Blanco");
        Console.WriteLine("Nombre del pez: " + pes2.Nombre);
        Console.WriteLine("Nombre Cientifico del pez: " + pes2.NombreCientifico);
        Console.WriteLine("Comida Favorita: " + pes2.TipodeComida);
        Console.WriteLine("Numero de aletas: " + pes2.NumerodeAlestas);
        Console.WriteLine("Color de pez: " + pes2.Color);
        pes2.PezPayasoComiendo();
        Console.ReadLine();

    }




    public void CargarPeces()
    {
        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Peces");
            Console.WriteLine("===================");
            Console.WriteLine("");
            Console.WriteLine("1 - Pez Globo");
            Console.WriteLine("2 - Pez Payaso");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    CargarPezGlobo();
                    break;
                case "2":
                    CargarPezPayaso();
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