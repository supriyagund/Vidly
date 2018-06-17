namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetCustomerBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '10/07/1984' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = Null WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
