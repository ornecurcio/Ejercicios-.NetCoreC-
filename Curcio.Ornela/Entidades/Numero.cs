using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double valor;

        private Numero(double valor)
        {
            this.valor = valor;
        }
        public static implicit operator Numero(double valor)
        {
            return new Numero(valor); 
        }
        public static explicit operator double(Numero n1)
        {
            return n1.valor;
        }
        public static bool operator ==(Numero n1, Numero n2)
        {
            return n1 == n2.valor;
        }
        public static bool operator !=(Numero n1, Numero n2)
        {
            return !(n1 == n2); // tratar de reutilizar el codigo de la logica positiva y negarla
        }

        public static bool operator ==(Numero n1, double n2)
        {
            return n1.valor == n2;
        }
        public static bool operator !=(Numero n1, double n2)
        {
            return !(n1 == n2);
        }
        public static Numero operator +(Numero n1, Numero n2)
        {
            double suma = n1.valor + (double)n2; 
            Numero rta = new Numero(suma);
            return rta; 
        }
        public static Numero operator -(Numero n1, Numero n2) 
        {
            double resta = n1.valor - n2.valor;
            Numero rta = new Numero(resta);
            return rta;
        }
        public static Numero operator ++(Numero n1)
        {
            //acá también se podría reutilizar la conversión explícita
            double incremento = n1.valor++;

            Numero rta = new Numero(incremento);

            return rta;
        }

        public static Numero operator --(Numero n1)
        {
            //acá también se podría reutilizar la conversión explícita
            double decremento = n1.valor--;

            Numero rta = new Numero(decremento);

            return rta;
        }
    }
}