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
    // Address
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Person_Address
    {

        ///<summary>
        /// Primary key for Address records.
        ///</summary>
        public int AddressId { get; set; } // AddressID (Primary key)

        ///<summary>
        /// First street address line.
        ///</summary>
        public string AddressLine1 { get; set; } // AddressLine1

        ///<summary>
        /// Second street address line.
        ///</summary>
        public string AddressLine2 { get; set; } // AddressLine2

        ///<summary>
        /// Name of the city.
        ///</summary>
        public string City { get; set; } // City

        ///<summary>
        /// Unique identification number for the state or province. Foreign key to StateProvince table.
        ///</summary>
        public int StateProvinceId { get; set; } // StateProvinceID

        ///<summary>
        /// Postal code for the street address.
        ///</summary>
        public string PostalCode { get; set; } // PostalCode

        ///<summary>
        /// Latitude and longitude of this address.
        ///</summary>
        public System.Data.Entity.Spatial.DbGeography SpatialLocation { get; set; } // SpatialLocation

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Person_BusinessEntityAddress> Person_BusinessEntityAddresses { get; set; } // Many to many mapping
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders_BillToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_BillToAddressID
        public virtual ICollection<Sales_SalesOrderHeader> Sales_SalesOrderHeaders_ShipToAddressId { get; set; } // SalesOrderHeader.FK_SalesOrderHeader_Address_ShipToAddressID

        // Foreign keys
        public virtual Person_StateProvince Person_StateProvince { get; set; } // FK_Address_StateProvince_StateProvinceID
        
        public Person_Address()
        {
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityAddresses = new List<Person_BusinessEntityAddress>();
            Sales_SalesOrderHeaders_BillToAddressId = new List<Sales_SalesOrderHeader>();
            Sales_SalesOrderHeaders_ShipToAddressId = new List<Sales_SalesOrderHeader>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
