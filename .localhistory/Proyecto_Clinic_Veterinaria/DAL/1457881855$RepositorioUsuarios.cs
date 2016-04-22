using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioUsuarios : RepositorioGenerico<Usuario>
    {
        public RepositorioUsuarios(ClinicaContext context) : base(context)
        {

        }
        public ICollection<Usuario> Buscar (string opcion, string busqueda)
        {
            switch (opcion)
            {
                case "Nombre":
                    return dbSet.Where(h => h.Nombre == busqueda).ToList();
                case "Apellidos":
                    return dbSet.Where(h => h.Apellidos == busqueda).ToList();
                case "Tipo de Usuario":
                    return dbSet.Where(h => h.TipoUsuario == busqueda).ToList();
            }
            return null;
        }
    }
}
