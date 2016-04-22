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


    }
}
