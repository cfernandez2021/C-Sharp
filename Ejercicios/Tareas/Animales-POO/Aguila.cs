using System;
public class Aguila:Aves //Herencia//
{
    public Aguila(string nombre, string nombrecientifico, string tipodecomida, string colordeplumaje, int patas, int pico) : base(nombre, nombrecientifico, tipodecomida, colordeplumaje, patas, pico)
    {
    }

    public void VolarAlto()
    {
        Console.WriteLine(Nombre + " Esta Volando sobre la casa del vecino ");
    }

    public void Cazando()
    {
        Console.WriteLine(Nombre + " atrapo una " + TipodeComida);
    }
}