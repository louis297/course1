namespace course1.Migrations
{
    using course1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<course1.Models.PostDB1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "course1.Models.PostDB1";
        }

        protected override void Seed(course1.Models.PostDB1 context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Posts.AddOrUpdate( p => p.postId,
                new Post { postTitle = "title 33" , postBody = "content content", postAuthor = "B"}
                );
        }
    }
}
