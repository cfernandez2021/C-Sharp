using System;
public class Loro:Aves //Herencia//
{
    
    public Loro(string nombre, string nombrecientifico, string tipodecomida, string colordeplumaje, int patas, int pico) : base (nombre, nombrecientifico, tipodecomida, colordeplumaje, patas, pico)
{

}

    public void Hablar()
    {
        Console.WriteLine(Nombre + " Dijo : Hola Progrmadores");
    }

}