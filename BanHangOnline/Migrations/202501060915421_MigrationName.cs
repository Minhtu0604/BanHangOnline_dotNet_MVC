namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Adv",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Tiltle = c.String(nullable: false, maxLength: 150),
                    Description = c.String(maxLength: 500),
                    Image = c.String(maxLength: 500),
                    Link = c.String(maxLength: 500),
                    Type = c.Int(nullable: false),
                    CreatedBy = c.String(),
                    CreatesDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    Modifiedby = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.tb_Category",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Tiltle = c.String(nullable: false, maxLength: 150),
                    Alias = c.String(),
                    Description = c.String(),
                    SeoTitle = c.String(maxLength: 150),
                    SeoDescription = c.String(maxLength: 150),
                    SeoKeywords = c.String(maxLength: 150),
                    IsActive = c.Boolean(nullable: false),
                    Position = c.Int(nullable: false),
                    CreatedBy = c.String(),
                    CreatesDate = c.DateTime(nullable: false),
                    ModifiedDate = c.DateTime(nullable: false),
                    Modifiedby = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.tb_Category");
            DropTable("dbo.tb_Adv");
        }
    }
}
