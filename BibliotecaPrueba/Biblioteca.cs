using BibliotecaPrueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Libro> librosPrestados;
        private List<Lector> lectores;
        

        public Biblioteca()
        {
            string editorial = null;
            string autor = null;
            string titulo = null;
            Libro libro = new Libro(titulo,autor,editorial);
            libros = new List<Libro>();
            lectores = new List<Lector>();
            

        }
        private Libro buscarLibro(string titulo)
        { 
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count &&!libros[i].getTitulo().Equals(titulo))
            i++;
            if (i != libros.Count)
                libroBuscado = libros[i];
            return libroBuscado;
        }
        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }
        public void listarLibros()
        {
            foreach (var libro in libros)
                Console.WriteLine(libro);
        }
        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }
        public string prestarLibro(string titulo, string dni)
        {
            // 1. Busca si el libro existe en la biblioteca.
            Libro libroAPrestar = buscarLibro(titulo);
            if (libroAPrestar == null)
            {
                return "LIBRO INEXISTENTE";
            }

            // 2. Busca si el lector existe en la biblioteca.
            Lector lectorSolicitante = BuscarLectorPorDni(dni);
            if (lectorSolicitante == null)
            {
                return "LECTOR INEXISTENTE";
            }

            // 3. Verifica si el lector ya tiene 3 libros en préstamo.
            if (!lectorSolicitante.agregarPrestamo(dni))
            {
                return "TOPE DE PRESTAMO ALCAZADO";
            }

            // 4. Si todas las condiciones se cumplen, realiza el préstamo.
            // Elimina el libro de la colección de la biblioteca.
            //libros.Remove(libroAPrestar);

            // Agrega el libro a la colección de libros prestados del lector.
            //lectorSolicitante.agregarPrestamo(libroAPrestar);

            return "PRESTAMO EXITOSO";
        }
        public Lector BuscarLectorPorDni(string dni)
        {
            foreach (var lector in lectores)
            {
                if (lector.getDni().Equals(dni))
                {
                    return lector;
                }
            }
            return null;
        }
    }
}
