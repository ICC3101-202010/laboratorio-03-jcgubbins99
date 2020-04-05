using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Client : Person
    {
       
        public Client(string _rut_, string _nombre_, string _apellido_, string _nacimiento_, string _nacionalidad_)
            : base(_rut_, _nombre_, _apellido_, _nacimiento_, _nacionalidad_)
        {
            
        }
        public string information()
        {
            string informacion = ("Rut: " + _rut + "\n" + "Nombre: " + _nombre + "\n" + "Apellido: " + _apellido + "\n" + "Fecha de nacimiento: " + _nacimiento + "\n" + "Nacionalidad:" + _nacionalidad);
            return informacion;
        }

    }
}
