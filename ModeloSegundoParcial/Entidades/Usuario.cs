using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario//: ISerializarJson
    {
        public int id;
        public string nombre;
        public int edad;

        public override string ToString()
        {
            return  $"ID: {this.id}\n" +
                    $"Nombre: { this.nombre}\n" +
                    $"Edad: {this.edad}\n"; 
        }

        public bool SerializarAJason(string ruta)
        {
            bool rta = true;
            try
            {
                if (this is null)
                {
                    rta = false; 
                    throw new Exception("objeto nulo");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize(this, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
            }
            catch (Exception ex)
            {
                rta = false;
                throw new SerializacionException(ex.Message);
            }
            return rta; 
        }

        bool DeserealizarDesdeJson(string ruta, out Usuario usuario)
        {
            bool rta = true;
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                Usuario objetoDeserealizado = JsonSerializer.Deserialize(objetoJson, jsonSerializerOptions);

                usuario = objetoDeserealizado;
            }
            catch (Exception ex)
            {
                rta = false; 
                throw new SerializacionException(ex.Message);
            }
            return rta; 
        }
    }
}
