using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreClinica
{
    public static class ConexionDB
    {

        static SqlConnection conexion; // se conecta a la instancia sql
        static SqlCommand comando;  // llevar la consulta
        static SqlDataReader reader; // devolverme los datos 

        static ConexionDB()
        {
            conexion = new SqlConnection(@"Data Source=LAPTOP-UQ9NJELU\SQLEXPRESS;Database=Clinica;Trusted_Connection=True;");

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }

        public static Queue<Paciente> TraerPacientes()
        { 
            string query = "Select * from pacientes where atendido = 0";
            try
            {
                Queue<Paciente> auxLista = new Queue<Paciente>();
                //0   
                comando.CommandText = query;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Enqueue(new Paciente(
                                            int.Parse(reader[0].ToString()),
                                            reader[1].ToString(),
                                            int.Parse(reader[2].ToString()),
                                            Convert.ToBoolean(reader[3].ToString())
                                            ));
                }

                return auxLista;
            }
            catch (Exception ex)
            {
           
                throw;
            }

            finally
            {
                conexion.Close();
            }
        }
        public static bool InsertarNuevosPacientes(List<Paciente> pacientes)
        {
            try
            {
                List<string> auxLista = new List<string>();
                foreach (Paciente item in pacientes)
                {
                    comando.CommandText += $"Insert into Pacientes values ({item.Dni},'{item.Nombre}',{(int)item.Dolencia},0); ";
               
                }

                comando.Parameters.Clear();



                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();

                pacientes.Clear();
                return true;

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

        }

    }
}
