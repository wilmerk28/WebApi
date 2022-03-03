using Examen.Base.Modelo;
using Examen.Datos;
using System.Collections.Generic;

namespace Examen.Negocio
{
    public class AlumnoBLL
    {
        public List<AlumnoModelo> ListarAlumnos()
        {
            AlumnoDAL obj = new AlumnoDAL();
            return obj.ListarAlumnos();

        }

        public AlumnoModelo ObtenerAlumno(int idAlumno)
        {
            AlumnoDAL obj = new AlumnoDAL();
            return obj.ObtenerAlumno(idAlumno);

        }

        public ResultadoModelo GuardarAlumno(AlumnoModelo alumno)
        {
            AlumnoDAL obj = new AlumnoDAL();
            return obj.GuardarAlumno(alumno);

        }

        public ResultadoModelo EditarAlumno(AlumnoModelo alumno)
        {
            AlumnoDAL obj = new AlumnoDAL();
            return obj.EditarAlumno(alumno);

        }

        public ResultadoModelo EliminarAlumno(int idAlumno)
        {
            AlumnoDAL obj = new AlumnoDAL();
            return obj.EliminarAlumno(idAlumno);

        }
    }
}
