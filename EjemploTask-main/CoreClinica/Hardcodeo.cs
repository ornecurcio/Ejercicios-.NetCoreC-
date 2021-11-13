using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreClinica
{
    public static class Hardcodeo
    {
        public static Queue<Paciente> pacientesHardcodeados;

        static Hardcodeo()
        {
            var lista = DeserializarJson();
            pacientesHardcodeados = new Queue<Paciente>(lista);

        }

        public static Paciente SimularCargaPaciente()
        {
            if (pacientesHardcodeados.Count > 0)
                return pacientesHardcodeados.Dequeue();
            return null;
        }


        private static List<Paciente> DeserializarJson()
        {
            return JsonSerializer.Deserialize<List<Paciente>>(File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory +"Pacientes.json"));
        }





    }
}










