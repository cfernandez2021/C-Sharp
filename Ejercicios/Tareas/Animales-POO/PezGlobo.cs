using System;
public class PezGlobo:Peces //Herencia//
{
    public PezGlobo(string nombre, string nombrecientifico, string tipodecomida, int numerodealetas, string color) : base(nombre, nombrecientifico, tipodecomida, numerodealetas, color)
    { 
        
}

    public void Inflarse()
    {
        Console.WriteLine("Pez Globo Inflandose");
    }
    
}