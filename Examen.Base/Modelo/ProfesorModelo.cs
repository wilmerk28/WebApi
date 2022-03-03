using Examen.Base.Dominio;

namespace Examen.Base.Modelo
{
    public class ProfesorModelo : Persona
    {
        public int IdProfesor { get; set; }
        public string IdGrado { get; set; }
        public string IdTipoContrato { get; set; }
        public decimal Sueldo { get; set; }
        public string TipoDocumento { get; set; }
        public string TipoPersona { get; set; }
        public string TipoContrato { get; set; }
        public string Grado { get; set; }

    }
}
