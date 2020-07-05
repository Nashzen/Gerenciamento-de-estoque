namespace TCC_Senai.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Salary = c.Double(nullable: false),
                        IsManager = c.Boolean(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Genre = c.String(nullable: false),
                        ReleaseYear = c.DateTime(nullable: false),
                        Price = c.Double(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Provider",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Cnpj = c.String(nullable: false, maxLength: 20),
                        Phone = c.String(nullable: false, maxLength: 20),
                        Email = c.String(nullable: false, maxLength: 100),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShippingDelivery",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EstimateDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        DeliveryValue = c.Double(),
                        QuantityDelivered = c.Int(nullable: false),
                        IdProvider = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provider", t => t.IdProvider, cascadeDelete: true)
                .Index(t => t.IdProvider);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TotalAmmount = c.Int(nullable: false),
                        AvailableAmmount = c.Int(nullable: false),
                        IdProduto = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.IdProduto, cascadeDelete: true)
                .Index(t => t.IdProduto);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false, maxLength: 30),
                        Password = c.String(nullable: false, maxLength: 15),
                        IsActive = c.Boolean(nullable: false),
                        IdEmployee = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employee", t => t.IdEmployee, cascadeDelete: true)
                .Index(t => t.IdEmployee);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "IdEmployee", "dbo.Employee");
            DropForeignKey("dbo.Stock", "IdProduto", "dbo.Product");
            DropForeignKey("dbo.ShippingDelivery", "IdProvider", "dbo.Provider");
            DropIndex("dbo.User", new[] { "IdEmployee" });
            DropIndex("dbo.Stock", new[] { "IdProduto" });
            DropIndex("dbo.ShippingDelivery", new[] { "IdProvider" });
            DropTable("dbo.User");
            DropTable("dbo.Stock");
            DropTable("dbo.ShippingDelivery");
            DropTable("dbo.Provider");
            DropTable("dbo.Product");
            DropTable("dbo.Employee");
        }
    }
}
