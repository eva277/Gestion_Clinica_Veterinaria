using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class RepositorioGenerico<TEntity> where TEntity : class
    {
        internal ClinicaContext context;
        internal DbSet<TEntity> dbSet;

        public RepositorioGenerico(ClinicaContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }
        
    }
}
