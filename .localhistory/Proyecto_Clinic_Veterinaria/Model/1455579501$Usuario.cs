using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.Model
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreCompleto
        { get
            {
                return Nombre + " " + Apellidos;
            }
        }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string TipoUsuario { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
    }
}
