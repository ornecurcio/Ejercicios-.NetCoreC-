using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2
    {
        private List<Boligrafo> boligrafos;
        private List<Lapiz> lapices;

        public Cartuchera2()
        {
            this.boligrafos = new List<Boligrafo>();
            this.lapices = new List<Lapiz>();
        }

        public List<Boligrafo>Boligrafos
        {
            get
            {
                return this.boligrafos; 
            }
        }
        public List<Lapiz>Lapices
        {
            get
            {
                return this.lapices; 
            }
        }
        public static Cartuchera2 operator +(Cartuchera2 cartuchera, Lapiz lapiz)
        {
            cartuchera.lapices.Add(lapiz);
            return cartuchera;
        }
        public static Cartuchera2 operator +(Cartuchera2 cartuchera, Boligrafo boligrafo)
        {
            cartuchera.boligrafos.Add(boligrafo);
            return cartuchera;
        }
        public bool ProbarElementos()
        {
            bool rtaBoli = false;
            bool rtaLapiz = false;

            foreach (Lapiz item in this.lapices)
            {
                if (((IAcciones)item).UnidadesDeEscritura < 0)
                {
                    rtaLapiz = false;
                }
                else
                {
                    ((IAcciones)item).Escribir("O");
                    rtaLapiz = true; 
                }
            }

            foreach (Boligrafo item in this.boligrafos)
            {
                if (item.UnidadesDeEscritura < 0)
                {
                    rtaBoli = false;
                }
                else
                {
                    item.Escribir("O");
                    rtaBoli = item.Recargar(1);
                }
            }

            return rtaBoli && rtaLapiz;
        }


    }
}
