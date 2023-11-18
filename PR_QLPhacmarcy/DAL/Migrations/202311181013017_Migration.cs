namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BILL_OFFLINE_DETAIL",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SoldPrice = c.Double(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                        IDPruduct = c.Int(nullable: false),
                        IDBill = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BILL_OFFLINE", t => t.ID)
                .ForeignKey("dbo.PRODUCTS", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.BILL_OFFLINE",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalAmount = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        IDCustomer = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EMPLOYEES", t => t.ID)
                .ForeignKey("dbo.USERS", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.EMPLOYEES",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Sex = c.String(maxLength: 3),
                        Phone = c.String(maxLength: 10, unicode: false),
                        Address = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100, unicode: false),
                        Image = c.String(maxLength: 8000, unicode: false),
                        UserName = c.String(maxLength: 30, unicode: false),
                        Password = c.String(maxLength: 30, unicode: false),
                        Salary = c.Double(nullable: false),
                        CCCD = c.String(maxLength: 12, unicode: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ROLES", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.ROLES",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.USERS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Sex = c.String(maxLength: 3),
                        Phone = c.String(maxLength: 10, unicode: false),
                        Address = c.String(maxLength: 100),
                        Email = c.String(maxLength: 100, unicode: false),
                        Image = c.String(maxLength: 8000, unicode: false),
                        UserName = c.String(maxLength: 30, unicode: false),
                        Password = c.String(maxLength: 30, unicode: false),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ROLES", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.PRODUCTS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Price = c.Double(nullable: false),
                        Discount = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        Image = c.String(maxLength: 8000, unicode: false),
                        Description = c.String(maxLength: 250),
                        ProductionDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        SupplierId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CATEGORYS", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.EMPLOYEES", t => t.ID)
                .ForeignKey("dbo.SUPPLIERS", t => t.ID)
                .Index(t => t.ID)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.CATEGORYS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Status = c.String(maxLength: 10),
                        Description = c.String(maxLength: 100),
                        CreatedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EMPLOYEES", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.SUPPLIERS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 30),
                        Address = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PAYMENTMETHOND",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NameMethod = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PAY_MENT",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TotalPrice = c.Double(nullable: false),
                        IDMethod = c.Int(nullable: false),
                        IDCustomer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PAYMENTMETHOND", t => t.ID)
                .ForeignKey("dbo.USERS", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.SALES_ORDER",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 40),
                        TotalAmount = c.Double(nullable: false),
                        IDShipping = c.Int(nullable: false),
                        IDPayment = c.Int(nullable: false),
                        IDCustomer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PAY_MENT", t => t.ID)
                .ForeignKey("dbo.SHIPPING", t => t.ID)
                .ForeignKey("dbo.USERS", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.SHIPPING",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Name = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SALES_ORDER_DETAIL",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        SoldPrice = c.Double(nullable: false),
                        TotalAmount = c.Int(nullable: false),
                        IDPruduct = c.Int(nullable: false),
                        IDSalesOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PRODUCTS", t => t.ID)
                .ForeignKey("dbo.SALES_ORDER", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.STOCKS",
                c => new
                    {
                        MonthYear = c.DateTime(nullable: false),
                        IDPruduct = c.Int(nullable: false),
                        FirstQuantity = c.Int(nullable: false),
                        ImportedQuantity = c.Int(nullable: false),
                        ExportedQuantity = c.Int(nullable: false),
                        FinalQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MonthYear, t.IDPruduct })
                .ForeignKey("dbo.PRODUCTS", t => t.IDPruduct, cascadeDelete: true)
                .Index(t => t.IDPruduct);
            
            CreateTable(
                "dbo.WARE_HOUSING",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImportedDate = c.DateTime(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        ImportedBy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EMPLOYEES", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.WARE_HOUSING_DETAILS",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IDPruduct = c.Int(nullable: false),
                        IDWareHousing = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        ImportedPrice = c.Double(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.PRODUCTS", t => t.ID)
                .ForeignKey("dbo.WARE_HOUSING", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WARE_HOUSING_DETAILS", "ID", "dbo.WARE_HOUSING");
            DropForeignKey("dbo.WARE_HOUSING_DETAILS", "ID", "dbo.PRODUCTS");
            DropForeignKey("dbo.WARE_HOUSING", "ID", "dbo.EMPLOYEES");
            DropForeignKey("dbo.STOCKS", "IDPruduct", "dbo.PRODUCTS");
            DropForeignKey("dbo.SALES_ORDER_DETAIL", "ID", "dbo.SALES_ORDER");
            DropForeignKey("dbo.SALES_ORDER_DETAIL", "ID", "dbo.PRODUCTS");
            DropForeignKey("dbo.SALES_ORDER", "ID", "dbo.USERS");
            DropForeignKey("dbo.SALES_ORDER", "ID", "dbo.SHIPPING");
            DropForeignKey("dbo.SALES_ORDER", "ID", "dbo.PAY_MENT");
            DropForeignKey("dbo.PAY_MENT", "ID", "dbo.USERS");
            DropForeignKey("dbo.PAY_MENT", "ID", "dbo.PAYMENTMETHOND");
            DropForeignKey("dbo.BILL_OFFLINE_DETAIL", "ID", "dbo.PRODUCTS");
            DropForeignKey("dbo.PRODUCTS", "ID", "dbo.SUPPLIERS");
            DropForeignKey("dbo.PRODUCTS", "ID", "dbo.EMPLOYEES");
            DropForeignKey("dbo.PRODUCTS", "CategoryId", "dbo.CATEGORYS");
            DropForeignKey("dbo.CATEGORYS", "ID", "dbo.EMPLOYEES");
            DropForeignKey("dbo.BILL_OFFLINE_DETAIL", "ID", "dbo.BILL_OFFLINE");
            DropForeignKey("dbo.BILL_OFFLINE", "ID", "dbo.USERS");
            DropForeignKey("dbo.USERS", "ID", "dbo.ROLES");
            DropForeignKey("dbo.BILL_OFFLINE", "ID", "dbo.EMPLOYEES");
            DropForeignKey("dbo.EMPLOYEES", "ID", "dbo.ROLES");
            DropIndex("dbo.WARE_HOUSING_DETAILS", new[] { "ID" });
            DropIndex("dbo.WARE_HOUSING", new[] { "ID" });
            DropIndex("dbo.STOCKS", new[] { "IDPruduct" });
            DropIndex("dbo.SALES_ORDER_DETAIL", new[] { "ID" });
            DropIndex("dbo.SALES_ORDER", new[] { "ID" });
            DropIndex("dbo.PAY_MENT", new[] { "ID" });
            DropIndex("dbo.CATEGORYS", new[] { "ID" });
            DropIndex("dbo.PRODUCTS", new[] { "CategoryId" });
            DropIndex("dbo.PRODUCTS", new[] { "ID" });
            DropIndex("dbo.USERS", new[] { "ID" });
            DropIndex("dbo.EMPLOYEES", new[] { "ID" });
            DropIndex("dbo.BILL_OFFLINE", new[] { "ID" });
            DropIndex("dbo.BILL_OFFLINE_DETAIL", new[] { "ID" });
            DropTable("dbo.WARE_HOUSING_DETAILS");
            DropTable("dbo.WARE_HOUSING");
            DropTable("dbo.STOCKS");
            DropTable("dbo.SALES_ORDER_DETAIL");
            DropTable("dbo.SHIPPING");
            DropTable("dbo.SALES_ORDER");
            DropTable("dbo.PAY_MENT");
            DropTable("dbo.PAYMENTMETHOND");
            DropTable("dbo.SUPPLIERS");
            DropTable("dbo.CATEGORYS");
            DropTable("dbo.PRODUCTS");
            DropTable("dbo.USERS");
            DropTable("dbo.ROLES");
            DropTable("dbo.EMPLOYEES");
            DropTable("dbo.BILL_OFFLINE");
            DropTable("dbo.BILL_OFFLINE_DETAIL");
        }
    }
}
