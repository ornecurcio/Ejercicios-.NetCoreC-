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
            AccesoDatos.cadena_conexion = @"Server=localhost\SQLEXPRESS;Database=Test;Trusted_Connection=True;";
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

        public List<Usuario> ObtenerListaDato()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                this.comando = new SqlCommand();

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT * FROM dbo.usuario";
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                this.lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Usuario item = new Usuario();

                    // ACCEDO POR NOMBRE, POR INDICE O POR GETTER (SEGUN TIPO DE DATO)
                    item.id = (int)lector["id"];
                    item.nombre = lector[1].ToString();
                    item.edad = lector.GetInt32(2);

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

        public bool AgregarDato(Usuario param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.usuario (cadena, entero, flotante) VALUES(";
                sql = sql + "'" + param.nombre + "'," + param.edad.ToString() + "," + ")";

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

        public bool ModificarDato(Usuario param)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", param.id);
                this.comando.Parameters.AddWithValue("@nombre", param.nombre);
                this.comando.Parameters.AddWithValue("@edad", param.edad);

                string sql = "UPDATE tabla_uno ";
                sql += "SET nombre = @nombre, edad = @edad";
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

        #region Delete

        public bool EliminarDato(int id)
        {
            bool rta = true;

            try
            {
                this.comando = new SqlCommand();

                this.comando.Parameters.AddWithValue("@id", id);

                string sql = "DELETE FROM dbo.usuario ";
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
