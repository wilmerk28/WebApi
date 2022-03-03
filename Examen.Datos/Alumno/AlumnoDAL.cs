using Examen.Base.Dominio;
using Examen.Base.Enumeradores;
using Examen.Base.Modelo;
using Examen.Datos.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Examen.Datos
{
    public class AlumnoDAL
    {
        #region ListarAlumnos

        public List<AlumnoModelo> ListarAlumnos()
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ListarAlumnos";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    List<AlumnoModelo> listaAlumnos = new List<AlumnoModelo>();

                    while (reader.Read())
                    {
                        AlumnoModelo obj = new AlumnoModelo()
                        {
                            IdAlumno = reader.GetInt32(0),
                            IdPersona = reader.GetInt32(1),
                            ApellidoPaterno = reader.GetString(2),
                            ApellidoMaterno = reader.GetString(3),
                            Nombres = reader.GetString(4),
                            Documento = reader.GetString(5),
                            NumeroDocumento = reader.GetString(6),
                            Telefono = reader.GetString(7),
                            Correo = reader.GetString(8),
                            Direccion = reader.GetString(9),
                            TipoPersona = reader.GetString(10),
                            Ciclo = reader.GetString(11),
                            CreditosAprobados = reader.GetInt32(12),
                            CreditosDesaprobados = reader.GetInt32(13),
                            Situacion = reader.GetString(14),
                            Especialidad = reader.GetString(15)
                        };

                        listaAlumnos.Add(obj);
                    }

                    reader.Close();

                    return listaAlumnos;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region ObtenerAlumno

        public AlumnoModelo ObtenerAlumno(int idAlumno)
        {
            try
            {
                using(var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "ObtenerAlumno";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdAlumno", idAlumno);

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    AlumnoModelo alumno = new AlumnoModelo();

                    while (reader.Read())
                    {
                        alumno.IdAlumno = reader.GetInt32(0);
                        alumno.IdPersona = reader.GetInt32(1);
                        alumno.ApellidoPaterno = reader.GetString(2);
                        alumno.ApellidoMaterno = reader.GetString(3);
                        alumno.Nombres = reader.GetString(4);
                        alumno.Documento = reader.GetString(5);
                        alumno.NumeroDocumento = reader.GetString(6);
                        alumno.Telefono = reader.GetString(7);
                        alumno.Correo = reader.GetString(8);
                        alumno.Direccion = reader.GetString(9);
                        alumno.TipoPersona = reader.GetString(10);
                        alumno.Ciclo = reader.GetString(11);
                        alumno.CreditosAprobados = reader.GetInt32(12);
                        alumno.CreditosDesaprobados = reader.GetInt32(13);
                        alumno.Situacion = reader.GetString(14);
                        alumno.Especialidad = reader.GetString(15);

                    }

                    reader.Close();

                    return alumno;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region GuardarAlumno

        public ResultadoModelo GuardarAlumno(AlumnoModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "GuardarAlumno";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    
                    sqlCommand.Parameters.AddWithValue("@Ciclo", modelo.Ciclo);
                    sqlCommand.Parameters.AddWithValue("@CreditosAprobados", modelo.CreditosAprobados);
                    sqlCommand.Parameters.AddWithValue("@CreditosDesaprobados", modelo.CreditosDesaprobados);
                    sqlCommand.Parameters.AddWithValue("@Situacion", modelo.Situacion);
                    sqlCommand.Parameters.AddWithValue("@Especialidad", modelo.Especialidad);
                    sqlCommand.Parameters.AddWithValue("@ApellidoPaterno", modelo.ApellidoPaterno);
                    sqlCommand.Parameters.AddWithValue("@ApellidoMaterno", modelo.ApellidoMaterno);
                    sqlCommand.Parameters.AddWithValue("@Nombres", modelo.Nombres);
                    sqlCommand.Parameters.AddWithValue("@IdDocumento", modelo.IdDocumento);
                    sqlCommand.Parameters.AddWithValue("@NumeroDocumento", modelo.NumeroDocumento);
                    sqlCommand.Parameters.AddWithValue("@Telefono", modelo.Telefono);
                    sqlCommand.Parameters.AddWithValue("@Correo", modelo.Correo);
                    sqlCommand.Parameters.AddWithValue("@Direccion", modelo.Direccion);
                    sqlCommand.Parameters.AddWithValue("@IdTipoPersona", EnumTipoPersona.ALU.ToString());

                    sqlCommand.ExecuteNonQuery();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        resultado.IdResultado = reader.GetInt32(0);
                        resultado.NombreResultado = reader.GetString(1);
                        //resultado.Id = reader.GetInt32(2);
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

        #region EditarAlumno

        public ResultadoModelo EditarAlumno(AlumnoModelo modelo)
        {
            try
            {
                ResultadoModelo resultado = new ResultadoModelo();

                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    sqlConnection.Open();

                    string query = "EditarAlumno";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    sqlCommand.Parameters.AddWithValue("@IdAlumno", modelo.IdAlumno);
                    sqlCommand.Parameters.AddWithValue("@Ciclo", modelo.Ciclo);
                    sqlCommand.Parameters.AddWithValue("@CreditosAprobados", modelo.CreditosAprobados);
                    sqlCommand.Parameters.AddWithValue("@CreditosDesaprobados", modelo.CreditosDesaprobados);
                    sqlCommand.Parameters.AddWithValue("@Situacion", modelo.Situacion);
                    sqlCommand.Parameters.AddWithValue("@Especialidad", modelo.Especialidad);
                    sqlCommand.Parameters.AddWithValue("@ApellidoPaterno", modelo.ApellidoPaterno);
                    sqlCommand.Parameters.AddWithValue("@ApellidoMaterno", modelo.ApellidoMaterno);
                    sqlCommand.Parameters.AddWithValue("@Nombres", modelo.Nombres);
                    sqlCommand.Parameters.AddWithValue("@IdDocumento", modelo.IdDocumento);
                    sqlCommand.Parameters.AddWithValue("@NumeroDocumento", modelo.NumeroDocumento);
                    sqlCommand.Parameters.AddWithValue("@Telefono", modelo.Telefono);
                    sqlCommand.Parameters.AddWithValue("@Correo", modelo.Correo);
                    sqlCommand.Parameters.AddWithValue("@Direccion", modelo.Direccion);
                    sqlCommand.Parameters.AddWithValue("@IdTipoPersona", EnumTipoPersona.ALU.ToString());

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

        public ResultadoModelo EliminarAlumno(int idAlumno)
        {
            try
            {
                using (var sqlConnection = new SqlConnection(Contexto.ConnectionString))
                {
                    string query = "EliminarAlumno";
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@IdAlumno", idAlumno);

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
