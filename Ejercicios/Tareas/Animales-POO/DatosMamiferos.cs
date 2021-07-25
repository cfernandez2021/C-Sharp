using System;
public class Datos
{
    
    private void CargarPerro()   //Encapsulamiento//
    {
        Console.Clear();
        Console.WriteLine("Perros");
        Console.WriteLine("*******************");
        Console.WriteLine("N1");
        Console.WriteLine("********************");

        Perro pastoraleman = new Perro("Pastor Aleman","Canis lupus familiaris","Carne , pollo ,Etc","Cafe",4);
        Console.WriteLine("Nombre del perro: " + pastoraleman.Nombre);
        Console.WriteLine("Nombre Cientifico del perro: " + pastoraleman.NombreCientifico);
        Console.WriteLine("Comida Favorita: " + pastoraleman.TipodeComida);
        Console.WriteLine("Color de pelo: " + pastoraleman.ColordePelo);
        Console.WriteLine("Numero de patas: " + pastoraleman.Patas);
        pastoraleman.Ladrar();

        Console.WriteLine("");
        Console.WriteLine("N2");
        Console.WriteLine("********************");
        Perro huski = new Perro("Huski Siberiano", "Canis lupus familiaris", "Carne , Pescado ,Pollo , Etc", "Blando y Gris", 4);
        Console.WriteLine("Nombre del perro: " + huski.Nombre);
        Console.WriteLine("Nombre Cientifico del perro: " + huski.NombreCientifico);
        Console.WriteLine("Comida Favorita: " + huski.TipodeComida);
        Console.WriteLine("Color de pelo: " + huski.ColordePelo);
        Console.WriteLine("Numero de patas: " + huski.Patas);
        huski.Comiendo();
        Console.ReadLine();

    }

    private void CargarGato() //Encapsulamiento//
    {
        Console.Clear();
        Console.WriteLine("Gatos");
        Console.WriteLine("*******************");
        Console.WriteLine("N1");
        Console.WriteLine("********************");

        Gato gato = new Gato("Gato Persa","Felis catus","Pescado","Blanco",4);
        Console.WriteLine("Nombre del Gato: " + gato.Nombre);
        Console.WriteLine("Nombre Cientifico del Gato: " + gato.NombreCientifico);
        Console.WriteLine("Comida Favorita del Gato: " + gato.TipodeComida);
        Console.WriteLine("Color de Pelaje del Gato: " + gato.ColordePelo);
        Console.WriteLine("Numero de Patas del Gato: " + gato.Patas);
        Console.WriteLine("");
        gato.Maullar();
        Console.ReadLine();

    }

    
    private void CargarMono() //Encapsulamiento//
    {

        Console.Clear();
        Console.WriteLine("Monos");
        Console.WriteLine("*******************");
        Console.WriteLine("N1");
        Console.WriteLine("********************");
        Mono mono = new Mono("Mandril", "Mandrillus sphinx", "Arañas y Huevos", "Cafe con manchas Blancas", 4);
        Console.WriteLine("Nombre del Mono: " + mono.Nombre);
        Console.WriteLine("Nombre Cientifico del Mono: " + mono.NombreCientifico);
        Console.WriteLine("Comida Favorita del Mono: " + mono.TipodeComida);
        Console.WriteLine("Color de Pelaje del Mono: " + mono.ColordePelo);
        Console.WriteLine("Numero de Patas del Mono: " + mono.Patas);
        Console.WriteLine("");
        mono.MonoMaullando();
        Console.ReadLine();

    }
    public void CargarMamiferos()
    {

        string opcion = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Animales Mamiferos");
            Console.WriteLine("====================");
            Console.WriteLine("");
            Console.WriteLine("1 - Perro");
            Console.WriteLine("2 - Gato");
            Console.WriteLine("3 - Mono");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("Elija una opcion: ");
            opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    CargarPerro();
                    break;
                case "2":
                    CargarGato();
                    break;
                case "3":
                    CargarMono();
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