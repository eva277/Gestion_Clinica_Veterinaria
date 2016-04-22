using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioCliente:RepositorioGenerico<Cliente>
    {
        public RepositorioCliente(ClinicaContext context) : base(context)
        {

        }
        public ICollection<Cliente> BuscarCliente(string opcion, string busqueda)
        {
            switch (opcion)
            {
                case "Nombre":
                    return dbSet.Where(h => h.Nombre == busqueda).ToList();
                case "Apellidos":
                    return dbSet.Where(h => h.Apellidos == busqueda).ToList();
            }
            return null;
        }
        public ICollection<Mascota> getPets(int id)
        {
             return context.Mascotas.Where(h => h.ClienteId == id).ToList();
        }
    }
}
