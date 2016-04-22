namespace Proyecto_Clinic_Veterinaria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvisoCitas",
                c => new
                    {
                        AvisoCitaId = c.Int(nullable: false, identity: true),
                        FechaCita = c.DateTime(nullable: false),
                        Motivo = c.String(nullable: false),
                        Activo = c.Boolean(nullable: false),
                        MascotaId = c.Int(nullable: false),
                        TipoCitaID = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AvisoCitaId)
                .ForeignKey("dbo.Mascotas", t => t.MascotaId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.TipoCitas", t => t.TipoCitaID, cascadeDelete: true)
                .Index(t => t.MascotaId)
                .Index(t => t.TipoCitaID)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Mascotas",
                c => new
                    {
                        MascotaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 10),
                        Especie = c.String(nullable: false, maxLength: 30),
                        Raza = c.String(nullable: false, maxLength: 40),
                        Sexo = c.String(nullable: false),
                        Pelaje = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Foto = c.Binary(),
                        Activo = c.Boolean(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MascotaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: false)
                .Index(t => t.ClienteId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 15),
                        Apellidos = c.String(nullable: false, maxLength: 35),
                        Direccion = c.String(maxLength: 50),
                        CodigoPostal = c.String(),
                        Telefono = c.String(maxLength: 12),
                        Email = c.String(),
                        Usuario_UsuarioId = c.Int(),
                    })
                .PrimaryKey(t => t.ClienteId)
                .ForeignKey("dbo.Usuarios", t => t.Usuario_UsuarioId)
                .Index(t => t.Usuario_UsuarioId);
            
            CreateTable(
                "dbo.RegistroHotel_Hospital",
                c => new
                    {
                        RegistroHotel_HospitalId = c.Int(nullable: false, identity: true),
                        Ingreso = c.DateTime(nullable: false),
                        Regreso = c.DateTime(nullable: false),
                        Disponible = c.Boolean(nullable: false),
                        MascotaId = c.Int(nullable: false),
                        JaulaId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegistroHotel_HospitalId)
                .ForeignKey("dbo.Jaulas", t => t.JaulaId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .ForeignKey("dbo.Mascotas", t => t.MascotaId, cascadeDelete: true)
                .Index(t => t.MascotaId)
                .Index(t => t.JaulaId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Jaulas",
                c => new
                    {
                        JaulaId = c.Int(nullable: false, identity: true),
                        TipoJaula = c.String(nullable: false),
                        Ocupada = c.Boolean(nullable: false),
                        Alto = c.Int(nullable: false),
                        Ancho = c.Int(nullable: false),
                        Fondo = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JaulaId)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuarioId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 15),
                        Apellidos = c.String(nullable: false, maxLength: 35),
                        Direccion = c.String(maxLength: 50),
                        CodigoPostal = c.Int(nullable: false),
                        Telefono = c.String(maxLength: 12),
                        Email = c.String(),
                        TipoUsuario = c.String(nullable: false),
                        NickName = c.String(nullable: false, maxLength: 15),
                        Password = c.String(nullable: false),
                        PreguntaSecreta = c.String(),
                        RespuestaSecreta = c.String(),
                    })
                .PrimaryKey(t => t.UsuarioId);
            
            CreateTable(
                "dbo.RegistroCitas",
                c => new
                    {
                        RegistroCitaId = c.Int(nullable: false, identity: true),
                        Resumen = c.String(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Observaciones = c.String(),
                        UsuarioId = c.Int(nullable: false),
                        TipoAtencionId = c.Int(nullable: false),
                        TipoAtencion_TipoCitaID = c.Int(),
                    })
                .PrimaryKey(t => t.RegistroCitaId)
                .ForeignKey("dbo.TipoCitas", t => t.TipoAtencion_TipoCitaID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId)
                .Index(t => t.TipoAtencion_TipoCitaID);
            
            CreateTable(
                "dbo.TipoCitas",
                c => new
                    {
                        TipoCitaID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Motivo = c.String(nullable: false),
                        Importancia = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TipoCitaID)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegistroHotel_Hospital", "MascotaId", "dbo.Mascotas");
            DropForeignKey("dbo.RegistroCitas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.TipoCitas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.RegistroCitas", "TipoAtencion_TipoCitaID", "dbo.TipoCitas");
            DropForeignKey("dbo.AvisoCitas", "TipoCitaID", "dbo.TipoCitas");
            DropForeignKey("dbo.RegistroHotel_Hospital", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Mascotas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Jaulas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Clientes", "Usuario_UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.AvisoCitas", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.RegistroHotel_Hospital", "JaulaId", "dbo.Jaulas");
            DropForeignKey("dbo.AvisoCitas", "MascotaId", "dbo.Mascotas");
            DropForeignKey("dbo.Mascotas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.TipoCitas", new[] { "UsuarioId" });
            DropIndex("dbo.RegistroCitas", new[] { "TipoAtencion_TipoCitaID" });
            DropIndex("dbo.RegistroCitas", new[] { "UsuarioId" });
            DropIndex("dbo.Jaulas", new[] { "UsuarioId" });
            DropIndex("dbo.RegistroHotel_Hospital", new[] { "UsuarioId" });
            DropIndex("dbo.RegistroHotel_Hospital", new[] { "JaulaId" });
            DropIndex("dbo.RegistroHotel_Hospital", new[] { "MascotaId" });
            DropIndex("dbo.Clientes", new[] { "Usuario_UsuarioId" });
            DropIndex("dbo.Mascotas", new[] { "UsuarioId" });
            DropIndex("dbo.Mascotas", new[] { "ClienteId" });
            DropIndex("dbo.AvisoCitas", new[] { "UsuarioId" });
            DropIndex("dbo.AvisoCitas", new[] { "TipoCitaID" });
            DropIndex("dbo.AvisoCitas", new[] { "MascotaId" });
            DropTable("dbo.TipoCitas");
            DropTable("dbo.RegistroCitas");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Jaulas");
            DropTable("dbo.RegistroHotel_Hospital");
            DropTable("dbo.Clientes");
            DropTable("dbo.Mascotas");
            DropTable("dbo.AvisoCitas");
        }
    }
}
