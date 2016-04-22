using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class RegistrosAtencion
    {
        public int RegistrosAtencionId { get; set; }
        public string Resumen { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual TipoAtencion TipoAtencion { get; set; }
        public virtual int TipoAtencionId { get; set; }

        public RegistrosAtencion()
        {

        }
    }
}
