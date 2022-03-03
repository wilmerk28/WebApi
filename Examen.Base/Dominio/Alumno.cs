using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Base.Dominio
{
    public class Alumno
    {
        public int IdAlumno { get; set; }
        public int IdPersona { get; set; }
        public string Ciclo { get; set; }
        public int CreditosAprobados { get; set; }
        public int CreditosDesaprobados { get; set; }
        public string Situacion { get; set; }
        public string Especialidad { get; set; }

    }
}
