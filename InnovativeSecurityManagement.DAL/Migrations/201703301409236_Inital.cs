namespace InnovativeSecurityManagement.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContractorEmployees",
                c => new
                    {
                        ContractorEmployeeId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        MobilePhone = c.Int(nullable: false),
                        CompanyPhone = c.Int(nullable: false),
                        ExtentionNumber = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        Contractor_ContractorId = c.Int(),
                    })
                .PrimaryKey(t => t.ContractorEmployeeId)
                .ForeignKey("dbo.Contractors", t => t.Contractor_ContractorId)
                .Index(t => t.Contractor_ContractorId);
            
            CreateTable(
                "dbo.Contractors",
                c => new
                    {
                        ContractorId = c.Int(nullable: false, identity: true),
                        ContractorCompanyName = c.String(),
                        ContractorAddress1 = c.String(),
                        ContractorAddress2 = c.String(),
                        ContractorPostcode = c.String(),
                        ContractorPhone = c.Int(nullable: false),
                        EmailAddress = c.String(),
                    })
                .PrimaryKey(t => t.ContractorId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(maxLength: 225),
                        Title = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Postcode = c.String(),
                        MobilePhone = c.Int(nullable: false),
                        HomePhone = c.Int(nullable: false),
                        EmailAddress = c.String(),
                        Steward = c.Boolean(nullable: false),
                        SecurityGaurd = c.String(maxLength: 16),
                        DoorSupervisor = c.String(maxLength: 16),
                        CCTV = c.String(maxLength: 16),
                        CloseProtection = c.String(maxLength: 16),
                        KinName = c.String(),
                        KinNumber = c.String(maxLength: 11),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        WorkHours = c.DateTime(nullable: false),
                        Order_OrderId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.Order_OrderId)
                .Index(t => t.Order_OrderId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        ContractorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderItems", "Order_OrderId", "dbo.Orders");
            DropForeignKey("dbo.ContractorEmployees", "Contractor_ContractorId", "dbo.Contractors");
            DropIndex("dbo.OrderItems", new[] { "Order_OrderId" });
            DropIndex("dbo.ContractorEmployees", new[] { "Contractor_ContractorId" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Employees");
            DropTable("dbo.Contractors");
            DropTable("dbo.ContractorEmployees");
        }
    }
}
