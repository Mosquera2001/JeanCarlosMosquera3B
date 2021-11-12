using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class EmpleadoTemporal : Empleado
    {
        private string _Fecha_de_Ingreso;
        private string _Fecha_de_Salida;
        private double _sueldo1;

        public string Fecha_de_Ingreso { get => _Fecha_de_Ingreso; set => _Fecha_de_Ingreso = value; }
        public string Fecha_de_Salida { get => _Fecha_de_Salida; set => _Fecha_de_Salida = value; }
        public double Sueldo1 { get => _sueldo1; set => _sueldo1 = value; }
    }
}
