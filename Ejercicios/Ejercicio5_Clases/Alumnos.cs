public class Alumnos
{
    public int Id { get; set; }
    public string PrimerNombre { get; set; }
    public string SegundoNombre { get; set; }

//Constructores //
    public Alumnos() 
    {
            Id=1;
    }
//este constructor inicializa el valor de la id//
    public Alumnos(int id)
    {
        Id=id;
    }

    //constructor de nombres//
    public Alumnos(string primerNombre, string segundoNombre)
    {
    PrimerNombre=primerNombre;
    SegundoNombre=segundoNombre;
    }
}