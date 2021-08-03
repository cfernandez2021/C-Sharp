public class Productos
{
    public int Codigo { get; set; }
    public string Descripcion { get; set; }
    
    public double Precio { get; set; }
    
    public int  Existencia { get; set; }
    
    public Productos(int codigo,string descripcion,double precio,int existencia)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Precio = precio;
        Existencia = existencia;
    }
}