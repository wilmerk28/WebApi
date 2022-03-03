using Examen.Base.Modelo;
using Examen.Datos.AlumnoSeccion;
using System.Collections.Generic;

namespace Examen.Negocio.AlumnoSeccion
{
    public class AlumnoSeccionBLL
    {
        public List<AlumnoSeccionModelo> ListarAlumnoSeccion()
        {
            AlumnoSeccionDAL obj = new AlumnoSeccionDAL();
            return obj.ListarAlumnoSeccion();

        }

        public List<AlumnoSeccionModelo> ObtenerAlumnoSeccion(int idSeccion)
        {
            AlumnoSeccionDAL obj = new AlumnoSeccionDAL();
            return obj.ObtenerAlumnoSeccion(idSeccion);

        }

        public ResultadoModelo GuardarAlumnoSeccion(AlumnoSeccionModelo alumnoSeccion)
        {
            AlumnoSeccionDAL obj = new AlumnoSeccionDAL();
            return obj.GuardarAlumnoSeccion(alumnoSeccion);

        }

        public ResultadoModelo EditarAlumnoSeccion(AlumnoSeccionModelo alumnoSeccion)
        {
            AlumnoSeccionDAL obj = new AlumnoSeccionDAL();
            return obj.EditarAlumnoSeccion(alumnoSeccion);

        }

        public ResultadoModelo EliminarAlumnoSeccion(int alumnoSeccion)
        {
            AlumnoSeccionDAL obj = new AlumnoSeccionDAL();
            return obj.EliminarAlumnoSeccion(alumnoSeccion);

        }
    }
}
