using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    [PropertyChanged.ImplementPropertyChanged]
    public class RegistroCita : PropertyValidateModel
    {
        public int RegistrosCitasId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Resumen { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual TipoCita TipoAtencion { get; set; }
        public virtual int TipoAtencionId { get; set; }

        public RegistroCita()
        {

        }
    }
}
