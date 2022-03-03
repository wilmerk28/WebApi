using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Base.Dominio
{
    public class Profesor
    {
        public int IdProfesor { get; set; }
        public int IdPersona { get; set; }
        public string IdGrado { get; set; }
        public string IdTipoContrato { get; set; }
        public decimal Sueldo { get; set; }

    }
}
