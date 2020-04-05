using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Employees : Person
    {

        public int Sueldo;
        public string Horario;

        public int _sueldo
        {
            get
            {
                return Sueldo;
            }
            set
            {
                Sueldo = value;
            }
        }
        public string _horario
        {
            get
            {
                return Horario;
            }
            set
            {
                Horario = value;
            }
        }

        public Employees(string _rut_, string _nombre_, string _apellido_, string _nacimiento_, string _nacionalidad_,int _sueldo_, string _horario_)
            : base(_rut_, _nombre_, _apellido_, _nacimiento_, _nacionalidad_)
        {
            this._sueldo = _sueldo_;
            this._horario = _horario_;
        }
        public string information()
        {
            string informacion = ("Rut: " + _rut + "\n" + "Nombre: " + _nombre + "\n" + "Apellido: " + _apellido + "\n" + "Fecha de nacimiento: " + _nacimiento + "\n" + "Nacionalidad:" + _nacionalidad + "\n"+ "Sueldo"+ _sueldo + "\n" + "Horario de trabajo" + _horario);
            return informacion;
        }

    }
}
