using System.Data.Common;

public class Cliente
{
    private Direccion direccion;
    private string nombre;
    private string apellido;
    private int id;
    public Cliente(string apellido, string nombre, int id, Direccion direccion)
    {
        this.apellido = apellido;
        this.nombre = nombre;
        this.id = id;
        this.direccion = direccion;
    }
}