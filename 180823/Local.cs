public class Local
{

    private Direccion direccion;
    private List<Pelicula> listaPeliculas;
    private List<Prestamo> listaPrestamos;
    private List<Cliente> listaClientes;

    public Local(List<Cliente> listaClientes, List<Pelicula> listaPeliculas, List<Prestamo> listaPrestamos, Direccion direccion)
    {
        this.listaClientes = listaClientes;
        this.listaPeliculas = listaPeliculas;
        this.listaPrestamos = listaPrestamos;
        this.direccion = direccion;
    }
}