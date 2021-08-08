public class Vendedor:Persona
{
    public string Salario { get; set; }
    
    public Vendedor(int id, string nombre, string direccion, string telefono, string salario)
    {
        Id = id;
        Nombre = nombre;
        Direccion = direccion;
        Telefono = telefono;
        Salario=salario;
    }

    
    
}