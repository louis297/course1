namespace course1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        postId = c.Int(nullable: false, identity: true),
                        postAuthor = c.String(),
                        postTitle = c.String(),
                        postBody = c.String(),
                    })
                .PrimaryKey(t => t.postId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
