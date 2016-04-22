using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    class Mascota
    {
        public int MascotaId { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }
        public string TamañoRaza { get; set; }
        public string Pelaje { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte[] Foto { get; set; }

    }
}
