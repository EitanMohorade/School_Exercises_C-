public class Direccion
{
    private string calle;
    private string ciudad;
    private int altura;

    public Direccion(int altura, string calle, string ciudad)
    {
        this.altura = altura;
        this.calle = calle;
        this.ciudad = ciudad;
    }
}