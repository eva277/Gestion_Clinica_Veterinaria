using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioMascota:RepositorioGenerico<Mascota>
    {
        public RepositorioMascota(ClinicaContext context) : base(context)
        { }

        public ICollection<Mascota> Buscar(string opcion, string busqueda)
        {
            switch (opcion)
            {
                case "Nombre":
                    return dbSet.Where(h => h.Nombre == busqueda).ToList();
                case "Raza":
                    return dbSet.Where(h => h.Raza == busqueda).ToList();
                case "Sexo":
                    return dbSet.Where(h => h.Sexo == busqueda).ToList();
            }
            return null;
        }
    }
}
