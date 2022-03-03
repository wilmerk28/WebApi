using Examen.Base.Modelo;
using Examen.Negocio.Profesor;
using System.Collections.Generic;
using System.Web.Http;

namespace Examen.WebApi.Controllers
{
    public class ProfesorController : ApiController
    {
        #region ListarProfesores

        [HttpGet]
        public IEnumerable<ProfesorModelo> ListarProfesores()
        {
            var profesores = new ProfesorBLL().ListarProfesores();

            return profesores;
        }

        #endregion

        #region ObtenerProfesor

        [HttpGet]
        public ProfesorModelo ObtenerProfesor(int idProfesor)
        {
            var profesor = new ProfesorBLL().ObtenerProfesor(idProfesor);

            return profesor;
        }

        #endregion

        #region GuardarProfesor

        [HttpPost]
        public ResultadoModelo GuardarProfesor(ProfesorModelo profesor)
        {
            var resultado = new ProfesorBLL().GuardarProfesor(profesor);

            return resultado;
        }
        #endregion

        #region EditarProfesor

        [HttpPost]
        public ResultadoModelo EditarProfesor(ProfesorModelo profesor)
        {
            var resultado = new ProfesorBLL().EditarProfesor(profesor);

            return resultado;
        }
        #endregion

        #region EliminarProfesor

        [HttpDelete]
        public ResultadoModelo EliminarProfesor(int idProfesor)
        {
            var resultado = new ProfesorBLL().EliminarProfesor(idProfesor);

            return resultado;
        }

        #endregion
    }
}
