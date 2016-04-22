using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto
        {
            get
            {
                return Nombre + " " + Apellidos;
            }
        }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public ICollection<Mascota> ListaMascotas { get; set; }

        public Cliente()
        {
            ListaMascotas = new Collection<Mascota>();
        }

    }
}
