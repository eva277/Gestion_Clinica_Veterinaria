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
    public class Cliente : PropertyValidateModel
    {
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Debe ingresarar un nombre")]
        [MaxLength(15)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar los apellidos")]
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
        [Display(Name ="Codigo Postal")]
        public string CodigoPostal { get; set; }
        [StringLength(12, MinimumLength = 9, ErrorMessage = "Longitud entre 9 y 12")]
        [Phone]
        [Display(Name = "Móbil")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Telefono incorrecto")]
        public string Telefono { get; set; }
        [EmailAddress(ErrorMessage = "E-mail no valido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail no valido")]
        public string Email { get; set; }
        public virtual ICollection<Mascota> ListaMascota { get; set; }

        public Cliente()
        {
             ListaMascota = new Collection<Mascota>();
        }

    }
}
