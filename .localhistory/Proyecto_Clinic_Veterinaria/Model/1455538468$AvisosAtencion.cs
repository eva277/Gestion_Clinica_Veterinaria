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

    }
}
