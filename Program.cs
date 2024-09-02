using Biblioteca.Clases;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la biblioteca virtual!");

            // Creación de libros individuales
            Libro libro1 = new Libro("Un mundo feliz", "Aldous Huxley");
            Libro libro2 = new Libro("Orgullo y prejuicio", "Jane Austen");

            // Mostrar información de un libro
            Console.WriteLine(libro1.ObtenerInformacion());

            // Crear la instancia de la biblioteca
            MiBiblioteca miBiblioteca = new MiBiblioteca();

            // Agregar libros a la biblioteca
            miBiblioteca.AgregarLibro(libro1);
            miBiblioteca.AgregarLibro(libro2);

            // Mostrar todos los libros en la biblioteca
            miBiblioteca.MostrarLibros();

            // Eliminar un libro específico
            miBiblioteca.RemoverLibroPorTitulo("Un mundo feliz");

            // Buscar libros por autor
            miBiblioteca.EncontrarLibrosPorAutor("Jane Austen");
        }
    }
}
