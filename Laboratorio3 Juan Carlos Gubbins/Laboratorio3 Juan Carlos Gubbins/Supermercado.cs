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
        public void VerEmpleados(List<Employees> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay empleados agregados aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Empleado" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].information());
                    Console.WriteLine(" ");
                }
            }
        }
        public void VerJefes(List<Bosses> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay jefes agregados aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Jefe" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].information());
                    Console.WriteLine(" ");
                }
            }
        }
        public void VerSupervisores(List<Supervisors> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay supervisores agregados aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Supervisor" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].information());
                    Console.WriteLine(" ");
                }
            }
        }
        public void VerAuxiliares(List<Auxiliaries> lista)
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("No hay auxiliares agregados aún");
            }

            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.WriteLine("============");
                    Console.WriteLine("Auxiliar" + " " + (i + 1));
                    Console.WriteLine("============");
                    Console.WriteLine(lista[i].information());
                    Console.WriteLine(" ");
                }
            }
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
            Console.WriteLine("Empleado agregado");
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
            Console.WriteLine("Auxiliar agregado");
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
        public void EmpleadoaJefe(string rut)
        {
            Employees emp = null;
            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    emp = listaempleados[i];

                }

            }
            if (emp== null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún empleado");
            }

            if (emp != null)
            {
                Bosses jefe = new Bosses(emp._rut, emp._nombre, emp._apellido, emp._nacimiento, emp._nacionalidad, emp._sueldo, emp._horario);
                listajefes.Add(jefe);
                Console.WriteLine("El empleado" + emp._nombre + " " + emp._apellido + " " + "de rut:" + emp._rut + "a sido ascendido a jefe");
            }

            
            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut== rut)
                {
                    listaempleados.Remove(listaempleados[i]);

                }

            }

        }
        public void EmpleadoaSuperivsor(string rut)
        {
            Employees emp = null;
            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    emp = listaempleados[i];

                }

            }
            if (emp == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún empleado");
            }

            if (emp != null)
            {
                Supervisors superv = new Supervisors(emp._rut, emp._nombre, emp._apellido, emp._nacimiento, emp._nacionalidad, emp._sueldo, emp._horario);
                listasupervisores.Add(superv);
                Console.WriteLine("El empleado" + emp._nombre + " " + emp._apellido + " " + "de rut:" + emp._rut + "a sido ascendido a supervisor");
            }


            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    listaempleados.Remove(listaempleados[i]);

                }

            }

        }
        public void EmpleadoaAuxiliar(string rut)
        {
            Employees emp = null;
            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    emp = listaempleados[i];

                }

            }
            if (emp == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún empleado");
            }

            if (emp != null)
            {
                Auxiliaries aux = new Auxiliaries(emp._rut, emp._nombre, emp._apellido, emp._nacimiento, emp._nacionalidad, emp._sueldo, emp._horario);
                listauxiliares.Add(aux);
                Console.WriteLine("El empleado" + emp._nombre + " " + emp._apellido + " " + "de rut:" + emp._rut + "a sido camibiado a auxiliar");
            }


            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    listaempleados.Remove(listaempleados[i]);

                }

            }

        }

        public void JefeaEmpleado(string rut)
        {
            Bosses boss = null;
            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    boss = listajefes[i];

                }

            }
            if (boss == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún jefe");
            }

            if (boss != null)
            {
                Employees emple = new Employees(boss._rut, boss._nombre, boss._apellido, boss._nacimiento, boss._nacionalidad, boss._sueldo, boss._horario);
                listaempleados.Add(emple);
                Console.WriteLine("El jefe" + boss._nombre + " " + boss._apellido + " " + "de rut:" + boss._rut + "a sido descendido a empleado");
            }


            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    listajefes.Remove(listajefes[i]);

                }

            }

        }
        public void JefeaSupervisor(string rut)
        {
            Bosses boss = null;
            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    boss = listajefes[i];

                }

            }
            if (boss == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún jefe");
            }

            if (boss != null)
            {
                Supervisors supervi = new Supervisors(boss._rut, boss._nombre, boss._apellido, boss._nacimiento, boss._nacionalidad, boss._sueldo, boss._horario);
                listasupervisores.Add(supervi);
                Console.WriteLine("El jefe" + boss._nombre + " " + boss._apellido + " " + "de rut:" + boss._rut + "a sido camiado a supervisor");
            }


            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    listajefes.Remove(listajefes[i]);

                }

            }

        }
        public void JefeaAuxiliar(string rut)
        {
            Bosses boss = null;
            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    boss = listajefes[i];

                }

            }
            if (boss == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún jefe");
            }

            if (boss != null)
            {
                Auxiliaries auxi = new Auxiliaries(boss._rut, boss._nombre, boss._apellido, boss._nacimiento, boss._nacionalidad, boss._sueldo, boss._horario);
                listauxiliares.Add(auxi);
                Console.WriteLine("El jefe" + boss._nombre + " " + boss._apellido + " " + "de rut:" + boss._rut + "a sido descendido a auxiliar");
            }


            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    listajefes.Remove(listajefes[i]);

                }

            }

        }
        public void SupervisoraEmpleado(string rut)
        {
            Supervisors sv = null;
            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    sv = listasupervisores[i];

                }

            }
            if (sv == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún supervisor");
            }

            if (sv != null)
            {
                Employees emple = new Employees(sv._rut, sv._nombre, sv._apellido, sv._nacimiento, sv._nacionalidad, sv._sueldo, sv._horario);
                listaempleados.Add(emple);
                Console.WriteLine("El supervisor" + sv._nombre + " " + sv._apellido + " " + "de rut:" + sv._rut + "a sido descendido a empleado");
            }


            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    listasupervisores.Remove(listasupervisores[i]);

                }

            }

        }
        public void SupervisoraJefe(string rut)
        {
            Supervisors sv = null;
            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    sv = listasupervisores[i];

                }

            }
            if (sv == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún supervisor");
            }

            if (sv != null)
            {
                Bosses bosse = new Bosses(sv._rut, sv._nombre, sv._apellido, sv._nacimiento, sv._nacionalidad, sv._sueldo, sv._horario);
                listajefes.Add(bosse);
                Console.WriteLine("El supervisor" + sv._nombre + " " + sv._apellido + " " + "de rut:" + sv._rut + "a sido cambiado a jefe");
            }


            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    listasupervisores.Remove(listasupervisores[i]);

                }

            }

        }
        public void SupervisoraAuxiliar(string rut)
        {
            Supervisors sv = null;
            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    sv = listasupervisores[i];

                }

            }
            if (sv == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún supervisor");
            }

            if (sv != null)
            {
                Auxiliaries auxi2 = new Auxiliaries(sv._rut, sv._nombre, sv._apellido, sv._nacimiento, sv._nacionalidad, sv._sueldo, sv._horario);
                listauxiliares.Add(auxi2);
                Console.WriteLine("El supervisor" + sv._nombre + " " + sv._apellido + " " + "de rut:" + sv._rut + "a sido descendido a auxiliar");
            }


            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    listasupervisores.Remove(listasupervisores[i]);

                }

            }

        }
        public void AuxiliaraEmpleado(string rut)
        {
            Auxiliaries ax = null;
            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    ax = listauxiliares[i];

                }

            }
            if (ax == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún auxiliar");
            }

            if (ax != null)
            {
                Employees emple2 = new Employees(ax._rut, ax._nombre, ax._apellido, ax._nacimiento, ax._nacionalidad, ax._sueldo, ax._horario);
                listaempleados.Add(emple2);
                Console.WriteLine("El auxiliar" + ax._nombre + " " + ax._apellido + " " + "de rut:" + ax._rut + "a sido camiado a empleado");
            }


            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    listauxiliares.Remove(listauxiliares[i]);

                }

            }

        }
        public void AuxiliaraJefe(string rut)
        {
            Auxiliaries ax = null;
            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    ax = listauxiliares[i];

                }

            }
            if (ax == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún auxiliar");
            }

            if (ax != null)
            {
                Bosses boss2 = new Bosses(ax._rut, ax._nombre, ax._apellido, ax._nacimiento, ax._nacionalidad, ax._sueldo, ax._horario);
                listajefes.Add(boss2);
                Console.WriteLine("El auxiliar" + ax._nombre + " " + ax._apellido + " " + "de rut:" + ax._rut + "a sido ascendido a jefe");
            }


            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    listauxiliares.Remove(listauxiliares[i]);

                }

            }

        }
        public void AuxiliaraSupervisor(string rut)
        {
            Auxiliaries ax = null;
            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    ax = listauxiliares[i];

                }

            }
            if (ax == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún auxiliar");
            }

            if (ax != null)
            {
                Supervisors suv2 = new Supervisors(ax._rut, ax._nombre, ax._apellido, ax._nacimiento, ax._nacionalidad, ax._sueldo, ax._horario);
                listasupervisores.Add(suv2);
                Console.WriteLine("El auxiliar" + ax._nombre + " " + ax._apellido + " " + "de rut:" + ax._rut + "a sido ascendido a supervisor");
            }


            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    listauxiliares.Remove(listauxiliares[i]);

                }

            }

        }
        public void SueldoEmpleado(string rut, int sueldo)
        {
            Employees e1 = null;
            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    e1 = listaempleados[i];

                }

            }
            if (e1== null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún empleado");
            }
            if (e1 != null)
            {
                e1._sueldo = sueldo;
                Console.WriteLine("Se le a cambiado el sueldo al empleado:" + e1._nombre + " " + e1._apellido + " " + "al monto" + e1._sueldo);
            }

        }
        public void SueldoJefe(string rut, int sueldo)
        {
            Bosses b1 = null;
            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    b1 = listajefes[i];

                }

            }
            if (b1 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún jefe");
            }
            if (b1 != null)
            {
                b1._sueldo = sueldo;
                Console.WriteLine("Se le a cambiado el sueldo al jefe:" + b1._nombre + " " + b1._apellido + " " + "al monto" + b1._sueldo);
            }

        }
        public void SueldoSupervisor(string rut, int sueldo)
        {
            Supervisors s1 = null;
            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    s1 = listasupervisores[i];

                }

            }
            if (s1 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún supervisor");
            }
            if (s1 != null)
            {
                s1._sueldo = sueldo;
                Console.WriteLine("Se le a cambiado el sueldo al supervisor" + s1._nombre + " " + s1._apellido + " " + "al monto" + s1._sueldo);
            }

        }
        public void SueldoAuxiliar(string rut, int sueldo)
        {
            Auxiliaries a1 = null;
            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    a1 = listauxiliares[i];

                }

            }
            if (a1 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún auxiliar");
            }
            if (a1 != null)
            {
                a1._sueldo = sueldo;
                Console.WriteLine("Se le a cambiado el sueldo al auxiliar" + a1._nombre + " " + a1._apellido + " " + "al monto" + a1._sueldo);
            }

        }
        public void HorarioEmpleado(string rut, string horario)
        {
            Employees e2 = null;
            for (int i = 0; i < listaempleados.Count; i++)
            {
                if (listaempleados[i]._rut == rut)
                {
                    e2 = listaempleados[i];

                }

            }
            if (e2 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún empleado");
            }
            if (e2 != null)
            {
                e2._horario = horario;
                Console.WriteLine("Se le a cambiado el horario al empleado" + e2._nombre + " " + e2._apellido + " " + "al horario:" + e2._horario);
            }

        }
        public void HorarioJefe(string rut, string horario)
        {
            Bosses b2 = null;
            for (int i = 0; i < listajefes.Count; i++)
            {
                if (listajefes[i]._rut == rut)
                {
                    b2 = listajefes[i];

                }

            }
            if (b2 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún jefe");
            }
            if (b2 != null)
            {
                b2._horario = horario;
                Console.WriteLine("Se le a cambiado el horario al jefe" +b2._nombre + " " + b2._apellido + " " + "al horario:" + b2._horario);
            }

        }
        public void HorarioSupervisor(string rut, string horario)
        {
            Supervisors s2 = null;
            for (int i = 0; i < listasupervisores.Count; i++)
            {
                if (listasupervisores[i]._rut == rut)
                {
                    s2 = listasupervisores[i];

                }

            }
            if (s2 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún supervisor");
            }
            if (s2 != null)
            {
                s2._horario = horario;
                Console.WriteLine("Se le a cambiado el horario al supervisor" + s2._nombre + " " + s2._apellido + " " + "al horario:" + s2._horario);
            }

        }
        public void HorarioAuxiliar(string rut, string horario)
        {
            Auxiliaries a2 = null;
            for (int i = 0; i < listauxiliares.Count; i++)
            {
                if (listauxiliares[i]._rut == rut)
                {
                    a2 = listauxiliares[i];

                }

            }
            if (a2 == null)
            {
                Console.WriteLine("El rut indicado no coincide con ningún auxiliar");
            }
            if (a2 != null)
            {
                a2._horario = horario;
                Console.WriteLine("Se le a cambiado el horario al auxiliar" + a2._nombre + " " + a2._apellido + " " + "al horario:" + a2._horario);
            }

        }
        //public void RealizarunaCompra(string nombreProducto, string marcaproducto, string rut, string stock)
        //{
            //Client cliente = null;
            //List<Producto> productocompra = new List<Producto>();
            //for  (int i = 0; i < listaclientes.Count; i++)
           //{
                //if (listaclientes[i]._rut == rut)
                //{
                    //cliente= listaclientes[i];
                    

                    

                //}
            //}
            //if (cliente == null)
            //{
                //Console.WriteLine("El rut indicado no coincide con ningún cliente");
                
            //}
            //if (cliente != null)
            //{
                
                //Console.WriteLine("Se ha encontrado al cliente, proceda a elegir los productos");
                
            //}

            //Producto product = null;
            //for (int i = 0; i < listaproductos.Count; i++)
            //{
                //if ((listaproductos[i]._nombreproducto == nombreProducto) && (listaproductos[i]._marca == marcaproducto))
                //{
                    //product = listaproductos[i];

                //}
            //}
            //if (product == null)
            //{
                //Console.WriteLine("El producto indicado no coincide con ningúno que tenga el supermercado");
                
            //}
            //if (product != null)
            //{
                //Console.WriteLine("Producto agregado al carro");
                //productocompra.Add(product);
                //product._stock -= 1;
                //Console.WriteLine("El stock actualizado del producto agregado es:" + product._stock);
                
                
            //}
        //}
    }
}
