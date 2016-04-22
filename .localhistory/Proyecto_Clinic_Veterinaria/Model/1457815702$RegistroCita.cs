﻿using System;
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
        public int RegistroCitaId { get; set; }
        [Required(ErrorMessage = "Debe ingresarar el resumen de la cita")]
        public string Resumen { get; set; }
        [Required(ErrorMessage = "Debe ingresarar la fecha de la cita")]
        [DataType(DataType.DateTime)]
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual TipoCita TipoAtencion { get; set; }
        public virtual int TipoAtencionId { get; set; }
        public virtual Mascota Paciente { get; set; }
        public virtual int PacienteId { get; set; }
        public virtual Cliente Dueño { get; set; }
        public virtual int DueñoId { get; set; }

        public RegistroCita()
        {

        }
    }
}