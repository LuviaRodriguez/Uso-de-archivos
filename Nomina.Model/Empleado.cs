namespace Nomina.Model
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Rfc { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public string NombreCompleto => $"{Nombre} {Apellidos}";

        public Empleado(string nombre, string apellidos, string rfc, DateTime fechaDeIngreso)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Rfc = rfc;
            FechaDeIngreso = fechaDeIngreso;
        }

        public abstract decimal CalcularSalario();
    }
}
