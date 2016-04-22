using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class AvisosAtencion
    {
        public int AvisosAtencionId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaCita { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Motivo { get; set; }
        [Required]
        public bool Activo { get; set; }
        public virtual Mascota Mascota {get;set;}
        public virtual int MascotaId { get; set; }
        public virtual TipoAtencion TipoAtencion { get; set; }
        public virtual int TipoAtencionId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }

    }
}
