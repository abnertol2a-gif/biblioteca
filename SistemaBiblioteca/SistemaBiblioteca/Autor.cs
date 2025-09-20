using System;

namespace SistemaBiblioteca
{
    public class Autor
    {
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Autor(string nombre, string nacionalidad, DateTime fechaNacimiento)
        {
            Nombre = nombre;
            Nacionalidad = nacionalidad;
            FechaNacimiento = fechaNacimiento;
        }

        public int GetEdad()
        {
            int edad = DateTime.Now.Year - FechaNacimiento.Year;
            if (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear)
                edad--;
            return edad;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Nacionalidad}), {GetEdad()} años";
        }
    }
}
