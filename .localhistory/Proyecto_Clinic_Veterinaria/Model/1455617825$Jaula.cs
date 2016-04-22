using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Jaula
    {
        public int JaulaId { get; set; }
        public int TipoJaula { get; set; }
        public bool Ocupada { get; set; }
        public float Alto { get; set; }
        public float Ancho { get; set; }
        public float Fondo { get; set; }
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
