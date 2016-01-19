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
    // Vendor
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Purchasing_Vendor
    {

        ///<summary>
        /// Primary key for Vendor records.  Foreign key to BusinessEntity.BusinessEntityID
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Vendor account (identification) number.
        ///</summary>
        public string AccountNumber { get; set; } // AccountNumber

        ///<summary>
        /// Company name.
        ///</summary>
        public string Name { get; set; } // Name

        ///<summary>
        /// 1 = Superior, 2 = Excellent, 3 = Above average, 4 = Average, 5 = Below average
        ///</summary>
        public byte CreditRating { get; set; } // CreditRating

        ///<summary>
        /// 0 = Do not use if another vendor is available. 1 = Preferred over other vendors supplying the same product.
        ///</summary>
        public bool PreferredVendorStatus { get; set; } // PreferredVendorStatus

        ///<summary>
        /// 0 = Vendor no longer used. 1 = Vendor is actively used.
        ///</summary>
        public bool ActiveFlag { get; set; } // ActiveFlag

        ///<summary>
        /// Vendor URL.
        ///</summary>
        public string PurchasingWebServiceUrl { get; set; } // PurchasingWebServiceURL

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Purchasing_ProductVendor> Purchasing_ProductVendors { get; set; } // Many to many mapping
        public virtual ICollection<Purchasing_PurchaseOrderHeader> Purchasing_PurchaseOrderHeaders { get; set; } // PurchaseOrderHeader.FK_PurchaseOrderHeader_Vendor_VendorID

        // Foreign keys
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Vendor_BusinessEntity_BusinessEntityID
        
        public Purchasing_Vendor()
        {
            PreferredVendorStatus = true;
            ActiveFlag = true;
            ModifiedDate = System.DateTime.Now;
            Purchasing_ProductVendors = new List<Purchasing_ProductVendor>();
            Purchasing_PurchaseOrderHeaders = new List<Purchasing_PurchaseOrderHeader>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
