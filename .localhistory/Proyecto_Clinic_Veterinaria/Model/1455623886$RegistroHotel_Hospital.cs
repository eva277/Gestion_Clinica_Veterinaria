using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class RegistroHotel_Hospital
    {
        public int RegistroHotel_HospitalId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Ingreso { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Regreso { get; set; }
        [Required]
        public bool Disponible { get; set; }
        public virtual Mascota Mascota { get; set; }
        public virtual int MascotaId { get; set; }
        public virtual Jaula Jaula { get; set; }
        public virtual int JaulaId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }

        public RegistroHotel_Hospital()
        {

        }
    }
}
