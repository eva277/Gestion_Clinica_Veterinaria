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
        private RepositorioTipoCitas repositorioTipoCitas;
        private RepositorioCliente repositorioCliente;
        private RepositorioJaula repositorioJaula;
        private RepositorioMascota repositorioMascota;
        private RepositorioRegistroHotel_Hospital repositorioRegistroHotel_Hospital;
        private RepositorioRegistroCita repositorioRegistroCitas;

        public RepositorioRegistroCita RepositorioRegistroCita
        {
            get
            {
                if (this.repositorioRegistroCitas == null)
                {
                    this.repositorioRegistroCitas =
                        new RepositorioRegistroCita(context);
                }

                return repositorioRegistroCitas;
            }
        }
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

        public RepositorioTipoCitas RepositorioTipoCitas
        {
            get
            {
                if (this.repositorioTipoCitas == null)
                {
                    this.repositorioTipoCitas =
                        new RepositorioTipoCitas(context);
                }

                return repositorioTipoCitas;
            }
        }
        public RepositorioCliente RepositorioCliente
        {
            get
            {
                if (this.repositorioCliente == null)
                {
                    this.repositorioCliente =
                        new RepositorioCliente(context);
                }

                return repositorioCliente;
            }
        }
        public RepositorioJaula RepositorioJaula
        {
            get
            {
                if (this.repositorioJaula == null)
                {
                    this.repositorioJaula =
                        new RepositorioJaula(context);
                }

                return repositorioJaula;
            }
        }
        public RepositorioMascota RepositorioMascota
        {
            get
            {
                if (this.repositorioMascota == null)
                {
                    this.repositorioMascota =
                        new RepositorioMascota(context);
                }

                return repositorioMascota;
            }
        }
        public RepositorioRegistroHotel_Hospital RepositorioRegistroHotel_Hospital
        {
            get
            {
                if (this.repositorioRegistroHotel_Hospital == null)
                {
                    this.repositorioRegistroHotel_Hospital =
                        new RepositorioRegistroHotel_Hospital(context);
                }

                return repositorioRegistroHotel_Hospital;
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
