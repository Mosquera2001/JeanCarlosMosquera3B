using System;

namespace PresentacionHereancia1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado persona = new Empleado();
            {
                
                EmpleadoxHoras horas = new EmpleadoxHoras();
                horas.Nombres = "Juan Carlos";
                horas.Apellidos = "Herrera Mendoza";
                horas.Edad = 25;
                horas.Departamento = "Recursos humanos";
                horas.Precio_Hora_Trabajada = 15;
                horas.N_Horas_Trabajadas = 64;
                horas.Sueldo2 = 15 * 64;

                Console.WriteLine("---------------INFORMACIÓN EMPLEADO POR HORAS----------------");
                Console.WriteLine("Nombres : " + horas.Nombres);
                Console.WriteLine("Apellidos : " + horas.Apellidos);
                Console.WriteLine("Edad : " + horas.Edad + " años");
                Console.WriteLine("Departamento : " + horas.Departamento);
                Console.WriteLine("Precio de hora de trabajo : $" + horas.Precio_Hora_Trabajada);
                Console.WriteLine("Numero de horas trabajadas : " + horas.N_Horas_Trabajadas);
                Console.WriteLine("Sueldo Mensual : $" + horas.Sueldo2);

                
                EmpleadoTemporal temporal = new EmpleadoTemporal();
                temporal.Nombres = "Liam Abraham";
                temporal.Apellidos = "Mosquera Rodriguez";
                temporal.Edad = 38;
                temporal.Departamento = "Administración";
                temporal.Fecha_de_Ingreso = "15 de Enero 2021";
                temporal.Fecha_de_Salida = "30 de Octubre 2025";
                temporal.Sueldo1 = 2400;
                Console.WriteLine("---------------INFORMACIÓN EMPLEADO TEMPORAL----------------");
                Console.WriteLine("Nombres : " + temporal.Nombres);
                Console.WriteLine("Apellidos : " + temporal.Apellidos);
                Console.WriteLine("Edad : " + temporal.Edad + " años");
                Console.WriteLine("Departamento : " + temporal.Departamento);
                Console.WriteLine("Fecha de ingreso : " + temporal.Fecha_de_Ingreso);
                Console.WriteLine("Fecha de salida : " + temporal.Fecha_de_Salida);
                Console.WriteLine("Sueldo Mensual : $" + temporal.Sueldo1);

                
                EmpleadoFijo fijo = new EmpleadoFijo();
                fijo.Nombres = "katherine Isabel";
                fijo.Apellidos = "Velez Montesdeoca";
                fijo.Edad = 45;
                fijo.Departamento = "Producción";
                fijo.Año_Ingreso = 2014;
                fijo.Años_Empresa = 7;
                fijo.Sueldo3 = 7*(250+25);
                Console.WriteLine("---------------INFORMACIÓN EMPLEADO FIJO----------------");
                Console.WriteLine("Nombres : " + fijo.Nombres);
                Console.WriteLine("Apellidos : " + fijo.Apellidos);
                Console.WriteLine("Edad : " + fijo.Edad + " años");
                Console.WriteLine("Departamento : " + fijo.Departamento);
                Console.WriteLine("Año de Ingreso : " + fijo.Año_Ingreso);
                Console.WriteLine("Años en la empresa : " + fijo.Años_Empresa);
                Console.WriteLine("Sueldo Mensual : $" + fijo.Sueldo3);

                Console.ReadLine();

            }
            

        }
    }
}
