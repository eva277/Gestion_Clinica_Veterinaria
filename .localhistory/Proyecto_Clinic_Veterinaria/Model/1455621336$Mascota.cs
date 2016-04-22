using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Mascota
    {
        public int MascotaId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(10)]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(30)]
        public string Especie { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(40)]
        public string Raza { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Sexo { get; set; }
        public string Pelaje { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public byte[] Foto { get; set; }
        [Required]
        public bool Activo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual ICollection<AvisosCita> ListaAvisosAtencion { get; set; }
        public virtual ICollection<RegistroHotel_Hospital> ListaRegistroHotel_Hospital { get; set; }

        public Mascota()
        {
            ListaAvisosAtencion = new Collection<AvisosCita>();
            ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();
        }

    }
}
