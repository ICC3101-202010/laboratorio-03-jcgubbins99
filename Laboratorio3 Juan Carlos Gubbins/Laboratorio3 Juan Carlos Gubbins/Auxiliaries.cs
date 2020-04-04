using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Auxiliaries : Person
    {
      
        public Auxiliaries(string _rut_, string _nombre_, string _apellido_, string _nacimiento_, string _nacionalidad_, string _rol_)
            : base(_rut_, _nombre_, _apellido_, _nacimiento_, _nacionalidad_,_rol_)
        {
            this._rol = _rol_;
        }
        public string information()
        {
            string informacion = ("Rol:" + _rol + "\n" + "Rut: " + _rut + "\n" + "Nombre: " + _nombre + "\n" + "Apellido: " + _apellido + "\n" + "Fecha de nacimiento: " + _nacimiento + "\n" + "Nacionalidad:" + _nacionalidad);
            return informacion;
        }

    }
}
