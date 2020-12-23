namespace BookSaller.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createPublisher : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publishers");
        }
    }
}
