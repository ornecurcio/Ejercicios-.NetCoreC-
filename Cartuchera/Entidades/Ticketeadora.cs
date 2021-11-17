using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ticketeadora
    {
        public static bool ImprimirTicket(Cartuchera<Goma> cartuchera)
        {
            bool exito = false;

            try
            {
                using (StreamWriter sb = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\tickets.log", true))
                {
                    sb.WriteLine(DateTime.Now);
                    sb.WriteLine("Precio total de la cartuchera: $" + cartuchera.PrecioTotal);
                    exito = true;
                }
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

            return exito;
        }
    }
}
