using Examen.Base.Modelo;
using Examen.Negocio.CursoSeccion;
using System.Collections.Generic;
using System.Web.Http;

namespace Examen.WebApi.Controllers
{
    public class CursoSeccionController : ApiController
    {
        #region ListarCursoSecciones

        [HttpGet]
        public IEnumerable<CursoSeccionModelo> Listar()
        {
            var cursoSeccion = new CursoSeccionBLL().ListarCursoSecciones();

            return cursoSeccion;
        }

        #endregion

        #region ObtenerCursoSeccion

        [HttpGet]
        public CursoSeccionModelo ObtenerCursoSeccion(int idCursoSeccion)
        {
            var cursoSeccion = new CursoSeccionBLL().ObtenerCursoSeccion(idCursoSeccion);

            return cursoSeccion;
        }

        #endregion

        #region GuardarCursoSeccion

        [HttpPost]
        public ResultadoModelo Guardar(CursoSeccionModelo cursoSeccion)
        {
            var resultado = new CursoSeccionBLL().GuardarCursoSeccion(cursoSeccion);

            return resultado;
        }
        #endregion

        #region EditarCursoSeccion

        [HttpPost]
        public ResultadoModelo Editar(CursoSeccionModelo cursoSeccion)
        {
            var resultado = new CursoSeccionBLL().EditarCursoSeccion(cursoSeccion);

            return resultado;
        }
        #endregion

        #region EliminarCursoSeccion

        [HttpDelete]
        public ResultadoModelo Eliminar(int id)
        {
            var resultado = new CursoSeccionBLL().EliminarCursoSeccion(id);

            return resultado;
        }

        #endregion
    }
}
