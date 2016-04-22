using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class AvisosAtencion
    {
        public int AvisosAtencionId { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime Regreso { get; set; }
        public string Motivo { get; set; }
        public bool Activo { get; set; }
        public virtual Cliente Mascota {get;set;}
        public virtual int MascotaId { get; set; }
        public virtual TipoAtencion TipoAtencion { get; set; }
        public virtual int TipoAtencionId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }

    }
}
