﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Euro
    {
        // Generamos los atributos para Dolar
        private double cantidad;
        private static double cotizRespectoDolar;

        // Generamos los cronstructores de Dolar
        static Euro()
        {
            cotizRespectoDolar = 1/1.18;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion)
        : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        // Debemos generar los metodos GET, pero en esta ocasion los vamos a remplazar por propiedades

        public double GetCantidad
        {
            get
            {
                return cantidad;
            }
        }
        public static double GetCotizacion
        {
            get
            {
                return cotizRespectoDolar;
            }
        }

        // Generamos la sobrecarga de Double de forma implicita 

        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
    }
}
