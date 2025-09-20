using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        private List<Libro> libros = new List<Libro>();

        public Biblioteca(string nombre, string direccion)
        {
            Nombre = nombre;
            Direccion = direccion;
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void BuscarPorAutor(string nombreAutor)
        {
            var encontrados = libros.Where(l => l.Autor.Nombre.Equals(nombreAutor, StringComparison.OrdinalIgnoreCase)).ToList();

            if (encontrados.Count == 0)
            {
                Console.WriteLine($"No se encontraron libros del autor {nombreAutor}.");
            }
            else
            {
                Console.WriteLine($"Libros de {nombreAutor}:");
                foreach (var libro in encontrados)
                {
                    libro.MostrarInformacion();
                }
            }
        }

        public void ListarLibros()
        {
            Console.WriteLine("=== Libros en la biblioteca ===");
            foreach (var libro in libros)
            {
                libro.MostrarInformacion();
            }
        }

        // 🔹 Función extra 1: Buscar libro por título
        public void BuscarPorTitulo(string titulo)
        {
            var encontrados = libros.Where(l => l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
            if (encontrados.Count == 0)
            {
                Console.WriteLine($"No se encontraron libros con el título que contiene: {titulo}.");
            }
            else
            {
                Console.WriteLine("Libros encontrados:");
                foreach (var libro in encontrados)
                {
                    libro.MostrarInformacion();
                }
            }
        }

        // 🔹 Función extra 2: Contar libros
        public void ContarLibros()
        {
            Console.WriteLine($"La biblioteca tiene un total de {libros.Count} libros.");
        }

    }
}
