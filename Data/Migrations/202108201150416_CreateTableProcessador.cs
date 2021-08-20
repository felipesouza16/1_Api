namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProcessador : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Processadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marca = c.String(),
                        Nucleos = c.Int(nullable: false),
                        Threads = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Processadors");
        }
    }
}
