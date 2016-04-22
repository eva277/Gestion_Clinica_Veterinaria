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
    }
}
