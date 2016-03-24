namespace OpenOrderFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class noenum : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carts", "Order_OrderId", "dbo.Orders");
            DropIndex("dbo.Carts", new[] { "Order_OrderId" });
            DropColumn("dbo.Carts", "Order_OrderId");
            DropColumn("dbo.Orders", "ketchup");
            DropColumn("dbo.Orders", "mayonnaise");
            DropColumn("dbo.Orders", "fries");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "fries", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "mayonnaise", c => c.Int(nullable: false));
            AddColumn("dbo.Orders", "ketchup", c => c.Int(nullable: false));
            AddColumn("dbo.Carts", "Order_OrderId", c => c.Int());
            CreateIndex("dbo.Carts", "Order_OrderId");
            AddForeignKey("dbo.Carts", "Order_OrderId", "dbo.Orders", "OrderId");
        }
    }
}
