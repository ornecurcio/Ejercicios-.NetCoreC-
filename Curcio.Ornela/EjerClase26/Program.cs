using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            Random num = new Random();
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    int aux= num.Next(-85,80);
            //    if (aux != 0)
            //    {
            //        numeros[i] = aux; 
            //    }
            //}
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}
            //Console.WriteLine("-----------------------------");
            //Array.Reverse(numeros);
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (numeros[i] > 0)
            //    { 
            //        Console.WriteLine(numeros[i]); 
            //    } 
            //}
            //Console.WriteLine("-----------------------------");
            //Array.Sort(numeros);
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    if (numeros[i] < 0)
            //    {
            //        Console.WriteLine(numeros[i]);
            //    }
            //}
            Console.WriteLine("-----------------------------");
            List<int>NumerosLista= new List<int>();
            NumerosLista.Add(num.Next(-85, 80));
            NumerosLista.Add(num.Next(-85, 80));
            NumerosLista.Add(num.Next(-85, 80));
            NumerosLista.Insert(0,1000);
            NumerosLista.Insert(1, -300);
            for (int i = 0; i < NumerosLista.Count; i++)
            {
                Console.WriteLine(NumerosLista[i]);
            }
          
            NumerosLista.Reverse();
            Console.WriteLine("-----------------------------");
            foreach (int item in NumerosLista)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("-----------------------------");
            NumerosLista.Sort();
            foreach (int item in NumerosLista)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey(); 
        }
    }
}
