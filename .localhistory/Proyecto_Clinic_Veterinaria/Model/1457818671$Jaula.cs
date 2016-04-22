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
    public class Jaula : PropertyValidateModel
    {
        public int JaulaId { get; set; }
        [Required(ErrorMessage ="Debe indicar el tipo de jaula")]
        public string TipoJaula { get; set; }
        [Required(ErrorMessage = "Debe indicar su disponibilidad")]
        public bool Ocupada { get; set; }
        [Required(ErrorMessage = "Debe indicar el alto de la jaula")]
        [Range(0,300,ErrorMessage = "Alto debe ser entre 0 y 300")]
        public int Alto { get; set; }
        [Required(ErrorMessage = "Debe indicar el ancho de la jaula")]
        [Range(0, 300, ErrorMessage = "Alto debe ser entre 0 y 300")]
        public int Ancho { get; set; }
        [Required(ErrorMessage = "Debe indicar el fondo de la jaula")]
        [Range(0, 300, ErrorMessage = "Alto debe ser entre 0 y 300")]
        public int Fondo { get; set; }
        [Display(Name = "Medidas")]
        public string Medida
        {
            get
            {
                return Alto + "x" + Ancho + "x" + Fondo;
            }
        }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual ICollection<RegistroHotel_Hospital> ListaRegistroHotel_Hospital { get; set; }

        public Jaula()
        {
            //ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();

        }

    }
}
