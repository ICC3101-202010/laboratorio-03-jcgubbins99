using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Person
    {
        private string Rut;
        private string Nombre;
        private string Apellido;
        private string Nacifecha;
        private string Nacionalidad;


        public string _rut
        {
            get
            {
                return Rut;
            }
            set
            {
                Rut = value;
            }
        }

        public string _nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string _apellido
        {
            get
            {
                return Apellido;
            }
            set
            {
                Apellido = value;
            }
        }
        public string _nacimiento
        {
            get
            {
                return Nacifecha;
            }
            set
            {
                Nacifecha = value;
            }
        }
        public string _nacionalidad
        {
            get
            {
                return Nacionalidad;
            }
            set
            {
                Nacionalidad = value;
            }
        }




        public Person(string _rut_, string _nombre_, string _apellido_, string _nacimiento_, string _nacionalidad_)
        {
            this._rut = _rut_;
            this._nombre = _nombre_;
            this._apellido = _apellido_;
            this._nacimiento = _nacimiento_;
            this._nacionalidad = _nacionalidad_;
            
            
        }
    
        

        

    }
}
