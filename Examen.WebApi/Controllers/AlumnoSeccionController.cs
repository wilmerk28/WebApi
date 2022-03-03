using Examen.Base.Modelo;
using Examen.Negocio.AlumnoSeccion;
using System.Collections.Generic;
using System.Web.Http;

namespace Examen.WebApi.Controllers
{
    public class AlumnoSeccionController : ApiController
    {
        #region ListarAlumnoSeccion

        [HttpGet]
        public IEnumerable<AlumnoSeccionModelo> Listar()
        {
            var lista = new AlumnoSeccionBLL().ListarAlumnoSeccion();

            return lista;
        }

        #endregion

        #region ObtenerAlumnoSeccion

        [HttpGet]
        public List<AlumnoSeccionModelo> ObtenerAlumnoSeccion(int id)
        {
            var lista = new AlumnoSeccionBLL().ObtenerAlumnoSeccion(id);

            return lista;
        }

        #endregion

        #region GuardarAlumnoSeccion

        [HttpPost]
        public ResultadoModelo Guardar(AlumnoSeccionModelo alumnoSeccion)
        {
            var resultado = new AlumnoSeccionBLL().GuardarAlumnoSeccion(alumnoSeccion);

            return resultado;
        }
        #endregion

        #region EditarAlumnoSeccion

        [HttpPost]
        public ResultadoModelo Editar(AlumnoSeccionModelo alumnoSeccion)
        {
            var resultado = new AlumnoSeccionBLL().EditarAlumnoSeccion(alumnoSeccion);

            return resultado;
        }
        #endregion

        #region EliminarAlumnoSeccion

        [HttpDelete]
        public ResultadoModelo Eliminar(int id)
        {
            var resultado = new AlumnoSeccionBLL().EliminarAlumnoSeccion(id);

            return resultado;
        }

        #endregion
    }
}
