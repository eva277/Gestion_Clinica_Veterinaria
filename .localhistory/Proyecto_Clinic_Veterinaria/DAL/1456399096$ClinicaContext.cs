using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Proyecto_Clinic_Veterinaria.Model;

namespace Proyecto_Clinic_Veterinaria.DAL
{
    public class ClinicaContext:DbContext
    {
        public ClinicaContext() : base("ClinicaVeterinaria")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        //public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<AvisosCita> AvisosCitas { get; set; }
        //public DbSet<Jaula> Jaulas { get; set; }
        //public DbSet<Mascota> Mascotas { get; set; }
        //public DbSet<RegistroHotel_Hospital> RegistroHotel_Hospitales { get; set; }
       // public DbSet<RegistroCita> RegistrosCitas { get; set; }
        //public DbSet<TipoCita> TipoCitas { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
