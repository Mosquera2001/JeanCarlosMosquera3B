using System;
using System.Collections.Generic;
using System.Text;

namespace PresentacionHereancia1
{
    public class Empleado
    {
        private string _Nombres;
        private string _Apellidos;
        private int _Edad;
        private string _Departamento;

        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
        public string Departamento { get => _Departamento; set => _Departamento = value; }
    }
}
