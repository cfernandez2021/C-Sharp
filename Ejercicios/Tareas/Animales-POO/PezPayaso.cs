using System;
public class PezPayaso : Peces  //Herencia//
{
    public PezPayaso(string nombre, string nombrecientifico, string tipodecomida, int numerodealetas, string color) : base(nombre, nombrecientifico, tipodecomida, numerodealetas, color)
    {

    }

    public void PezPayasoComiendo() //Polimorfismo//
    {
        Console.WriteLine(Nombre + " Esta Comiendo unos " + TipodeComida);
    }
}