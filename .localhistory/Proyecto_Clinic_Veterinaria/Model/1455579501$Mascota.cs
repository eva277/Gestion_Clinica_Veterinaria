using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Mascota
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
        public bool Activo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual ICollection<AvisosAtencion> ListaAvisosAtencion { get; set; }
        public virtual ICollection<RegistroHotel_Hospital> ListaRegistroHotel_Hospital { get; set; }

        public Mascota()
        {
            ListaAvisosAtencion = new Collection<AvisosAtencion>();
            ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();
        }

    }
}
