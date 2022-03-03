using Examen.Base.Modelo;
using Examen.Datos.CursoSeccion;
using System.Collections.Generic;

namespace Examen.Negocio.CursoSeccion
{
    public class CursoSeccionBLL
    {
        public List<CursoSeccionModelo> ListarCursoSecciones()
        {
            CursoSeccionDAL obj = new CursoSeccionDAL();
            return obj.ListarCursosSecciones();

        }

        public CursoSeccionModelo ObtenerCursoSeccion(int idCursoSeccion)
        {
            CursoSeccionDAL obj = new CursoSeccionDAL();
            return obj.ObtenerCursoSeccion(idCursoSeccion);

        }

        public ResultadoModelo GuardarCursoSeccion(CursoSeccionModelo cursoSeccion)
        {
            CursoSeccionDAL obj = new CursoSeccionDAL();
            return obj.GuardarCursoSeccion(cursoSeccion);

        }

        public ResultadoModelo EditarCursoSeccion(CursoSeccionModelo cursoSeccion)
        {
            CursoSeccionDAL obj = new CursoSeccionDAL();
            return obj.EditarCursoSeccion(cursoSeccion);

        }

        public ResultadoModelo EliminarCursoSeccion(int idCursoSeccion)
        {
            CursoSeccionDAL obj = new CursoSeccionDAL();
            return obj.EliminarCursoSeccion(idCursoSeccion);

        }
    }
}
