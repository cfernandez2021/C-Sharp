using System;
public class Mono:Mamiferos //Herencia//
{
    public Mono(string nombre, string nombrecientifico, string tipodecomida, string colordepelo, int patas) : base(nombre, nombrecientifico, tipodecomida, colordepelo, patas)
{

}

 public void MonoMaullando()
    {
        Console.WriteLine(Nombre + " Esta en el arbol Maullando");
    }


}