using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class EmpleadoFijo : Empleado
    {
        private int _Año_Ingreso;
        private int _Años_Empresa;
        private double _Sueldo3;
        public int Año_Ingreso { get => _Año_Ingreso; set => _Año_Ingreso = value; }
        public int Años_Empresa { get => _Años_Empresa; set => _Años_Empresa = value; }
        public double Sueldo3 { get => _Sueldo3; set => _Sueldo3 = value; }
    }
}
