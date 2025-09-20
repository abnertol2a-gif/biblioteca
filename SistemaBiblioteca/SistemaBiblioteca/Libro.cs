using System;

namespace SistemaBiblioteca
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public int AnioPublicacion { get; set; }
        public Autor Autor { get; set; }  // Composición

        public Libro(string titulo, string isbn, int anioPublicacion, Autor autor)
        {
            Titulo = titulo;
            Isbn = isbn;
            AnioPublicacion = anioPublicacion;
            Autor = autor;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine($"Año: {AnioPublicacion}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine("-----------------------------------");
        }

        public override string ToString()
        {
            return $"{Titulo} ({AnioPublicacion}) - {Autor.Nombre}";
        }
    }
}
