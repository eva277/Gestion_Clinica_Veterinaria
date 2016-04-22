using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    [PropertyChanged.ImplementPropertyChanged]
    public class Usuario : PropertyValidateModel
    {
        public int UsuarioId { get; set; }
        [Required(ErrorMessage ="Debe ingresar el nombre")]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar los apellidos")]
        [MaxLength(35)]
        public string Apellidos { get; set; }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto
        { get
            {
                return Nombre + " " + Apellidos;
            }
        }
        [DataType(DataType.MultilineText)]
        [MaxLength(50)]
        public string Direccion { get; set; }
        [DataType(DataType.PostalCode)]
        [Display(Name ="Codigo Postal")]
        public int CodigoPostal { get; set; }
        [StringLength(12, MinimumLength = 9, ErrorMessage ="Longitud entre 9 y 12")]
        [Phone]
        [Display(Name = "Móbil")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefono incorrecto")]
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "E-mail no valido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no valido")]
        public string Email { get; set; }
        [Required]
        public string TipoUsuario { get; set; }
        [Required]
        [MaxLength(15)]
        public string NickName { get; set; }
        [Required]
        [DataType(DataType.Password, ErrorMessage ="Longitud Maxima 11")]
        public string Password { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
        public virtual ICollection<Cliente> ListaCliente { get; set; }
        public virtual ICollection<Mascota> ListaMascota { get; set; }
        public virtual ICollection<AvisoCita> ListaAvisosCita { get; set; }
        public virtual ICollection<TipoCita> ListaTipoCita { get; set; }
        public virtual ICollection<RegistroCita> ListaRegistrosCitas { get; set; }
        public virtual ICollection<Jaula> ListaJaula { get; set; }
        public virtual ICollection<RegistroHotel_Hospital> ListaRegistroHotel_Hospital { get; set; }

        public Usuario()
        {
            ListaCliente = new Collection<Cliente>();
            ListaMascota = new Collection<Mascota>();
            ListaAvisosCita = new Collection<AvisoCita>();
            ListaTipoCita = new Collection<TipoCita>();
            ListaRegistrosCitas = new Collection<RegistroCita>();
            ListaJaula = new Collection<Jaula>();
            ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();
       }
    }
}
