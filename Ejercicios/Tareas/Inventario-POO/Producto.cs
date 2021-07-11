public class Producto
{
    public string Codigo { get; set; }              //Propiedad de codigo//
    public string Descripcion { get; set; }             //Propiedad descripcion//
    public int Existencia { get; set; }                 //Propiedad de la existencia//

    public Producto(string codigo, string descripcion, int existencia)      //Constructor para inicializar las variables//
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
    }

}