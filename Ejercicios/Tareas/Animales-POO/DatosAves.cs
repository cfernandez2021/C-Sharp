using System;
public class DatosAves
{

    private void CargarAguila() //Encapsulamiento//
    {
        Console.Clear();
       
       
        Console.WriteLine("N1");
        Console.WriteLine("********************");

        Aguila agui1 = new Aguila("Aguila Real", "Aquila chrysaetos", "Conejos", "Cafe con Blanco ", 2, 4);
        Console.WriteLine("Nombre del Aguila: " + agui1.Nombre);
        Console.WriteLine("Nombre Cientifico del Aguila: " + agui1.NombreCientifico);
        Console.WriteLine("Comida Favorita del Aguila: " + agui1.TipodeComida);
        Console.WriteLine("Color de plumaje del Aguila: " + agui1.ColordePlumaje);
        Console.WriteLine("Numero de patas: " + agui1.NumeroPatas);
        Console.WriteLine("Tamaño del pico: " + agui1.Pico + " Cm ");
        Console.WriteLine("");
        agui1.VolarAlto();
        Console.WriteLine("");
        Console.WriteLine("N2");
        Console.WriteLine("********************");
        Aguila agui2 = new Aguila("Aguila Imperial", "Aquila heliaca", "Serpiente", "Cafe con Amarillo ", 2, 5);
        Console.WriteLine("Nombre del Aguila: " + agui2.Nombre);
        Console.WriteLine("Nombre Cientifico del Aguila: " + agui2.NombreCientifico);
        Console.WriteLine("Comida Favorita del Aguila: " + agui2.TipodeComida);
        Console.WriteLine("Color de plumaje del Aguila: " + agui2.ColordePlumaje);
        Console.WriteLine("Numero de patas: " + agui2.NumeroPatas);
        Console.WriteLine("Tamaño del pico: " + agui2.Pico + " Cm ");
        Console.WriteLine("");
        agui2.Cazando();
        Console.ReadLine();

    }

    private void CargarLoro() //Encapsulamiento//
    {
        Console.Clear();
        
        
        Console.WriteLine("N1");
        Console.WriteLine("********************");
        Loro lo1 = new Loro("Cacatua","Cacatuidae","Semillas","Blanco y Amarrillo",2,3);
        Console.WriteLine("Nombre del Loro: " + lo1.Nombre);
        Console.WriteLine("Nombre Cientifico del Loro: " + lo1.NombreCientifico);
        Console.WriteLine("Comida Favorita del Loro: " + lo1.TipodeComida);
        Console.WriteLine("Color de plumaje del Loro: " + lo1.ColordePlumaje);
        Console.WriteLine("Numero de patas: " + lo1.NumeroPatas);
        Console.WriteLine("Tamaño del pico: " + lo1.Pico + " Cm ");
        Console.WriteLine("");
        lo1.Hablar();
        Console.ReadLine();

    }




    public void CargarAves()
    {
        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Animales de Tipo Ave");
            Console.WriteLine("====================");
            Console.WriteLine("");
            Console.WriteLine("1 - Aguila");
            Console.WriteLine("2 - Loro");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    CargarAguila();

                    break;
                case "2":
                    CargarLoro();
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
