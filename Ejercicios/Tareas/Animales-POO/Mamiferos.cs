using System;
abstract public class Mamiferos : Animal //Herencia y Abstracción//
{
    public string ColordePelo { get; set; }
    public int Patas { get; set; }
    public Mamiferos(string nombre, string nombrecientifico, string tipodecomida,string colordepelo,int patas) : base(nombre, nombrecientifico, tipodecomida)
    {
        ColordePelo = colordepelo;
        Patas = patas;
    }

    private void Caminar() //abstraccion//
    {

    }
}