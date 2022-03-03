using Examen.Base.Modelo;
using Examen.Datos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Examen.Datos.AlumnoSeccion
{
    public class AlumnoSeccionDAL
    {
        #region ListarAlumnoSeccion

        public List<AlumnoSeccionModelo> ListarAlumnoSeccion()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ListarAlumnoSeccion";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<AlumnoSeccionModelo> lista = new List<AlumnoSeccionModelo>();

                    while (reader.Read())
                    {
                        AlumnoSeccionModelo obj = new AlumnoSeccionModelo()
                        {
                            IdAlumno = reader.GetInt32(0),
                            IdSeccion = reader.GetInt32(1),
                            Alumno = reader.GetString(2),

                        };

                        lista.Add(obj);
                    }

                    reader.Close();

                    return lista;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region ObtenerAlumnoSeccion

        public List<AlumnoSeccionModelo> ObtenerAlumnoSeccion(int idAlumnoSeccion)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ObtenerAlumnosSeccion";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdSeccion", idAlumnoSeccion);

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<AlumnoSeccionModelo> lista = new List<AlumnoSeccionModelo>();

                    while (reader.Read())
                    {
                        AlumnoSeccionModelo obj = new AlumnoSeccionModelo()
                        {
                            IdAlumno = reader.GetInt32(0),
                            IdSeccion = reader.GetInt32(1),
                            Alumno = reader.GetString(2),

                        };

                        lista.Add(obj);
                    }

                    reader.Close();

                    return lista;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GuardarAlumnoSeccion

        public ResultadoModelo GuardarAlumnoSeccion(AlumnoSeccionModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "GuardarAlumnoSeccion";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdAlumno", modelo.IdAlumno);
                    sqlCommand.Parameters.AddWithValue("@IdSeccion", modelo.IdSeccion);

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        resultado.IdResultado = reader.GetInt32(0);
                        resultado.NombreResultado = reader.GetString(1);
                    }

                    sqlConnection.Close();

                    return resultado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region EditarAlumnoSeccion

        public ResultadoModelo EditarAlumnoSeccion(AlumnoSeccionModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "EditarAlumnoSeccion";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdAlumnoSeccion", modelo.IdAlumnoSeccion);
                    sqlCommand.Parameters.AddWithValue("@IdAlumno", modelo.IdAlumno);
                    sqlCommand.Parameters.AddWithValue("@IdSeccion", modelo.IdSeccion);
                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        resultado.IdResultado = reader.GetInt32(0);
                        resultado.NombreResultado = reader.GetString(1);

                    }

                    sqlConnection.Close();

                    return resultado;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region EliminarAlumnoSeccion

        public ResultadoModelo EliminarAlumnoSeccion(int idAlumnoSeccion)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "EliminarAlumnoSeccion";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdAlumnoSeccion", idAlumnoSeccion);

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    var resultado = new ResultadoModelo();

                    while (reader.Read())
                    {
                        resultado.IdResultado = reader.GetInt32(0);
                        resultado.NombreResultado = reader.GetString(1);
                    }

                    return resultado;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
