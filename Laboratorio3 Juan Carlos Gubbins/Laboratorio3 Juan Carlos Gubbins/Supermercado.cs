using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Supermercado
    {

        public List<Client> listaclientes;
        public List<Employees> listaempleados;
        public List<Bosses> listajefes;
        public List<Supervisors> listasupervisores;
        public List<Auxiliaries> listauxiliares;
        public List<Producto> listaproductos;

        public Supermercado()

        {
            listaclientes = new List<Client>();
            listaempleados = new List<Employees>();
            listajefes = new List<Bosses>();
            listasupervisores = new List<Supervisors>();
            listauxiliares = new List<Auxiliaries>();
            listaproductos = new List<Producto>();
        }
        public bool AgregarCliente(Client _cliente)
        {

            for (int i = 0; i < listaclientes.Count; i++)
            {

                Client ci = listaclientes[i];

                if ((ci._rut == _cliente._rut) && (ci._nombre == _cliente._nombre) && (ci._apellido == _cliente._apellido) && (ci._nacimiento == _cliente._nacimiento) && (ci._nacionalidad == _cliente._nacionalidad))
                {
                    Console.WriteLine("Este cliente ya estaba antes ingresado");
                    return false;
                }

            }

            listaclientes.Add(_cliente);
            Console.WriteLine("Cliente agregado");
            Console.WriteLine("================");
            return true;
        }
        public bool AgregarEmpleado(Employees _empleado)
        {

            for (int i = 0; i < listaempleados.Count; i++)
            {

                Employees ei = listaempleados[i];

                if ((ei._rut == _empleado._rut) && (ei._nombre == _empleado._nombre) && (ei._apellido == _empleado._apellido) && (ei._nacimiento == _empleado._nacimiento) && (ei._nacionalidad == _empleado._nacionalidad))
                {
                    Console.WriteLine("Este empleado ya estaba antes ingresado");
                    return false;
                }

            }

            listaempleados.Add(_empleado);
            Console.WriteLine("Cliente agregado");
            Console.WriteLine("================");
            return true;
        }
        public bool AgregarJefe(Bosses _jefe)
        {

            for (int i = 0; i < listajefes.Count; i++)
            {

                Bosses bi = listajefes[i];

                if ((bi._rut == _jefe._rut) && (bi._nombre == _jefe._nombre) && (bi._apellido == _jefe._apellido) && (bi._nacimiento == _jefe._nacimiento) && (bi._nacionalidad == _jefe._nacionalidad))
                {
                    Console.WriteLine("Este jefe ya estaba antes ingresado");
                    return false;
                }

            }

            listajefes.Add(_jefe);
            Console.WriteLine("Jefe agregado");
            Console.WriteLine("================");
            return true;
        }
        public bool AgregarSupervisor(Supervisors _supervisor)
        {

            for (int i = 0; i < listasupervisores.Count; i++)
            {

                Supervisors si = listasupervisores[i];

                if ((si._rut == _supervisor._rut) && (si._nombre == _supervisor._nombre) && (si._apellido == _supervisor._apellido) && (si._nacimiento == _supervisor._nacimiento) && (si._nacionalidad == _supervisor._nacionalidad))
                {
                    Console.WriteLine("Este supervisor ya estaba antes ingresado");
                    return false;
                }

            }

            listasupervisores.Add(_supervisor);
            Console.WriteLine("Supervisor agregado");
            Console.WriteLine("================");
            return true;
        }
        public bool AgregarAuxiliar(Auxiliaries _auxiliar)
        {

            for (int i = 0; i < listauxiliares.Count; i++)
            {

                Auxiliaries ai = listauxiliares[i];

                if ((ai._rut == _auxiliar._rut) && (ai._nombre == _auxiliar._nombre) && (ai._apellido == _auxiliar._apellido) && (ai._nacimiento == _auxiliar._nacimiento) && (ai._nacionalidad == _auxiliar._nacionalidad))
                {
                    Console.WriteLine("Este auxiliar ya estaba antes ingresado");
                    return false;
                }

            }

            listauxiliares.Add(_auxiliar);
            Console.WriteLine("Supervisor agregado");
            Console.WriteLine("================");
            return true;
        }
        public bool AgregarProducto(Producto _producto)
        {

            for (int i = 0; i < listaproductos.Count; i++)
            {

                Producto pi = listaproductos[i];

                if ((pi._nombreproducto == _producto._nombreproducto) && (pi._precio == _producto._precio) && (pi._marca == _producto._marca) && (pi._stock == _producto._stock))
                {
                    Console.WriteLine("Este producto ya estaba antes ingresado");
                    return false;
                }

            }

            listaproductos.Add(_producto);
            Console.WriteLine("Producto agregado");
            Console.WriteLine("================");
            return true;
        }
    }
}
