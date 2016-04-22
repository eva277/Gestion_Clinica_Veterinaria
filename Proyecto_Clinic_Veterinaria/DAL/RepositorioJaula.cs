using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioJaula:RepositorioGenerico<Jaula>
    {
        public RepositorioJaula(ClinicaContext context) : base(context)
        {

        }
        public ICollection<Jaula> Buscar(string opcion, string busqueda)
        {
            switch (opcion)
            {
                case "Tipo":
                    return dbSet.Where(h => h.TipoJaula.Contains(busqueda)).ToList();
                case "Disponibilidad":
                    if (busqueda.ToLower().Equals("libre"))
                    {
                        return dbSet.Where(h => h.Ocupada == false).ToList();
                    }
                    else if (busqueda.ToLower().Equals("ocupada"))
                    {
                        return dbSet.Where(h => h.Ocupada == true).ToList();
                    }
                    else
                    {
                        return null;
                    }
            }
            return null;
        }
    }
}
