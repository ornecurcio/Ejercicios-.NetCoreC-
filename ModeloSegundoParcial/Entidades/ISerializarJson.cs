using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    interface ISerializarJson
    {
        bool SerializarJson(string ruta);
        bool DeserializarJson(string ruta, out Usuario usuario); 
    }
}
