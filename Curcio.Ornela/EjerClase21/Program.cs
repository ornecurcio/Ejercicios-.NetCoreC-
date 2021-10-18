using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temperaturas;

namespace EjerClase21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 21°";

            Kelvin kTemp = new Kelvin(298.15);
            Celsius cTemp = new Celsius(25);
            Fahrenheit fTemp = new Fahrenheit(77);

            Celsius cTemp2 = new Celsius(25);

            Kelvin kNew = new Kelvin();
            Celsius cNew = new Celsius();
            Fahrenheit fNew = new Fahrenheit();

            Console.WriteLine("########## Conversor de Temperatura ##########");
            /*Fahrenheite -> Kelvin*/
            kNew = (Kelvin)fTemp;
            double kNewDouble = kNew.GetAmount();
            Console.WriteLine($"Fahrenheit: {fTemp.GetAmount()}° - Kelvin: {Math.Round(kNewDouble, 2)}°");

            /*Fahrenheite -> Celsius*/
            cNew = (Celsius)fTemp;
            double cNewDouble = cNew.GetAmount();
            Console.WriteLine($"Fahrenheit: {fTemp.GetAmount()}° - Celsius: {cNewDouble}°\n");

            /*Celsius -> Kelvin*/
            kNew = (Kelvin)cTemp;
            kNewDouble = kNew.GetAmount();
            Console.WriteLine($"Celsius: {cTemp.GetAmount()}° - Kelvin: {kNewDouble}°");

            /*Celsius -> Fahrenheite*/
            fNew = (Fahrenheit)cTemp;
            double fNewDouble = fNew.GetAmount();
            Console.WriteLine($"Celsius: {cTemp.GetAmount()}° - Fahrenheit: {fNewDouble}°\n");

            /*Kelvin -> Celsius*/
            cNew = (Celsius)kTemp;
            cNewDouble = cNew.GetAmount();
            Console.WriteLine($"Kelvin: {kTemp.GetAmount()}° - Celsius: {cNewDouble}°");

            /*Kelvin -> Fahrenheit*/
            fNew = (Fahrenheit)kTemp;
            fNewDouble = fNew.GetAmount();
            Console.WriteLine($"Kelvin: {kTemp.GetAmount()}° - Fahrenheit: {Math.Round(fNewDouble, 2)}°\n");

            Console.WriteLine("########## Equivalencia de Temperatura ##########");
            /*Equally: Celsius -> Fahrenheit*/
            Console.WriteLine($"Celsius: {cTemp.GetAmount()}° - Fahrenheit: {fTemp.GetAmount()}° -> Equally: {cTemp == fTemp}");
            /*Equally: Celsius -> Kelvin*/
            Console.WriteLine($"Celsius: {cTemp.GetAmount()}° - Kelvin: {kTemp.GetAmount()}° -> Equally: {cTemp == kTemp}");
            /*Equally: Celsius -> Celsius*/
            Console.WriteLine($"Celsius: {cTemp.GetAmount()}° - Celsius: {cTemp.GetAmount()}° -> Equally: {cTemp == cTemp2}\n");

            Console.WriteLine("########## Sumas de Temperaturas ##########");
            Celsius sumCelsius = new Celsius();
            sumCelsius = cTemp + fTemp;
            Console.WriteLine($" {cTemp.GetAmount()}°C + {fTemp.GetAmount()}°F: {Math.Round(sumCelsius.GetAmount(), 2)}° Celsius");
            sumCelsius = cTemp + kTemp;
            Console.WriteLine($" {cTemp.GetAmount()}°C + {kTemp.GetAmount()}°K: {Math.Round(sumCelsius.GetAmount(), 2)}° Celsius");

            Console.ReadKey();
        }
    }
}
