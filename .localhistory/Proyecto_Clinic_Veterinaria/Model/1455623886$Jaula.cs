﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Jaula
    {
        public int JaulaId { get; set; }
        [Required]
        public string TipoJaula { get; set; }
        [Required]
        public bool Ocupada { get; set; }
        [Required]
        [Range(0,150,ErrorMessage = "Alto debe ser entre 0 y 150")]
        public int Alto { get; set; }
        [Required]
        [Range(0, 200, ErrorMessage = "Alto debe ser entre 0 y 300")]
        public int Ancho { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Alto debe ser entre 0 y 100")]
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
            ListaRegistroHotel_Hospital = new Collection<RegistroHotel_Hospital>();

        }

    }
}