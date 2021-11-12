using System;


namespace Entidades
{
    public static class Extension
    {
        /*Reemplazar cualquier número divisible por 3 con la palabra
        “Fizz” y cualquier número divisible por cinco con la palabra
        “Buzz”. Cualquier número divisible por ambos debe
        reemplazarse por "Fizz Buzz".*/
        
        public static string FizzBuzz(this Int32 numero)
        {
            try
            {
                string resultado = string.Empty;
                if (numero % 3 == 0)
                {
                    resultado += "Fizz";
                }
                if (numero % 5 == 0)
                {
                    resultado += "Buzz";
                }
                if (string.IsNullOrWhiteSpace(resultado))
                {
                    resultado += numero.ToString();
                }

                return resultado;
            }
            catch (Exception)
            { 

            }
            finally
            {
                
            }
        }
    }
}
