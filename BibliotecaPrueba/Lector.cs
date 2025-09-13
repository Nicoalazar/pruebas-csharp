using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2;

namespace BibliotecaPrueba
{
    public class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> librosPrestados;
        private List<Lector> lectores;

        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosPrestados = new List<Libro>();
            this.lectores = new List<Lector>();
        }

        public string getDni()
        {
            return dni;
        }

        // Método privado para buscar un lector por su DNI.
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
        public bool AltaLector(string nombre, string dni)
        {
            // Busca si ya existe un lector con ese DNI.
            Lector lectorExistente = BuscarLectorPorDni(dni);

            if (lectorExistente == null)
            {
                // Si no existe, lo crea y lo agrega a la lista de lectores.
                Lector nuevoLector = new Lector(nombre, dni);
                lectores.Add(nuevoLector);
                return true;
            }
            else
            {
                // Si el lector ya existe, retorna false.
                return false;
            }
        }

        public bool agregarPrestamo(string dni)
        {
            if (librosPrestados.Count < 3)
            {
                //librosPrestados.Add(libro);
                return true;
            }
            else return false;
        }

        //public void listarPrestamos()
        //{
        //    Console.WriteLine("Prestamos de " + nombre + ":");
        //    foreach (var libro in librosPrestados)
        //    {
        //        Console.WriteLine(libro);
        //    }
        //}
    }
}
