using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioTipoCitas : RepositorioGenerico<TipoCita>
    {
        public RepositorioTipoCitas(ClinicaContext context) : base(context)
        {

        }
    }
}
