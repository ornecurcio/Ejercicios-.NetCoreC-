using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization; 


namespace Entidades
{
    public class ClaseGenerica<T, U> : ISerializarXml<T,U>
    {
        protected List<T> lista;
        protected U objeto;

        public ClaseGenerica()
        {
            this.lista = new List<T>();
        }
        public ClaseGenerica(U objeto) : this()
        {
            this.objeto = objeto;
        }

        public List<T> Lista
        {
            get
            {
                return this.lista;
            }
            set
            {
                if (value is not null)
                {
                    this.lista = value;
                }
            }
        }
        public U Objeto
        {
            get
            {
                return this.objeto;
            }
            set
            {
                if (value is not null)
                {
                    this.objeto = value;
                }
            }
        }

        
        public override string ToString()
        {
            return base.ToString();
        }
        public bool DeserealizarXml(string ruta, out ClaseGenerica<T, U> claseGenerica)
        {
            bool rta = false; 
            XmlTextReader xmlReader = null;
            XmlSerializer serializador = null;
            try
            {
                xmlReader = new XmlTextReader(ruta);
                serializador = new XmlSerializer(typeof(ClaseGenerica<T, U>));
                ClaseGenerica<T, U> objetoDesealizado = (ClaseGenerica<T, U>)serializador.Deserialize(xmlReader);
                claseGenerica = objetoDesealizado;
            }
            catch (Exception ex)
            {
                throw new SerializacionException(ex);
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
            }
            return rta;
        }
        public bool SerializarAXml(string ruta)
        {
            bool rta = false;
            XmlTextWriter xmlWriter = null;
            XmlSerializer serializador = null;
            try
            {
                xmlWriter = new XmlTextWriter(ruta, Encoding.UTF8);
                xmlWriter.Formatting = Formatting.Indented;
                serializador = new XmlSerializer(typeof(ClaseGenerica<T, U>));
                serializador.Serialize(xmlWriter, this);

            }
            catch (Exception ex)
            {
                throw new SerializacionException(ex);
            }
            finally
            {
                if (xmlWriter != null)
                {
                    rta = true;
                    xmlWriter.Close();
                }
            }
            return rta;
        }
    }
}
