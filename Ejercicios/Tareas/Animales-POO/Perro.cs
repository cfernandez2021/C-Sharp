using System;
public class Perro:Mamiferos //Herencia//
{
    public Perro(string nombre, string nombrecientifico, string tipodecomida, string colordepelo, int patas) : base(nombre, nombrecientifico, tipodecomida,colordepelo,patas)
    {
    
    }

    public void Ladrar()
    {
        Console.WriteLine(Nombre + " Esta ladrando");
    }
    
    
}