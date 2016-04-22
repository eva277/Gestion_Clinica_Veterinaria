﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class TipoAtencion
    {
        public int TipoAtencionId { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string Motivo { get; set; }
        [Required]
        [Range(0,5)]
        public int Importancia { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual ICollection<AvisosAtencion> ListaAvisosAtencion { get; set; }
        public virtual ICollection<RegistrosAtencion> ListaRegistrosAtencion { get; set; }

        public TipoAtencion()
        {
            ListaAvisosAtencion = new Collection<AvisosAtencion>();
            ListaRegistrosAtencion = new Collection<RegistrosAtencion>();
        }
    }
}