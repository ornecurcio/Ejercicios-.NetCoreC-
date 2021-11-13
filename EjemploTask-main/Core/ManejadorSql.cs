using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ConexionDB
    {

        static SqlConnection conexion; // se conecta a la instancia sql
        static SqlCommand comando;  // llevar la consulta
        static SqlDataReader reader; // devolverme los datos 

        static ConexionDB()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-JSBRMN8;Database=Clinica;Trusted_Connection=True;");

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;

        }

        public static List<Paciente> TraerPacientes(string query)
        {
            try
            {
                List<Paciente> auxLista = new List<Paciente>();
                //0   
                comando.CommandText = query;

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    auxLista.Add(new Paciente(
                                            int.Parse(reader[0].ToString()),
                                            reader[1].ToString(),
                                            (EDolencia)int.Parse(reader[2].ToString()),
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
        public static void ModificarPacientesAtendidos(string nombre, string direccion)
        {
            try
            {
                List<string> auxLista = new List<string>();

                comando.CommandText = "Insert into Usuarios values (@Nombre, @Dire ) ";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Dire", direccion);

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.ExecuteNonQuery();

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
