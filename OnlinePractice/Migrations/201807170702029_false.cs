namespace OnlinePractice.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _false : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Orders");
            AlterColumn("dbo.Customers", "CustomerID", c => c.Guid(nullable: false));
            AlterColumn("dbo.Orders", "OrderId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Orders", "CustomerID", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.Customers", "CustomerID");
            AddPrimaryKey("dbo.Orders", "OrderId");
            CreateIndex("dbo.Orders", "CustomerID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Orders", "CustomerID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Customers", "CustomerID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Orders", "OrderId");
            AddPrimaryKey("dbo.Customers", "CustomerID");
            CreateIndex("dbo.Orders", "CustomerID");
            AddForeignKey("dbo.Orders", "CustomerID", "dbo.Customers", "CustomerID", cascadeDelete: true);
        }
    }
}
