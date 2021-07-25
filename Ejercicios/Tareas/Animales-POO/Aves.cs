
using System;
abstract public class Aves: Animal //Abstracción y Herencia//
{
    public string ColordePlumaje { get; set; }
    public  int Pico { get; set; }

    public int NumeroPatas { get; set; }

    public Aves(string nombre, string nombrecientifico, string tipodecomida, string colordeplumaje, int patas,int pico) : base(nombre, nombrecientifico, tipodecomida)
   {
        ColordePlumaje = colordeplumaje;  
        NumeroPatas = 2;
        Pico = pico;
    }
   
    public void Volar() //abstracción//
    {

    }

}