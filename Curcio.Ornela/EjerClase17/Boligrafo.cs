using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100; 
        private ConsoleColor color;
        private short tinta;
        public Boligrafo()
        {
            this.tinta = cantidadTintaMaxima; 
            this.color = ConsoleColor.Black;
        }
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color; 
        }
        public ConsoleColor GetColor()
        {
            return this.color; 
        }
        public short GetTinta()
        {
            return this.tinta; 
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool esValido = false;
            dibujo = "";
            short tanqueInicial = GetTinta();
            short tanqueFinal;

            if (gasto > 0 )
            {
                if (tanqueInicial > 0)
                {
                    tanqueFinal = (short)(tanqueInicial - gasto);
                    this.SetTinta(tanqueFinal);
                    if (tanqueInicial < gasto)
                    {
                        for (int i = 0; i < tanqueInicial; i++)
                        {
                            dibujo += "*";
                        }
                        ImprimirEnColor(dibujo); 
                    }
                    else 
                    {
                        for (int i = 0; i < gasto; i++)
                        {
                            dibujo += "*";
                        }
                        ImprimirEnColor(dibujo); 
                    }
                    esValido = true; 
                }
                else
                {
                    Console.WriteLine("Tanque vacio");
                }
            }
            return esValido; 
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima); 
        }
        private void SetTinta(short tinta)
        {
            short actualTinta = tinta;
            if (actualTinta < 0)
            {
                this.tinta = 0;
            }
            else 
            {
                if (actualTinta >= 0 && actualTinta <= cantidadTintaMaxima)
                {
                    this.tinta = actualTinta;
                }
                else
                {
                    this.tinta = cantidadTintaMaxima;
                }
            }
        }
        public void ImprimirEnColor(string dibujo)
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine(dibujo);
            Console.ResetColor();
        }
    }
}
