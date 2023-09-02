public class Pelicula
{
    private Genero genero;
    private string titulo;
    private int duracion;

    public Pelicula(int duracion, string titulo, Genero genero)
    {
        this.duracion = duracion;
        this.titulo = titulo;
        this.genero = genero;
    }
}