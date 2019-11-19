namespace SearchName.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class myfirstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientAdds",
                c => new
                    {
                        a_Id = c.Int(nullable: false, identity: true),
                        address = c.String(),
                        clientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.a_Id)
                .ForeignKey("dbo.Clients", t => t.clientId, cascadeDelete: true)
                .Index(t => t.clientId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        clientId = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.clientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientAdds", "clientId", "dbo.Clients");
            DropIndex("dbo.ClientAdds", new[] { "clientId" });
            DropTable("dbo.Clients");
            DropTable("dbo.ClientAdds");
        }
    }
}
