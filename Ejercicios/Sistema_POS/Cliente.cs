using System;
public class Cliente:Persona //Herencia
{
    public int Edad { get; set; }
    
    public Cliente(int id,string nombre,string direccion,string telefono,int edad) //Polimorfismo
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        Edad = edad;
    }

    public void terceraEdad()
    {
        Console.WriteLine("Calcular descuento");
    }


    
}