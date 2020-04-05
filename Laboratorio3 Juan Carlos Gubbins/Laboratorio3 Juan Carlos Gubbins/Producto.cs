using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio3_Juan_Carlos_Gubbins
{
    class Producto
    {

        private string NombreProducto;
        private string Precio;
        private string Marca;
        private int Stock;

        public string _nombreproducto
        {
            get
            {
                return NombreProducto;
            }
            set
            {
                NombreProducto = value;
            }
        }

        public string _precio
        {
            get
            {
                return Precio;
            }
            set
            {
                Precio = value;
            }
        }
        public string _marca
        {
            get
            {
                return Marca;
            }
            set
            {
                Marca = value;
            }
        }
        public int _stock
        {
            get
            {
                return Stock;
            }
            set
            {
                Stock = value;
            }
        }



        public Producto(string _nombreproducto_, string _precio_, string _marca_, int _stock_)
        {
            this._nombreproducto = _nombreproducto_;
            this._precio = _precio_;
            this._marca = _marca_;
            this._stock = _stock_;

        }
        public string informationProducto()
        {
            string informacion = ("Producto:" + _nombreproducto + "\n" + "Precio: " + _precio + "\n" + "Marca: " + _marca + "\n" + "Stock: " + _stock);
            return informacion;
        }
    }
}
