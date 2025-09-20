using System;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca("Biblioteca Central", "Av. Principal 123");

            // Crear autores
            Autor a1 = new Autor("Gabriel García Márquez", "Colombiana", new DateTime(1927, 3, 6));
            Autor a2 = new Autor("Isabel Allende", "Chilena", new DateTime(1942, 8, 2));
            Autor a3 = new Autor("Mario Vargas Llosa", "Peruana", new DateTime(1936, 3, 28));
            Autor a4 = new Autor("Julio Cortázar", "Argentina", new DateTime(1914, 8, 26));
            Autor a5 = new Autor("J.K. Rowling", "Británica", new DateTime(1965, 7, 31));

            // Crear libros
            biblioteca.AgregarLibro(new Libro("Cien años de soledad", "978-84-376-0494-7", 1967, a1));
            biblioteca.AgregarLibro(new Libro("La casa de los espíritus", "978-84-204-6835-5", 1982, a2));
            biblioteca.AgregarLibro(new Libro("La ciudad y los perros", "978-84-376-0000-0", 1963, a3));
            biblioteca.AgregarLibro(new Libro("Rayuela", "978-84-376-0495-4", 1963, a4));
            biblioteca.AgregarLibro(new Libro("Harry Potter y la piedra filosofal", "978-84-9838-001-1", 1997, a5));

            int opcion;
            do
            {
                Console.WriteLine("\n=== Sistema de Biblioteca ===");
                Console.WriteLine("1. Listar libros");
                Console.WriteLine("2. Buscar libros por autor");
                Console.WriteLine("3. Agregar libro");
                Console.WriteLine("4. Buscar libro por título");
                Console.WriteLine("5. Contar libros en la biblioteca");

                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        biblioteca.ListarLibros();
                        break;
                    case 2:
                        Console.Write("Ingrese el nombre del autor: ");
                        string nombreAutor = Console.ReadLine();
                        biblioteca.BuscarPorAutor(nombreAutor);
                        break;
                    case 3:
                        AgregarLibroMenu(biblioteca);
                        break;

                    case 4:
                        Console.Write("Ingrese parte del título: ");
                        string titulo = Console.ReadLine();
                        biblioteca.BuscarPorTitulo(titulo);
                        break;
                    case 5:
                        biblioteca.ContarLibros();
                        break;

                }
            } while (opcion != 0);
        }

        static void AgregarLibroMenu(Biblioteca biblioteca)
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Año de publicación: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Autor - Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Autor - Nacionalidad: ");
            string nacionalidad = Console.ReadLine();
            Console.Write("Autor - Fecha de nacimiento (yyyy-mm-dd): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            Autor autor = new Autor(nombre, nacionalidad, fecha);
            Libro libro = new Libro(titulo, isbn, anio, autor);
            biblioteca.AgregarLibro(libro);

            Console.WriteLine("Libro agregado con éxito.");
        }
    }
}
