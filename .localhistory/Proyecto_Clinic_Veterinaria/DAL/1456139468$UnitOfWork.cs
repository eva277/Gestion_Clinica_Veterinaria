using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class UnitOfWork:IDisposable
    {
        private ClinicaContext context = new ClinicaContext();
        private bool disposed = false;

        private RepositorioUsuarios repositorioUsuarios;
        private RepositorioAvisosCita repositorioAvisosCita;
        private RepositorioCliente repositorioCliente;
        private RepositorioJaula repositorioJaula;
        private RepositorioMascota repositorioMascota;
        private RepositorioRegistroHotel_Hospital repositorioRegistroHotel_Hospital;
        public RepositorioUsuarios RepositorioUsuarios
        {
            get
            {
                if (this.repositorioUsuarios == null)
                {
                    this.repositorioUsuarios =
                        new RepositorioUsuarios(context);
                }

                return repositorioUsuarios;
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
