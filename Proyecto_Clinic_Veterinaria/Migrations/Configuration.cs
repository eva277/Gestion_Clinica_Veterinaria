namespace Proyecto_Clinic_Veterinaria.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Proyecto_Clinic_Veterinaria.Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Proyecto_Clinic_Veterinaria.DAL.ClinicaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Proyecto_Clinic_Veterinaria.DAL.ClinicaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Usuarios.Add(
              new Usuario { Nombre = "Admin" ,
                  Apellidos ="Administrador",
                  TipoUsuario="Administrador",
                  NickName="admin",
                  Password="admin"}
            );
        }
    }
}
