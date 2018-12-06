// DISCLAIMER
// This file contains auto generated code.
// Changes to this file may be overwritten when the files are regenerated.
using Microsoft.EntityFrameworkCore;

namespace AutoGeneratedApi
{
    public class ApplicationDbContext : DbContext
    {
		public DbSet<Sales.SalesTaxRate> Sales_SalesTaxRate { get; set; }
		public DbSet<Sales.PersonCreditCard> Sales_PersonCreditCard { get; set; }
		public DbSet<Sales.SalesTerritory> Sales_SalesTerritory { get; set; }
		public DbSet<Sales.SpecialOfferProduct_inmem> Sales_SpecialOfferProduct_inmem { get; set; }
		public DbSet<Sales.SalesOrderHeader_inmem> Sales_SalesOrderHeader_inmem { get; set; }
		public DbSet<Sales.SalesTerritoryHistory> Sales_SalesTerritoryHistory { get; set; }
		public DbSet<Sales.SalesOrderDetail_inmem> Sales_SalesOrderDetail_inmem { get; set; }
		public DbSet<Sales.ShoppingCartItem> Sales_ShoppingCartItem { get; set; }
		public DbSet<Sales.SpecialOffer> Sales_SpecialOffer { get; set; }
		public DbSet<Sales.SpecialOffer_ondisk> Sales_SpecialOffer_ondisk { get; set; }
		public DbSet<Sales.SpecialOfferProduct> Sales_SpecialOfferProduct { get; set; }
		public DbSet<Sales.Store> Sales_Store { get; set; }
		public DbSet<Sales.SpecialOfferProduct_ondisk> Sales_SpecialOfferProduct_ondisk { get; set; }
		public DbSet<Sales.SalesOrderHeader_ondisk> Sales_SalesOrderHeader_ondisk { get; set; }
		public DbSet<Sales.CountryRegionCurrency> Sales_CountryRegionCurrency { get; set; }
		public DbSet<Sales.CreditCard> Sales_CreditCard { get; set; }
		public DbSet<Sales.Currency> Sales_Currency { get; set; }
		public DbSet<Sales.CurrencyRate> Sales_CurrencyRate { get; set; }
		public DbSet<Sales.Customer> Sales_Customer { get; set; }
		public DbSet<Sales.SalesOrderDetail_ondisk> Sales_SalesOrderDetail_ondisk { get; set; }
		public DbSet<Sales.SalesOrder_json> Sales_SalesOrder_json { get; set; }
		public DbSet<Sales.SalesOrderDetail> Sales_SalesOrderDetail { get; set; }
		public DbSet<Sales.SalesOrderHeader> Sales_SalesOrderHeader { get; set; }
		public DbSet<Sales.SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReason { get; set; }
		public DbSet<Sales.SalesPerson> Sales_SalesPerson { get; set; }
		public DbSet<Sales.SpecialOffer_inmem> Sales_SpecialOffer_inmem { get; set; }
		public DbSet<Sales.TrackingEvent> Sales_TrackingEvent { get; set; }
		public DbSet<Sales.OrderTracking> Sales_OrderTracking { get; set; }
		public DbSet<Sales.SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistory { get; set; }
		public DbSet<Sales.SalesReason> Sales_SalesReason { get; set; }
		public DbSet<Person.PersonPhone> Person_PersonPhone { get; set; }
		public DbSet<Person.Address> Person_Address { get; set; }
		public DbSet<Person.AddressType> Person_AddressType { get; set; }
		public DbSet<Person.StateProvince> Person_StateProvince { get; set; }
		public DbSet<Person.BusinessEntity> Person_BusinessEntity { get; set; }
		public DbSet<Person.BusinessEntityAddress> Person_BusinessEntityAddress { get; set; }
		public DbSet<Person.BusinessEntityContact> Person_BusinessEntityContact { get; set; }
		public DbSet<Person.ContactType> Person_ContactType { get; set; }
		public DbSet<Person.CountryRegion> Person_CountryRegion { get; set; }
		public DbSet<Person.EmailAddress> Person_EmailAddress { get; set; }
		public DbSet<Person.Person_json> Person_Person_json { get; set; }
		public DbSet<Person.Person_Temporal> Person_Person_Temporal { get; set; }
		public DbSet<Person.PhoneNumberType> Person_PhoneNumberType { get; set; }
		public DbSet<Person.Password> Person_Password { get; set; }
		public DbSet<Person.Person> Person_Person { get; set; }
		public DbSet<Production.Product> Production_Product { get; set; }
		public DbSet<Production.ScrapReason> Production_ScrapReason { get; set; }
		public DbSet<Production.ProductCategory> Production_ProductCategory { get; set; }
		public DbSet<Production.ProductCostHistory> Production_ProductCostHistory { get; set; }
		public DbSet<Production.ProductDescription> Production_ProductDescription { get; set; }
		public DbSet<Production.ProductDocument> Production_ProductDocument { get; set; }
		public DbSet<Production.ProductInventory> Production_ProductInventory { get; set; }
		public DbSet<Production.ProductListPriceHistory> Production_ProductListPriceHistory { get; set; }
		public DbSet<Production.ProductModel> Production_ProductModel { get; set; }
		public DbSet<Production.Product_ondisk> Production_Product_ondisk { get; set; }
		public DbSet<Production.ProductModelIllustration> Production_ProductModelIllustration { get; set; }
		public DbSet<Production.ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCulture { get; set; }
		public DbSet<Production.BillOfMaterials> Production_BillOfMaterials { get; set; }
		public DbSet<Production.ProductPhoto> Production_ProductPhoto { get; set; }
		public DbSet<Production.ProductProductPhoto> Production_ProductProductPhoto { get; set; }
		public DbSet<Production.TransactionHistory> Production_TransactionHistory { get; set; }
		public DbSet<Production.ProductReview> Production_ProductReview { get; set; }
		public DbSet<Production.TransactionHistoryArchive> Production_TransactionHistoryArchive { get; set; }
		public DbSet<Production.ProductSubcategory> Production_ProductSubcategory { get; set; }
		public DbSet<Production.UnitMeasure> Production_UnitMeasure { get; set; }
		public DbSet<Production.WorkOrder> Production_WorkOrder { get; set; }
		public DbSet<Production.Culture> Production_Culture { get; set; }
		public DbSet<Production.WorkOrderRouting> Production_WorkOrderRouting { get; set; }
		public DbSet<Production.Document> Production_Document { get; set; }
		public DbSet<Production.Illustration> Production_Illustration { get; set; }
		public DbSet<Production.Location> Production_Location { get; set; }
		public DbSet<Production.Product_inmem> Production_Product_inmem { get; set; }
		public DbSet<HumanResources.Shift> HumanResources_Shift { get; set; }
		public DbSet<HumanResources.Department> HumanResources_Department { get; set; }
		public DbSet<HumanResources.Employee> HumanResources_Employee { get; set; }
		public DbSet<HumanResources.EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistory { get; set; }
		public DbSet<HumanResources.EmployeePayHistory> HumanResources_EmployeePayHistory { get; set; }
		public DbSet<HumanResources.Employee_Temporal> HumanResources_Employee_Temporal { get; set; }
		public DbSet<HumanResources.JobCandidate> HumanResources_JobCandidate { get; set; }
		public DbSet<Purchasing.ShipMethod> Purchasing_ShipMethod { get; set; }
		public DbSet<Purchasing.ProductVendor> Purchasing_ProductVendor { get; set; }
		public DbSet<Purchasing.Vendor> Purchasing_Vendor { get; set; }
		public DbSet<Purchasing.PurchaseOrderDetail> Purchasing_PurchaseOrderDetail { get; set; }
		public DbSet<Purchasing.PurchaseOrderHeader> Purchasing_PurchaseOrderHeader { get; set; }
		public DbSet<dbo.DatabaseLog> dbo_DatabaseLog { get; set; }
		public DbSet<dbo.ErrorLog> dbo_ErrorLog { get; set; }
		public DbSet<dbo.AWBuildVersion> dbo_AWBuildVersion { get; set; }
		public DbSet<Demo.DemoSalesOrderDetailSeed> Demo_DemoSalesOrderDetailSeed { get; set; }
		public DbSet<Demo.DemoSalesOrderHeaderSeed> Demo_DemoSalesOrderHeaderSeed { get; set; }


		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Sales.SalesTaxRate>().HasKey(x => x.SalesTaxRateID);
			modelBuilder.Entity<Sales.PersonCreditCard>().HasKey(x => new {x.BusinessEntityID,x.CreditCardID});
			modelBuilder.Entity<Sales.SalesTerritory>().HasKey(x => x.TerritoryID);
			modelBuilder.Entity<Sales.SpecialOfferProduct_inmem>().HasKey(x => new {x.ProductID,x.SpecialOfferID});
			modelBuilder.Entity<Sales.SalesOrderHeader_inmem>().HasKey(x => x.SalesOrderID);
			modelBuilder.Entity<Sales.SalesTerritoryHistory>().HasKey(x => new {x.BusinessEntityID,x.StartDate,x.TerritoryID});
			modelBuilder.Entity<Sales.SalesOrderDetail_inmem>().HasKey(x => new {x.SalesOrderDetailID,x.SalesOrderID});
			modelBuilder.Entity<Sales.ShoppingCartItem>().HasKey(x => x.ShoppingCartItemID);
			modelBuilder.Entity<Sales.SpecialOffer>().HasKey(x => x.SpecialOfferID);
			modelBuilder.Entity<Sales.SpecialOffer_ondisk>().HasKey(x => x.SpecialOfferID);
			modelBuilder.Entity<Sales.SpecialOfferProduct>().HasKey(x => new {x.ProductID,x.SpecialOfferID});
			modelBuilder.Entity<Sales.Store>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Sales.SpecialOfferProduct_ondisk>().HasKey(x => new {x.ProductID,x.SpecialOfferID});
			modelBuilder.Entity<Sales.SalesOrderHeader_ondisk>().HasKey(x => x.SalesOrderID);
			modelBuilder.Entity<Sales.CountryRegionCurrency>().HasKey(x => new {x.CountryRegionCode,x.CurrencyCode});
			modelBuilder.Entity<Sales.CreditCard>().HasKey(x => x.CreditCardID);
			modelBuilder.Entity<Sales.Currency>().HasKey(x => x.CurrencyCode);
			modelBuilder.Entity<Sales.CurrencyRate>().HasKey(x => x.CurrencyRateID);
			modelBuilder.Entity<Sales.Customer>().HasKey(x => x.CustomerID);
			modelBuilder.Entity<Sales.SalesOrderDetail_ondisk>().HasKey(x => new {x.SalesOrderDetailID,x.SalesOrderID});
			modelBuilder.Entity<Sales.SalesOrder_json>().HasKey(x => x.SalesOrderID);
			modelBuilder.Entity<Sales.SalesOrderDetail>().HasKey(x => new {x.SalesOrderDetailID,x.SalesOrderID});
			modelBuilder.Entity<Sales.SalesOrderHeader>().HasKey(x => x.SalesOrderID);
			modelBuilder.Entity<Sales.SalesOrderHeaderSalesReason>().HasKey(x => new {x.SalesOrderID,x.SalesReasonID});
			modelBuilder.Entity<Sales.SalesPerson>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Sales.SpecialOffer_inmem>().HasKey(x => x.SpecialOfferID);
			modelBuilder.Entity<Sales.TrackingEvent>().HasKey(x => x.TrackingEventID);
			modelBuilder.Entity<Sales.OrderTracking>().HasKey(x => x.OrderTrackingID);
			modelBuilder.Entity<Sales.SalesPersonQuotaHistory>().HasKey(x => new {x.BusinessEntityID,x.QuotaDate});
			modelBuilder.Entity<Sales.SalesReason>().HasKey(x => x.SalesReasonID);
			modelBuilder.Entity<Person.PersonPhone>().HasKey(x => new {x.BusinessEntityID,x.PhoneNumber,x.PhoneNumberTypeID});
			modelBuilder.Entity<Person.Address>().HasKey(x => x.AddressID);
			modelBuilder.Entity<Person.AddressType>().HasKey(x => x.AddressTypeID);
			modelBuilder.Entity<Person.StateProvince>().HasKey(x => x.StateProvinceID);
			modelBuilder.Entity<Person.BusinessEntity>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Person.BusinessEntityAddress>().HasKey(x => new {x.AddressID,x.AddressTypeID,x.BusinessEntityID});
			modelBuilder.Entity<Person.BusinessEntityContact>().HasKey(x => new {x.BusinessEntityID,x.ContactTypeID,x.PersonID});
			modelBuilder.Entity<Person.ContactType>().HasKey(x => x.ContactTypeID);
			modelBuilder.Entity<Person.CountryRegion>().HasKey(x => x.CountryRegionCode);
			modelBuilder.Entity<Person.EmailAddress>().HasKey(x => new {x.BusinessEntityID,x.EmailAddressID});
			modelBuilder.Entity<Person.Person_json>().HasKey(x => x.PersonID);
			modelBuilder.Entity<Person.Person_Temporal>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Person.PhoneNumberType>().HasKey(x => x.PhoneNumberTypeID);
			modelBuilder.Entity<Person.Password>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Person.Person>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Production.Product>().HasKey(x => x.ProductID);
			modelBuilder.Entity<Production.ScrapReason>().HasKey(x => x.ScrapReasonID);
			modelBuilder.Entity<Production.ProductCategory>().HasKey(x => x.ProductCategoryID);
			modelBuilder.Entity<Production.ProductCostHistory>().HasKey(x => new {x.ProductID,x.StartDate});
			modelBuilder.Entity<Production.ProductDescription>().HasKey(x => x.ProductDescriptionID);
			modelBuilder.Entity<Production.ProductDocument>().HasKey(x => new {x.DocumentNode,x.ProductID});
			modelBuilder.Entity<Production.ProductInventory>().HasKey(x => new {x.LocationID,x.ProductID});
			modelBuilder.Entity<Production.ProductListPriceHistory>().HasKey(x => new {x.ProductID,x.StartDate});
			modelBuilder.Entity<Production.ProductModel>().HasKey(x => x.ProductModelID);
			modelBuilder.Entity<Production.Product_ondisk>().HasKey(x => x.ProductID);
			modelBuilder.Entity<Production.ProductModelIllustration>().HasKey(x => new {x.IllustrationID,x.ProductModelID});
			modelBuilder.Entity<Production.ProductModelProductDescriptionCulture>().HasKey(x => new {x.CultureID,x.ProductDescriptionID,x.ProductModelID});
			modelBuilder.Entity<Production.BillOfMaterials>().HasKey(x => x.BillOfMaterialsID);
			modelBuilder.Entity<Production.ProductPhoto>().HasKey(x => x.ProductPhotoID);
			modelBuilder.Entity<Production.ProductProductPhoto>().HasKey(x => new {x.ProductID,x.ProductPhotoID});
			modelBuilder.Entity<Production.TransactionHistory>().HasKey(x => x.TransactionID);
			modelBuilder.Entity<Production.ProductReview>().HasKey(x => x.ProductReviewID);
			modelBuilder.Entity<Production.TransactionHistoryArchive>().HasKey(x => x.TransactionID);
			modelBuilder.Entity<Production.ProductSubcategory>().HasKey(x => x.ProductSubcategoryID);
			modelBuilder.Entity<Production.UnitMeasure>().HasKey(x => x.UnitMeasureCode);
			modelBuilder.Entity<Production.WorkOrder>().HasKey(x => x.WorkOrderID);
			modelBuilder.Entity<Production.Culture>().HasKey(x => x.CultureID);
			modelBuilder.Entity<Production.WorkOrderRouting>().HasKey(x => new {x.OperationSequence,x.ProductID,x.WorkOrderID});
			modelBuilder.Entity<Production.Document>().HasKey(x => x.DocumentNode);
			modelBuilder.Entity<Production.Illustration>().HasKey(x => x.IllustrationID);
			modelBuilder.Entity<Production.Location>().HasKey(x => x.LocationID);
			modelBuilder.Entity<Production.Product_inmem>().HasKey(x => x.ProductID);
			modelBuilder.Entity<HumanResources.Shift>().HasKey(x => x.ShiftID);
			modelBuilder.Entity<HumanResources.Department>().HasKey(x => x.DepartmentID);
			modelBuilder.Entity<HumanResources.Employee>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<HumanResources.EmployeeDepartmentHistory>().HasKey(x => new {x.BusinessEntityID,x.DepartmentID,x.ShiftID,x.StartDate});
			modelBuilder.Entity<HumanResources.EmployeePayHistory>().HasKey(x => new {x.BusinessEntityID,x.RateChangeDate});
			modelBuilder.Entity<HumanResources.Employee_Temporal>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<HumanResources.JobCandidate>().HasKey(x => x.JobCandidateID);
			modelBuilder.Entity<Purchasing.ShipMethod>().HasKey(x => x.ShipMethodID);
			modelBuilder.Entity<Purchasing.ProductVendor>().HasKey(x => new {x.BusinessEntityID,x.ProductID});
			modelBuilder.Entity<Purchasing.Vendor>().HasKey(x => x.BusinessEntityID);
			modelBuilder.Entity<Purchasing.PurchaseOrderDetail>().HasKey(x => new {x.PurchaseOrderDetailID,x.PurchaseOrderID});
			modelBuilder.Entity<Purchasing.PurchaseOrderHeader>().HasKey(x => x.PurchaseOrderID);
			modelBuilder.Entity<dbo.DatabaseLog>().HasKey(x => x.DatabaseLogID);
			modelBuilder.Entity<dbo.ErrorLog>().HasKey(x => x.ErrorLogID);
			modelBuilder.Entity<dbo.AWBuildVersion>().HasKey(x => x.SystemInformationID);
			modelBuilder.Entity<Demo.DemoSalesOrderDetailSeed>().HasKey(x => x.LocalID);
			modelBuilder.Entity<Demo.DemoSalesOrderHeaderSeed>().HasKey(x => x.LocalID);

		}
	}
}