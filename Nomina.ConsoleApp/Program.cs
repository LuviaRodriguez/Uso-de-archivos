using Nomina.Model;
using System;

Console.WriteLine("Demostración de relación de herencia en una nómina.\n");
List<Empleado> empleados = new List<Empleado>();
empleados.Add(new EmpleadoDeBase("Maria", "Moreno", "MOMA19570824ABC", new
DateTime(2016, 6, 16), 350.0M));
empleados.Add(new EmpleadoDeBase("Alberto", "Arjona", "ARAL19970314DEF", new 
DateTime(2022, 1, 1), 300.0M));
empleados.Add(new EmpleadoConComision("Raul", "Ramirez", "RARA19850801GHI", new 
DateTime(2020, 1, 1)));
empleados.Add(new EmpleadoConComision("Josefina", "Júarez", "JUJO19950915JKL", new 
DateTime(2021, 3, 16)));

//for (int i = 0; i < empleados.Count; i++)
//{
//ImprimirInfoDeEmpleado(empleados[i]);
//}

foreach (var empleado in empleados)
{ 
  ImprimirInfoDeEmpleado(empleado);
}

//EmpleadoDeBase empleadoDeBase2 = new EmpleadoDeBase("Alberto", "Arjona", "ARAL19970314DEF", new
//ImprimirInfoDeEmpleadoDeBase(empleadoDeBase2);
//Console.WriteLine();

//EmpleadoConComision empleadoConComision1 = new EmpleadoConComision("Raul", "Ramirez", "RARA19850801GHI", new
//empleadoConComision1.ImporteTotalDeVentas = 33250.0M;
//ImprimirInfoDeEmpleadoConComision(empleadoConComision1);
//Console.WriteLine();

//EmpleadoConComision empleadoConComision2 = new EmpleadoConComision("Josefina", "Juárez", "JUJO19950915JKL", new
//empleadoConComision2.ImporteTotalDeVentas = 23345.0M;
//ImprimirInfoDeEmpleadoConComision(empleadoConComision2);

void ImprimirInfoDeEmpleado(Empleado empleado)
{
    Console.WriteLine($"Nombre completo: {empleado.NombreCompleto}");
    Console.WriteLine($"Rfc: {empleado.Rfc}");
    Console.WriteLine($"Fecha de ingreso: {empleado.FechaDeIngreso}");
    Console.WriteLine($"Salario del periodo: {empleado.CalcularSalario()}");
}

