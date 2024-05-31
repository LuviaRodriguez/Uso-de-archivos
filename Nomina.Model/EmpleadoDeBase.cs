namespace Nomina.Model
{
    public class EmpleadoDeBase : Empleado
    {
        public readonly decimal EstimuloPorAniosTrabajados = 50.0M;
        public readonly int MinimoDeAniosSinRecibirEstimulo = 5;
        public readonly int NumeroDeDiasDelPeriodo = 15;

        public decimal SalarioDiario { get;  set; }

        public EmpleadoDeBase(string nombre, string apellidos, string rfc, DateTime fechaDeIngreso, decimal salarioDiario) : base(nombre, apellidos, rfc, fechaDeIngreso)
        {
            SalarioDiario = salarioDiario;
        }

        public decimal CalcularSalarioFijoDelPeriodo(int numeroDeDiasTrabajados)
        {
            return SalarioDiario * numeroDeDiasTrabajados;
        }

        public decimal CalcularEstimuloPorAntiguedad()
        {
            int aniosLaborando = 0;
            decimal estimulo = 0.0M;

            if (FechaDeIngreso < DateTime.Now)
            {
                DateTime momentoCero = new DateTime(1, 1, 1);
                TimeSpan lapso = DateTime.Now - FechaDeIngreso;
                aniosLaborando = (momentoCero + lapso).Year - 1;
            }
            if (aniosLaborando > MinimoDeAniosSinRecibirEstimulo)
            {
                estimulo = (aniosLaborando - MinimoDeAniosSinRecibirEstimulo) * EstimuloPorAniosTrabajados;
            }
            return estimulo;
        }

        //public new decimal CalcularSalario()
        //{
            //return CalcularSalarioFijoDelPeriodo(NumeroDeDiasDelPeriodo) + CalcularEstimuloPorAntiguedad();
        //}

        public override decimal CalcularSalario()
        {
            return CalcularSalarioFijoDelPeriodo(NumeroDeDiasDelPeriodo) + CalcularEstimuloPorAntiguedad();
        }
    }
}
