using Examen.Base.Modelo;
using Examen.Datos.Profesor;
using System.Collections.Generic;

namespace Examen.Negocio.Profesor
{
    public class ProfesorBLL
    {
        public List<ProfesorModelo> ListarProfesores()
        {
            ProfesorDAL obj = new ProfesorDAL();
            return obj.ListarProfesores();

        }

        public ProfesorModelo ObtenerProfesor(int idProfesor)
        {
            ProfesorDAL obj = new ProfesorDAL();
            return obj.ObtenerProfesor(idProfesor);

        }

        public ResultadoModelo GuardarProfesor(ProfesorModelo profesor)
        {
            ProfesorDAL obj = new ProfesorDAL();
            return obj.GuardarProfesor(profesor);

        }

        public ResultadoModelo EditarProfesor(ProfesorModelo profesor)
        {
            ProfesorDAL obj = new ProfesorDAL();
            return obj.EditarProfesor(profesor);

        }

        public ResultadoModelo EliminarProfesor(int idProfesor)
        {
            ProfesorDAL obj = new ProfesorDAL();
            return obj.EliminarProfesor(idProfesor);

        }
    }
}
