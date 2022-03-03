using Examen.Base.Modelo;
using Examen.Negocio;
using System.Collections.Generic;
using System.Web.Http;

namespace Examen.WebApi.Controllers
{
    public class AlumnoController : ApiController
    {
        #region ListarAlumnos

        [HttpGet]
        public IEnumerable<AlumnoModelo> ListarAlumnos()
        {
            var alumnos = new AlumnoBLL().ListarAlumnos();

            return alumnos;
        }

        #endregion

        #region ObtenerAlumno

        [HttpGet]
        public AlumnoModelo ObtenerAlumno(int idAlumno)
        {
            var alumno = new AlumnoBLL().ObtenerAlumno(idAlumno);

            return alumno;
        }

        #endregion

        #region GuardarAlumno

        [HttpPost]
        public ResultadoModelo GuardarAlumno(AlumnoModelo alumno)
        {
            var resultado = new AlumnoBLL().GuardarAlumno(alumno);

            return resultado;
        }
        #endregion

        #region EditarAlumno

        [HttpPost]
        public ResultadoModelo EditarAlumno(AlumnoModelo alumno)
        {
            var resultado = new AlumnoBLL().EditarAlumno(alumno);

            return resultado;
        }
        #endregion

        #region EliminarAlumno

        [HttpDelete]
        public ResultadoModelo EliminarAlumno(int idAlumno)
        {
            var resultado = new AlumnoBLL().EliminarAlumno(idAlumno);

            return resultado;
        }

        #endregion

    }
}
