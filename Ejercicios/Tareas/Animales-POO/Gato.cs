using System;
public class Gato:Mamiferos //Herencia//
{
    public Gato(string nombre, string nombrecientifico, string tipodecomida, string colordepelo, int patas) : base(nombre, nombrecientifico, tipodecomida, colordepelo, patas)
{
    
} 
        public void Maullar()
    {
        Console.WriteLine("El gato esta Maullando Fuerte");
    }
}