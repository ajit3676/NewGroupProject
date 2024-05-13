namespace NewGroupProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ReservationID = c.Int(nullable: false, identity: true),
                        ReservationName = c.String(),
                        NoofGuests = c.Int(nullable: false),
                        ReservationDate = c.String(),
                        ReservationTime = c.String(),
                    })
                .PrimaryKey(t => t.ReservationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reservations");
        }
    }
}
