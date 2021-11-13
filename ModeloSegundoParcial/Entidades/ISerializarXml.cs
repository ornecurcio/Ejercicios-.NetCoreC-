using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization; 

namespace Entidades
{
    //2.- Agregar interface para : Serializar y deserializar en xml con bool Serializar(string)
    //y bool Deserializar(string, out Clase<T, U>) en la clase del punto anterior.
    public interface ISerializarXml<T,U>
    {
        bool SerializarAXml(string ruta); 

        bool DeserealizarXml(string ruta, out ClaseGenerica<T,U> claseGenerica); 

    }
}
