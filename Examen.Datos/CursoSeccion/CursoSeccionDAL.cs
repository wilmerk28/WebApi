using Examen.Base.Modelo;
using Examen.Datos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Examen.Datos.CursoSeccion
{
    public class CursoSeccionDAL
    {
        #region ListarCursosSecciones

        public List<CursoSeccionModelo> ListarCursosSecciones()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ListarCursoSeccion";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<CursoSeccionModelo> listaCursoSeccion = new List<CursoSeccionModelo>();

                    while (reader.Read())
                    {
                        CursoSeccionModelo obj = new CursoSeccionModelo()
                        {
                            IdCursoSeccion = reader.GetInt32(0),
                            HoraFin = reader.GetString(1),
                            HoraInicio = reader.GetString(2),
                            NombreCurso= reader.GetString(3),
                            Profesor = reader.GetString(4),
                            NombreSeccion = reader.GetString(5)
                         };

                        listaCursoSeccion.Add(obj);
                    }

                    reader.Close();

                    return listaCursoSeccion;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region ObtenerCursoSeccion

        public CursoSeccionModelo ObtenerCursoSeccion(int idCursoSeccion)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ObtenerCursoSeccion";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdCursoSeccion", idCursoSeccion);

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    CursoSeccionModelo cursoSeccion = new CursoSeccionModelo();

                    while (reader.Read())
                    {
                        cursoSeccion.IdCursoSeccion = reader.GetInt32(0);
                        cursoSeccion.HoraFin = reader.GetString(1);
                        cursoSeccion.HoraInicio = reader.GetString(2);
                        cursoSeccion.NombreCurso = reader.GetString(3);
                        cursoSeccion.Profesor = reader.GetString(4);
                        cursoSeccion.NombreSeccion = reader.GetString(5);

                    }

                    reader.Close();

                    return cursoSeccion;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GuardarCursoSeccion

        public ResultadoModelo GuardarCursoSeccion(CursoSeccionModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "GuardarCursoSeccion";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdCurso", modelo.IdCurso);
                    sqlCommand.Parameters.AddWithValue("@IdSeccion", modelo.IdSeccion);
                    sqlCommand.Parameters.AddWithValue("@IdProfesor", modelo.IdProfesor);
                    sqlCommand.Parameters.AddWithValue("@HoraInicio", modelo.HoraInicio);
                    sqlCommand.Parameters.AddWithValue("@HoraFin", modelo.HoraFin);

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

        #region EditarCursoSeccion

        public ResultadoModelo EditarCursoSeccion(CursoSeccionModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "EditarCursoSeccion";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdCursoSeccion", modelo.IdCursoSeccion);
                    sqlCommand.Parameters.AddWithValue("@IdCurso", modelo.IdCurso);
                    sqlCommand.Parameters.AddWithValue("@IdSeccion", modelo.IdSeccion);
                    sqlCommand.Parameters.AddWithValue("@IdProfesor", modelo.IdProfesor);
                    sqlCommand.Parameters.AddWithValue("@HoraInicio", modelo.HoraInicio);
                    sqlCommand.Parameters.AddWithValue("@HoraFin", modelo.HoraFin);
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

        #region EliminarCursoSeccion

        public ResultadoModelo EliminarCursoSeccion(int idCursoSeccion)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "EliminarCursoSeccion";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdCursoSeccion", idCursoSeccion);

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
