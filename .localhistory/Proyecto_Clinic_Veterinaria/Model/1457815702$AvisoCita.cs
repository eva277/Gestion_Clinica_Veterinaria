﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    [PropertyChanged.ImplementPropertyChanged]
    public class AvisoCita : PropertyValidateModel
    {
        public int AvisoCitaId { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaCita { get; set; }
        [Required]
        public virtual Mascota Mascota {get;set;}
        public virtual int MascotaId { get; set; }
        public virtual TipoCita TipoCita { get; set; }
        public virtual int TipoCitaID { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }

        public AvisoCita()
        {

        }

    }
}
