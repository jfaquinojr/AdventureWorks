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
    // SalesTerritory
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Sales_SalesTerritory
    {

        ///<summary>
        /// Primary key for SalesTerritory records.
        ///</summary>
        public int TerritoryId { get; set; } // TerritoryID (Primary key)

        ///<summary>
        /// Sales territory description
        ///</summary>
        public string Name { get; set; } // Name

        ///<summary>
        /// ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode.
        ///</summary>
        public string CountryRegionCode { get; set; } // CountryRegionCode

        ///<summary>
        /// Geographic area to which the sales territory belong.
        ///</summary>
        public string Group { get; set; } // Group

        ///<summary>
        /// Sales in the territory year to date.
        ///</summary>
        public decimal SalesYtd { get; set; } // SalesYTD

        ///<summary>
        /// Sales in the territory the previous year.
        ///</summary>
        public decimal SalesLastYear { get; set; } // SalesLastYear

        ///<summary>
        /// Business costs in the territory year to date.
        ///</summary>
        public decimal CostYtd { get; set; } // CostYTD

        ///<summary>
        /// Business costs in the territory the previous year.
        ///</summary>
        public decimal CostLastYear { get; set; } // CostLastYear

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Person_StateProvince> Person_StateProvinces { get; set; } // StateProvince.FK_StateProvince_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_Customer> Sales_Customers { get; set; } // Customer.FK_Customer_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_SalesPerson> Sales_SalesPersons { get; set; } // SalesPerson.FK_SalesPerson_SalesTerritory_TerritoryID
        public virtual ICollection<Sales_SalesTerritoryHistory> Sales_SalesTerritoryHistories { get; set; } // Many to many mapping

        // Foreign keys
        public virtual Person_CountryRegion Person_CountryRegion { get; set; } // FK_SalesTerritory_CountryRegion_CountryRegionCode
        
        public Sales_SalesTerritory()
        {
            SalesYtd = 0.00m;
            SalesLastYear = 0.00m;
            CostYtd = 0.00m;
            CostLastYear = 0.00m;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Sales_Customers = new List<Sales_Customer>();
            Sales_SalesOrderHeaders = new List<Sales_SalesOrderHeader>();
            Sales_SalesPersons = new List<Sales_SalesPerson>();
            Sales_SalesTerritoryHistories = new List<Sales_SalesTerritoryHistory>();
            Person_StateProvinces = new List<Person_StateProvince>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>