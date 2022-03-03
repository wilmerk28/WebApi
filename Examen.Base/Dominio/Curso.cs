using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Base.Dominio
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string NombreCurso { get; set; }
        public byte NumeroCreditos { get; set; }
        public string Condicion { get; set; }

    }
}
