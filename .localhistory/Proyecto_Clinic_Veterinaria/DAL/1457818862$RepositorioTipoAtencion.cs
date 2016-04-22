using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioTipoCitas : RepositorioGenerico<TipoAtencion>
    {
        public RepositorioTipoCitas(ClinicaContext context) : base(context)
        {

        }
        public ICollection<TipoAtencion> Buscar(string opcion, string busqueda)
        {
            switch (opcion)
            {
                case "Motivo":
                    return dbSet.Where(h => h.Motivo.Contains(busqueda)).ToList();
                case "Importancia":
                    return dbSet.Where(h => h.Importancia==Convert.ToInt16(busqueda)).ToList();
            }
            return null;
        }
    }
}
