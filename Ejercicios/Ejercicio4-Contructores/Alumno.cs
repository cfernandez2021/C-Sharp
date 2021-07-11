class Alumno
{
    public int Id { get; set; }
    public string PrimerNombre { get; set; }      

    public string  SegundoNombre { get; set; }

    //Contructor//
    public Alumno()
    {
        Id=1;
    }

    //Contructor que recibe parametros//
    public Alumno(int id)
    {
        Id=id;
    }

     public Alumno(string primerNombre,string segundoNombre)

    {
        PrimerNombre=primerNombre;
        SegundoNombre=segundoNombre;

    }

}