using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    class TipoAtencion
    {
        public int TipoAtencionId { get; set; }
        public string Nombre { get; set; }
        public string Motivo { get; set; }
        public int Importancia { get; set; }

    }
}
