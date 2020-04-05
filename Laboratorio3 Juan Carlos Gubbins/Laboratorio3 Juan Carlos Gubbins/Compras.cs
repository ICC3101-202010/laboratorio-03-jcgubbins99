using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Boleta
    {
        DateTime fechahora;
        public List<Producto> listaproduct = new List<Producto>();
        Client c1;
        Employees e1;

        public Boleta(Client c1, List<Producto> listaproduct, Employees e1)
        {

            this.listaproduct = listaproduct;
            this.fechahora = DateTime.Now;
            this.c1 = c1;
            this.e1 = e1;



        }
        public void informationPLN()
        {
            Console.WriteLine("Nombre cliente:" + c1._nombre + " " + c1._apellido);
            Console.WriteLine("Nombre empleado que lo atendió:" + e1._nombre + " " + e1._apellido);
            Console.WriteLine(" Fecha de atención:" + " " + DateTime.Now);

        }


        public void informationPLL()
        {

            if (listaproduct.Count == 0)
            {
                Console.WriteLine("No hay productos agregados al carro");

            }

            else
            {
                for (int i = 0; i < listaproduct.Count; i++)
                {
                    Console.WriteLine("Producto" + " " + (i + 1));
                    Console.WriteLine("============================== ");
                    Console.WriteLine(listaproduct[i].informationProducto());

                }
            }

        }
    }
}

