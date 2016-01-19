// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace JFA.AdventureWorks.Entities
{
    public interface IAdventureWorksDBContext : IDisposable
    {
        DbSet<AwBuildVersion> AwBuildVersions { get; set; } // AWBuildVersion
        DbSet<DatabaseLog> DatabaseLogs { get; set; } // DatabaseLog
        DbSet<ErrorLog> ErrorLogs { get; set; } // ErrorLog
        DbSet<HumanResources_Department> HumanResources_Departments { get; set; } // Department
        DbSet<HumanResources_Employee> HumanResources_Employees { get; set; } // Employee
        DbSet<HumanResources_EmployeeDepartmentHistory> HumanResources_EmployeeDepartmentHistories { get; set; } // EmployeeDepartmentHistory
        DbSet<HumanResources_EmployeePayHistory> HumanResources_EmployeePayHistories { get; set; } // EmployeePayHistory
        DbSet<HumanResources_JobCandidate> HumanResources_JobCandidates { get; set; } // JobCandidate
        DbSet<HumanResources_Shift> HumanResources_Shifts { get; set; } // Shift
        DbSet<HumanResources_VEmployee> HumanResources_VEmployees { get; set; } // vEmployee
        DbSet<HumanResources_VEmployeeDepartment> HumanResources_VEmployeeDepartments { get; set; } // vEmployeeDepartment
        DbSet<HumanResources_VEmployeeDepartmentHistory> HumanResources_VEmployeeDepartmentHistories { get; set; } // vEmployeeDepartmentHistory
        DbSet<HumanResources_VJobCandidate> HumanResources_VJobCandidates { get; set; } // vJobCandidate
        DbSet<HumanResources_VJobCandidateEducation> HumanResources_VJobCandidateEducations { get; set; } // vJobCandidateEducation
        DbSet<HumanResources_VJobCandidateEmployment> HumanResources_VJobCandidateEmployments { get; set; } // vJobCandidateEmployment
        DbSet<Person_Address> Person_Addresses { get; set; } // Address
        DbSet<Person_AddressType> Person_AddressTypes { get; set; } // AddressType
        DbSet<Person_BusinessEntity> Person_BusinessEntities { get; set; } // BusinessEntity
        DbSet<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } // BusinessEntityAddress
        DbSet<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } // BusinessEntityContact
        DbSet<Person_ContactType> Person_ContactTypes { get; set; } // ContactType
        DbSet<Person_CountryRegion> Person_CountryRegions { get; set; } // CountryRegion
        DbSet<Person_EmailAddress> Person_EmailAddresses { get; set; } // EmailAddress
        DbSet<Person_Password> Person_Passwords { get; set; } // Password
        DbSet<Person_Person> Person_People { get; set; } // Person
        DbSet<Person_PersonPhone> Person_PersonPhones { get; set; } // PersonPhone
        DbSet<Person_PhoneNumberType> Person_PhoneNumberTypes { get; set; } // PhoneNumberType
        DbSet<Person_StateProvince> Person_StateProvinces { get; set; } // StateProvince
        DbSet<Person_VAdditionalContactInfo> Person_VAdditionalContactInfoes { get; set; } // vAdditionalContactInfo
        DbSet<Person_VStateProvinceCountryRegion> Person_VStateProvinceCountryRegions { get; set; } // vStateProvinceCountryRegion
        DbSet<Production_BillOfMaterial> Production_BillOfMaterials { get; set; } // BillOfMaterials
        DbSet<Production_Culture> Production_Cultures { get; set; } // Culture
        DbSet<Production_Document> Production_Documents { get; set; } // Document
        DbSet<Production_Illustration> Production_Illustrations { get; set; } // Illustration
        DbSet<Production_Location> Production_Locations { get; set; } // Location
        DbSet<Production_Product> Production_Products { get; set; } // Product
        DbSet<Production_ProductCategory> Production_ProductCategories { get; set; } // ProductCategory
        DbSet<Production_ProductCostHistory> Production_ProductCostHistories { get; set; } // ProductCostHistory
        DbSet<Production_ProductDescription> Production_ProductDescriptions { get; set; } // ProductDescription
        DbSet<Production_ProductDocument> Production_ProductDocuments { get; set; } // ProductDocument
        DbSet<Production_ProductInventory> Production_ProductInventories { get; set; } // ProductInventory
        DbSet<Production_ProductListPriceHistory> Production_ProductListPriceHistories { get; set; } // ProductListPriceHistory
        DbSet<Production_ProductModel> Production_ProductModels { get; set; } // ProductModel
        DbSet<Production_ProductModelIllustration> Production_ProductModelIllustrations { get; set; } // ProductModelIllustration
        DbSet<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } // ProductModelProductDescriptionCulture
        DbSet<Production_ProductPhoto> Production_ProductPhotoes { get; set; } // ProductPhoto
        DbSet<Production_ProductProductPhoto> Production_ProductProductPhotoes { get; set; } // ProductProductPhoto
        DbSet<Production_ProductReview> Production_ProductReviews { get; set; } // ProductReview
        DbSet<Production_ProductSubcategory> Production_ProductSubcategories { get; set; } // ProductSubcategory
        DbSet<Production_ScrapReason> Production_ScrapReasons { get; set; } // ScrapReason
        DbSet<Production_TransactionHistory> Production_TransactionHistories { get; set; } // TransactionHistory
        DbSet<Production_TransactionHistoryArchive> Production_TransactionHistoryArchives { get; set; } // TransactionHistoryArchive
        DbSet<Production_UnitMeasure> Production_UnitMeasures { get; set; } // UnitMeasure
        DbSet<Production_VProductAndDescription> Production_VProductAndDescriptions { get; set; } // vProductAndDescription
        DbSet<Production_VProductModelCatalogDescription> Production_VProductModelCatalogDescriptions { get; set; } // vProductModelCatalogDescription
        DbSet<Production_VProductModelInstruction> Production_VProductModelInstructions { get; set; } // vProductModelInstructions
        DbSet<Production_WorkOrder> Production_WorkOrders { get; set; } // WorkOrder
        DbSet<Production_WorkOrderRouting> Production_WorkOrderRoutings { get; set; } // WorkOrderRouting
        DbSet<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } // ProductVendor
        DbSet<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } // PurchaseOrderDetail
        DbSet<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader
        DbSet<Purchasing_ShipMethod> Purchasing_ShipMethods { get; set; } // ShipMethod
        DbSet<Purchasing_Vendor> Purchasing_Vendors { get; set; } // Vendor
        DbSet<Purchasing_VVendorWithAddress> Purchasing_VVendorWithAddresses { get; set; } // vVendorWithAddresses
        DbSet<Purchasing_VVendorWithContact> Purchasing_VVendorWithContacts { get; set; } // vVendorWithContacts
        DbSet<Sales_CountryRegionCurrency> Sales_CountryRegionCurrencies { get; set; } // CountryRegionCurrency
        DbSet<Sales_CreditCard> Sales_CreditCards { get; set; } // CreditCard
        DbSet<Sales_Currency> Sales_Currencies { get; set; } // Currency
        DbSet<Sales_CurrencyRate> Sales_CurrencyRates { get; set; } // CurrencyRate
        DbSet<Sales_Customer> Sales_Customers { get; set; } // Customer
        DbSet<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } // PersonCreditCard
        DbSet<Sales_SalesOrderDetail> Sales_SalesOrderDetails { get; set; } // SalesOrderDetail
        DbSet<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } // SalesOrderHeader
        DbSet<Sales_SalesOrderHeaderSalesReason> Sales_SalesOrderHeaderSalesReasons { get; set; } // SalesOrderHeaderSalesReason
        DbSet<Sales_SalesPerson> Sales_SalesPersons { get; set; } // SalesPerson
        DbSet<Sales_SalesPersonQuotaHistory> Sales_SalesPersonQuotaHistories { get; set; } // SalesPersonQuotaHistory
        DbSet<Sales_SalesReason> Sales_SalesReasons { get; set; } // SalesReason
        DbSet<Sales_SalesTaxRate> Sales_SalesTaxRates { get; set; } // SalesTaxRate
        DbSet<Sales_SalesTerritory> Sales_SalesTerritories { get; set; } // SalesTerritory
        DbSet<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // SalesTerritoryHistory
        DbSet<Sales_ShoppingCartItem> Sales_ShoppingCartItems { get; set; } // ShoppingCartItem
        DbSet<Sales_SpecialOffer> Sales_SpecialOffers { get; set; } // SpecialOffer
        DbSet<Sales_SpecialOfferProduct> Sales_SpecialOfferProducts { get; set; } // SpecialOfferProduct
        DbSet<Sales_Store> Sales_Stores { get; set; } // Store
        DbSet<Sales_VIndividualCustomer> Sales_VIndividualCustomers { get; set; } // vIndividualCustomer
        DbSet<Sales_VPersonDemographic> Sales_VPersonDemographics { get; set; } // vPersonDemographics
        DbSet<Sales_VSalesPerson> Sales_VSalesPersons { get; set; } // vSalesPerson
        DbSet<Sales_VSalesPersonSalesByFiscalYear> Sales_VSalesPersonSalesByFiscalYears { get; set; } // vSalesPersonSalesByFiscalYears
        DbSet<Sales_VStoreWithAddress> Sales_VStoreWithAddresses { get; set; } // vStoreWithAddresses
        DbSet<Sales_VStoreWithContact> Sales_VStoreWithContacts { get; set; } // vStoreWithContacts
        DbSet<Sales_VStoreWithDemographic> Sales_VStoreWithDemographics { get; set; } // vStoreWithDemographics

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
        List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate);
        List<UspGetBillOfMaterialsReturnModel> UspGetBillOfMaterials(int? startProductId, DateTime? checkDate, out int procResult);
        List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId);
        List<UspGetEmployeeManagersReturnModel> UspGetEmployeeManagers(int? businessEntityId, out int procResult);
        List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId);
        List<UspGetManagerEmployeesReturnModel> UspGetManagerEmployees(int? businessEntityId, out int procResult);
        List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate);
        List<UspGetWhereUsedProductIdReturnModel> UspGetWhereUsedProductId(int? startProductId, DateTime? checkDate, out int procResult);
        int UspLogError(out int? errorLogId);
        int UspPrintError();
        int HumanResources_UspUpdateEmployeeHireInfo(int? businessEntityId, string jobTitle, DateTime? hireDate, DateTime? rateChangeDate, decimal? rate, byte? payFrequency, bool? currentFlag);
        int HumanResources_UspUpdateEmployeeLogin(int? businessEntityId, string organizationNode, string loginId, string jobTitle, DateTime? hireDate, bool? currentFlag);
        int HumanResources_UspUpdateEmployeePersonalInfo(int? businessEntityId, string nationalIdNumber, DateTime? birthDate, string maritalStatus, string gender);
    }

}
// </auto-generated>