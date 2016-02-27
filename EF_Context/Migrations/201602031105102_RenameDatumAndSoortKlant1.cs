namespace EF_Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameDatumAndSoortKlant1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Datum", newName: "Datums");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Datums", newName: "Datum");
        }
    }
}
