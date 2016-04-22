using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(35)]
        public string Apellidos { get; set; }
        [Display(Name = "Nombre Completo")]
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
        [DataType(DataType.MultilineText)]
        [MaxLength(50)]
        public string Direccion { get; set; }
        [DataType(DataType.PostalCode)]
        public int CodigoPostal { get; set; }
        [StringLength(12, MinimumLength = 9)]
        [Phone]
        [Display(Name = "Móbil")]
        [DataType(DataType.PhoneNumber,
            ErrorMessage = "Telefono incorrecto")]
        public int Telefono { get; set; }
        [EmailAddress]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no es valido")]
        public string Email { get; set; }
        public ICollection<Mascota> ListaMascota { get; set; }

        public Cliente()
        {
            ListaMascota = new Collection<Mascota>();
        }

    }
}
