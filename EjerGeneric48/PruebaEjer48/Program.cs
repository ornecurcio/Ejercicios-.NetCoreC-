using System;
using Entidades; 
namespace PruebaEjer48
{
    class Program
    {
        static void Main(string[] args)
        {
            Recibo reciboA = new Recibo();
            Recibo reciboB = new Recibo(1);
            Factura facturaA = new Factura(100);
            Factura facturaB = new Factura(50);

            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            contabilidad += reciboA;
            contabilidad += reciboB;
            contabilidad += facturaA;
            contabilidad += facturaB;

            foreach (Factura item in contabilidad.Egresos)
            {
                Console.WriteLine(item.Numero); 
            }
            Console.WriteLine("----------------------");
            foreach (Recibo item in contabilidad.Ingresos)
            {
                Console.WriteLine(item.Numero);
            }
           
        }
    }
}
