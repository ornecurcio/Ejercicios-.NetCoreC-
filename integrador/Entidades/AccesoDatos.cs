using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Entidades
{
    public class AccesoDatos
    {
        #region Atributos

        private static string cadena_conexion;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadena_conexion = @"Server=localhost\SQLEXPRESS;Database=Astros;Trusted_Connection=True;";
        }

        public AccesoDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            this.conexion = new SqlConnection(AccesoDatos.cadena_conexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                this.conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select

        public List<Planeta> ObtenerListaPlaneta()
        {
            List<Planeta> lista = new List<Planeta>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.planetas";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Planeta item = new Planeta();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.id = (int)lector["id"];
                    item.nombre = lector[1].ToString();
                    item.satelites = lector.GetInt32(2);
                    item.gravedad = double.Parse(lector[3].ToString());

                    lista.Add(item);
                }

                lector.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return lista;
        }

        #endregion

        #region Insert

        public bool AgregarPlaneta(Planeta param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.planetas (nombre, satelites, gravedad) VALUES(";
                sql = sql + "'" + param.nombre + "'," + param.satelites.ToString() + "," + param.gravedad.ToString() + ")";

                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Update

        public bool ModificarPlaneta(Planeta param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.id);
                this.comando.Parameters.AddWithValue("@nombre", param.nombre);
                this.comando.Parameters.AddWithValue("@satelites", param.satelites);
                this.comando.Parameters.AddWithValue("@gravedad", param.gravedad);

                string sql = "UPDATE dbo.planetas ";
                sql += "SET nombre = @nombre, satelites = @satelites, gravedad = @gravedad ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (InvalidCastException)
            {
                rta = false;
            }
            catch (System.IO.IOException)
            {
                rta = false;
            }
            catch (ObjectDisposedException)
            {
                rta = false;
            }
            catch (InvalidOperationException)
            {
                rta = false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message); 
                rta = false;
            }
            catch (Exception e)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Delete

        public bool EliminarPlaneta(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.planetas ";
                sql += "WHERE id = @id";

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = sql;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                int filasAfectadas = this.comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #endregion
    }
}

