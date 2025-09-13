using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }
        public string getTitulo() { return titulo; }

        public override string ToString()
        {
            return $"Título: {titulo}, Autor: {autor}, Editorial: {editorial}";
        }
    }
}
