using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioRegistroCita:RepositorioGenerico<RegistroCita>
    {
        public RepositorioRegistroCita(ClinicaContext context) : base(context)
        {

        }
        public ICollection<RegistroCita> Buscar(string opcion, string busqueda)
        {
            switch (opcion)
            {
                case "Resumen":
                    return dbSet.Where(h => h.Resumen.Contains(busqueda)).ToList();
                case "Paciente":
                    return dbSet.Where(h => h.Paciente.Raza.Contains(busqueda)).ToList();
                case "Tipo de Cita":
                    return dbSet.Where(h => h.TipoAtencion.Motivo.Contains(busqueda)).ToList();
            }
            return null;
        }
    }
}
