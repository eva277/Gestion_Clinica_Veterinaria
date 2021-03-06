﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    [PropertyChanged.ImplementPropertyChanged]
    public class TipoAtencion : PropertyValidateModel
    {
        public int TipoAtencionId { get; set; }
        [Required(ErrorMessage = "Debe ingresarar un nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresarar un motivo")]
        public string Motivo { get; set; }
        [Required(ErrorMessage = "Debe ingresarar la importancia")]
        [Range(0, 5, ErrorMessage = "Rango entre 0 y 5")]
        public int Importancia { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual ICollection<RegistroCita> ListaRegistrosCitas { get; set; }

        public TipoAtencion()
        {
            ListaRegistrosCitas = new Collection<RegistroCita>();
        }
    }
}
