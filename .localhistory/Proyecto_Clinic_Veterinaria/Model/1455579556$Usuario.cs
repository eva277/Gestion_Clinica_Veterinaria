using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto
        { get
            {
                return Nombre + " " + Apellidos;
            }
        }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string TipoUsuario { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
        public virtual ICollection<Cliente> ListaCliente { get; set; }
        public virtual ICollection<Mascota> ListaMascota { get; set; }
        public virtual ICollection<AvisosAtencion> ListaAvisosAtencion { get; set; }
        public virtual ICollection<TipoAtencion> ListaTipoAtencion { get; set; }
        public virtual ICollection<RegistrosAtencion> ListaRegistrosAtencion { get; set; }
        public virtual ICollection<Jaula> ListaJaula { get; set; }
        public virtual ICollection<RegistroHotel_Hospital> ListaRegistroHotel_Hospital { get; set; }

        public Usuario()
        {
            ListaCliente = new Collection<Mascota>();
            ListaMascota = new Collection<Mascota>();
            ListaAvisosAtencion = new Collection<AvisosAtencion>();
            ListaTipoAtencion = new Collection<Mascota>();
            ListaRegistrosAtencion = new Collection<RegistrosAtencion>();
            ListaJaula = new Collection<Mascota>();
            ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();
                    }
    }
}
