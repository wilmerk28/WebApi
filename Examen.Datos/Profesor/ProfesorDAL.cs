using Examen.Base.Enumeradores;
using Examen.Base.Modelo;
using Examen.Datos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Examen.Datos.Profesor
{
    public class ProfesorDAL
    {
        #region ListarProfesores

        public List<ProfesorModelo> ListarProfesores()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ListarProfesores";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<ProfesorModelo> listaProfesores = new List<ProfesorModelo>();

                    while (reader.Read())
                    {
                        ProfesorModelo obj = new ProfesorModelo()
                        {
                            IdProfesor = reader.GetInt32(0),
                            IdPersona = reader.GetInt32(1),
                            ApellidoPaterno = reader.GetString(2),
                            ApellidoMaterno = reader.GetString(3),
                            Nombres = reader.GetString(4),
                            TipoDocumento = reader.GetString(5),
                            NumeroDocumento = reader.GetString(6),
                            Telefono = reader.GetString(7),
                            Correo = reader.GetString(8),
                            Direccion = reader.GetString(9),
                            Grado = reader.GetString(10),
                            TipoContrato = reader.GetString(11),
                            Sueldo = reader.GetDecimal(12),
                        };

                        listaProfesores.Add(obj);
                    }

                    reader.Close();

                    return listaProfesores;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region ObtenerProfesor

        public ProfesorModelo ObtenerProfesor(int idProfesor)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ObtenerProfesor";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdProfesor", idProfesor);

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    ProfesorModelo profesor = new ProfesorModelo();

                    while (reader.Read())
                    {
                        profesor.IdProfesor = reader.GetInt32(0);
                        profesor.IdPersona = reader.GetInt32(1);
                        profesor.ApellidoPaterno = reader.GetString(2);
                        profesor.ApellidoMaterno = reader.GetString(3);
                        profesor.Nombres = reader.GetString(4);
                        profesor.TipoDocumento = reader.GetString(5);
                        profesor.NumeroDocumento = reader.GetString(6);
                        profesor.Telefono = reader.GetString(7);
                        profesor.Correo = reader.GetString(8);
                        profesor.Direccion = reader.GetString(9);
                        profesor.Grado = reader.GetString(10);
                        profesor.TipoContrato = reader.GetString(11);
                        profesor.Sueldo = reader.GetDecimal(12);

                    }

                    reader.Close();

                    return profesor;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GuardarProfesor

        public ResultadoModelo GuardarProfesor(ProfesorModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "GuardarProfesor";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@ApellidoPaterno", modelo.ApellidoPaterno);
                    sqlCommand.Parameters.AddWithValue("@ApellidoMaterno", modelo.ApellidoMaterno);
                    sqlCommand.Parameters.AddWithValue("@Nombres", modelo.Nombres);
                    sqlCommand.Parameters.AddWithValue("@IdDocumento", modelo.IdDocumento);
                    sqlCommand.Parameters.AddWithValue("@NumeroDocumento", modelo.NumeroDocumento);
                    sqlCommand.Parameters.AddWithValue("@Telefono", modelo.Telefono);
                    sqlCommand.Parameters.AddWithValue("@Correo", modelo.Correo);
                    sqlCommand.Parameters.AddWithValue("@Direccion", modelo.Direccion);
                    sqlCommand.Parameters.AddWithValue("@IdTipoPersona", EnumTipoPersona.PRO.ToString());
                    sqlCommand.Parameters.AddWithValue("@IdGrado", modelo.IdGrado);
                    sqlCommand.Parameters.AddWithValue("@IdTipoContrato", modelo.IdTipoContrato);
                    sqlCommand.Parameters.AddWithValue("@Sueldo", modelo.Sueldo);

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

        #region EditarProfesor

        public ResultadoModelo EditarProfesor(ProfesorModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "EditarProfesor";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdProfesor", modelo.IdProfesor);
                    sqlCommand.Parameters.AddWithValue("@ApellidoPaterno", modelo.ApellidoPaterno);
                    sqlCommand.Parameters.AddWithValue("@ApellidoMaterno", modelo.ApellidoMaterno);
                    sqlCommand.Parameters.AddWithValue("@Nombres", modelo.Nombres);
                    sqlCommand.Parameters.AddWithValue("@IdDocumento", modelo.IdDocumento);
                    sqlCommand.Parameters.AddWithValue("@NumeroDocumento", modelo.NumeroDocumento);
                    sqlCommand.Parameters.AddWithValue("@Telefono", modelo.Telefono);
                    sqlCommand.Parameters.AddWithValue("@Correo", modelo.Correo);
                    sqlCommand.Parameters.AddWithValue("@Direccion", modelo.Direccion);
                    sqlCommand.Parameters.AddWithValue("@IdTipoPersona", EnumTipoPersona.PRO.ToString());
                    sqlCommand.Parameters.AddWithValue("@IdGrado", modelo.IdGrado);
                    sqlCommand.Parameters.AddWithValue("@IdTipoContrato", modelo.IdTipoContrato);
                    sqlCommand.Parameters.AddWithValue("@Sueldo", modelo.Sueldo);

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

        #region EliminarAlumno

        public ResultadoModelo EliminarProfesor(int idProfesor)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "EliminarProfesor";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdProfesor", idProfesor);

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
