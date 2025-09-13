using WinFormsApp2;

public class Program
{
    public static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        //cargarLibros(5);
        biblioteca.listarLibros();
        biblioteca.eliminarLibro("Libro3");
        biblioteca.listarLibros();

        biblioteca.BuscarLectorPorDni("123");
        //void cargarLibros(int cantidad)
        //{
        //    bool pude;
        //    for (int i = 1; i <= cantidad; i++)
        //    {
        //        pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
        //        if (pude)
        //            Console.WriteLine("Se agregó el libro " + i);
        //        else
        //            Console.WriteLine("No se pudo agregar el libro " + i);
        //    }
        //}
    }
}