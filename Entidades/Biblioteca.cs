using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Biblioteca
    {
        private List<Libro> libros ;

        private string nombre;
        

        public List<Libro> Libros 
        { 
            get 
            { 
                return libros; 
            } 
        }

        public Biblioteca(string nombre) 
        { 
            this.nombre = nombre;
            libros = new List<Libro>();
        }

        public static string DetallarBiblioteca(Biblioteca biblioteca)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {biblioteca.nombre}");
            if ( biblioteca.Libros.Count > 0 ) 
            {
                sb.AppendLine("Listado de libros: ");
                foreach (var libro in biblioteca.Libros)
                {
                    sb.AppendLine($"{libro.Detalle}");
                }
            }

            return sb.ToString();
        }
        public static bool operator ==(Biblioteca biblioteca, Libro libro) 
        {
            if (biblioteca.Libros.Contains(libro))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Biblioteca biblioteca, Libro libro) 
        { 
            return (biblioteca == libro);
        }

        public static Biblioteca operator+(Biblioteca biblioteca, Libro libro)
        {
            if (!biblioteca.Libros.Contains(libro))
            {
                biblioteca.Libros.Add(libro);
            }
            return biblioteca;

        }
        public static Biblioteca operator-(Biblioteca biblioteca, Libro libro)
        {
            if (biblioteca.Libros.Contains(libro))
            {
                biblioteca.Libros.Remove(libro);
            }
            return biblioteca;
        }
        public static explicit operator Biblioteca(string nombre)
        {
            return new Biblioteca(nombre);
        }
    }
}
