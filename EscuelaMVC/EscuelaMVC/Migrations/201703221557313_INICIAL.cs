namespace EscuelaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class INICIAL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnos",
                c => new
                    {
                        pkAlumnos = c.Int(nullable: false, identity: true),
                        sNombre = c.String(nullable: false),
                        sApellido = c.String(nullable: false),
                        sGrupo = c.String(nullable: false),
                        sImagen = c.String(),
                        bStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.pkAlumnos);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Alumnos");
        }
    }
}
