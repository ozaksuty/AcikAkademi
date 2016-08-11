namespace Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AcikAkademi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        StudentID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 10),
                        Surname = c.String(maxLength: 10),
                        BirthDate = c.DateTime(nullable: false),
                        About = c.String(),
                        isDeleted = c.Boolean(nullable: false),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
