using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Base.Dominio
{
    public class CursoSeccion
    {
        public int IdCursoSeccion { get; set; }
        public int IdCurso { get; set; }
        public int IdSeccion { get; set; }
        public int IdProfesor { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }

    }
}
