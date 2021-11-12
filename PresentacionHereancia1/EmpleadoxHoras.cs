using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class EmpleadoxHoras : Empleado
    {
        private int _Precio_Hora_Trabajada;
        private int _N_Horas_Trabajadas;
        private double _sueldo2;


        public int Precio_Hora_Trabajada { get => _Precio_Hora_Trabajada; set => _Precio_Hora_Trabajada = value; }
        public int N_Horas_Trabajadas { get => _N_Horas_Trabajadas; set => _N_Horas_Trabajadas = value; }
        public double Sueldo2 { get => _sueldo2; set => _sueldo2 = value; }
    }

}
