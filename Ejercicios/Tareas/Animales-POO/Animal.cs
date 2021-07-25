using System;
abstract public class Animal //Abstracción y Herencia//
{
    public string Nombre { get; set; }
    public string NombreCientifico { get; set; }
    public string TipodeComida { get; set; }
    public Animal(string nombre, string nombrecientifico,string tipodecomida)
    {
      
        Nombre = nombre;
        NombreCientifico = nombrecientifico;
        TipodeComida = tipodecomida;

    }

    public void Comiendo()  //Polimorfismo//
    {
        Console.WriteLine(Nombre + " Esta Comiendo ");
    }

}