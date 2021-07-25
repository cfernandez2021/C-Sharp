using System;
abstract public class Peces : Animal //Abstracción y Herencia//
{

    public int NumerodeAlestas { get; set; }
    public string Color { get; set; }
    public Peces(string nombre, string nombrecientifico, string tipodecomida,int numerodealetas,string color) : base(nombre, nombrecientifico, tipodecomida)
    {
     NumerodeAlestas = numerodealetas;  //Polimorfismo//
        Color = color;
    }

    public void Nadar()
    {
        Console.WriteLine(Nombre + " Nada por el Arresife de coral");
    }


}