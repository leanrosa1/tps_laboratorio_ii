using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Unidades 16 y 17 – Bases de Datos 
    /// Unidades 18, 19 y 17 – Delegados, hilos y eventos 
    /// </summary>
    public class ReclamoDAO
    {
        static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;

        public delegate void FinalizoLeerHander();
        public event FinalizoLeerHander OnFinalizoLeer;

        static ReclamoDAO()
        {
            connectionString = @"Server=.\SQLEXPRESS;Database=Leandro_Rosa_TP4;Trusted_Connection=True;";
        }

        public ReclamoDAO()
        {
            this.connection = new SqlConnection(connectionString);
            this.command = new SqlCommand();
            this.command.CommandType = System.Data.CommandType.Text;
            this.command.Connection = this.connection;
        }

        /// <summary>
        /// Guarda una entidad Reclamo en base de datos
        /// </summary>
        /// <param name="reclamo"></param>
        public void Guardar(Reclamo reclamo)
        {
            try
            {
                connection.Open();
                string query = 
                    "INSERT INTO Reclamos (fecha, empleadoNombre, empleadoDni, identificador, tipo, observacion) " +
                    "VALUES (@fecha, @empleadoNombre, @empleadoDni, @identificador, @tipo, @observacion)";
                this.command.CommandText = query;
                this.command.Parameters.Clear();
                this.command.Parameters.AddWithValue("@fecha", reclamo.Fecha);
                this.command.Parameters.AddWithValue("@empleadoNombre", reclamo.EmpleadoNombre);
                this.command.Parameters.AddWithValue("@empleadoDni", reclamo.EmpleadoDni);
                this.command.Parameters.AddWithValue("@identificador", reclamo.Identificador);
                this.command.Parameters.AddWithValue("@tipo", (int)reclamo.Tipo);
                this.command.Parameters.AddWithValue("@observacion", reclamo.Observacion);
                this.command.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// Devuelve todos los Reclamos guardado en base de datos
        /// Unidades 18, 19 y 17 – Delegados, hilos y eventos 
        /// </summary>
        /// <returns></returns>
        public List<Reclamo> Leer()
        {
            List<Reclamo> lista = new List<Reclamo>();
            try
            {
                string query = "SELECT * FROM reclamos";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    DateTime fecha = dataReader.GetDateTime(1);
                    string empleadoNombre = dataReader.GetString(2);
                    int empleadoDni = dataReader.GetInt32(3);
                    Guid identificador = dataReader.GetGuid(4);
                    string observacion = dataReader.GetString(5);
                    TipoDeReclamo tipo = (TipoDeReclamo)dataReader.GetInt32(6);

                    Reclamo reclamo = new Reclamo(fecha, empleadoNombre, empleadoDni, tipo, observacion, identificador, id);

                    lista.Add(reclamo);
                }

                if (OnFinalizoLeer != null)
                {
                    OnFinalizoLeer.Invoke();
                }
                return lista;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
