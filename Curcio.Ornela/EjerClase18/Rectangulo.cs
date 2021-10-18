using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = Punto.AssignVertice(this.vertice1, this.vertice3);
            this.vertice4 = Punto.AssignVertice(this.vertice3, this.vertice1);
            this.area = Math.Abs(vertice1.GetX() - vertice3.GetX()) * Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.perimetro = (Math.Abs(vertice1.GetX() - vertice3.GetX()) + Math.Abs(vertice1.GetY() - vertice3.GetY())) * 2;
        }
        public float Area()
        {
            return this.area; 
        }
        public float Perimetro()
        {
            return this.perimetro; 
        }
        public void Mostrar()
        {
            Console.WriteLine($"Primer Vertice   x:{this.vertice1.GetX()}  y:{this.vertice1.GetY()}");
            Console.WriteLine($"Segundo Vertice  x:{this.vertice2.GetX()}  y:{this.vertice2.GetY()}");
            Console.WriteLine($"Tercer Vertice   x:{this.vertice3.GetX()}  y:{this.vertice3.GetY()}");
            Console.WriteLine($"Cuarto Vertice  x:{this.vertice4.GetX()}  y:{this.vertice4.GetY()}");
            Console.WriteLine($"Area: {this.area}, Perimetro: {this.perimetro}");
        }

    }
}
