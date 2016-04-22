namespace Proyecto_Clinic_Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RegistroCitas", "Dueño_ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.RegistroCitas", "Paciente_MascotaId", "dbo.Mascotas");
            DropIndex("dbo.RegistroCitas", new[] { "Dueño_ClienteId" });
            DropIndex("dbo.RegistroCitas", new[] { "Paciente_MascotaId" });
            RenameColumn(table: "dbo.RegistroCitas", name: "Dueño_ClienteId", newName: "ClienteId");
            RenameColumn(table: "dbo.RegistroCitas", name: "Paciente_MascotaId", newName: "MascotaId");
            AlterColumn("dbo.RegistroCitas", "ClienteId", c => c.Int(nullable: false));
            AlterColumn("dbo.RegistroCitas", "MascotaId", c => c.Int(nullable: false));
            CreateIndex("dbo.RegistroCitas", "MascotaId");
            CreateIndex("dbo.RegistroCitas", "ClienteId");
            AddForeignKey("dbo.RegistroCitas", "ClienteId", "dbo.Clientes", "ClienteId", cascadeDelete: true);
            AddForeignKey("dbo.RegistroCitas", "MascotaId", "dbo.Mascotas", "MascotaId", cascadeDelete: true);
            DropColumn("dbo.RegistroCitas", "PacienteId");
            DropColumn("dbo.RegistroCitas", "DueñoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RegistroCitas", "DueñoId", c => c.Int(nullable: false));
            AddColumn("dbo.RegistroCitas", "PacienteId", c => c.Int(nullable: false));
            DropForeignKey("dbo.RegistroCitas", "MascotaId", "dbo.Mascotas");
            DropForeignKey("dbo.RegistroCitas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.RegistroCitas", new[] { "ClienteId" });
            DropIndex("dbo.RegistroCitas", new[] { "MascotaId" });
            AlterColumn("dbo.RegistroCitas", "MascotaId", c => c.Int());
            AlterColumn("dbo.RegistroCitas", "ClienteId", c => c.Int());
            RenameColumn(table: "dbo.RegistroCitas", name: "MascotaId", newName: "Paciente_MascotaId");
            RenameColumn(table: "dbo.RegistroCitas", name: "ClienteId", newName: "Dueño_ClienteId");
            CreateIndex("dbo.RegistroCitas", "Paciente_MascotaId");
            CreateIndex("dbo.RegistroCitas", "Dueño_ClienteId");
            AddForeignKey("dbo.RegistroCitas", "Paciente_MascotaId", "dbo.Mascotas", "MascotaId");
            AddForeignKey("dbo.RegistroCitas", "Dueño_ClienteId", "dbo.Clientes", "ClienteId");
        }
    }
}
