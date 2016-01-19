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
    // PurchaseOrderHeader
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Purchasing_PurchaseOrderHeader
    {

        ///<summary>
        /// Primary key.
        ///</summary>
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key)

        ///<summary>
        /// Incremental number to track changes to the purchase order over time.
        ///</summary>
        public byte RevisionNumber { get; set; } // RevisionNumber

        ///<summary>
        /// Order current status. 1 = Pending; 2 = Approved; 3 = Rejected; 4 = Complete
        ///</summary>
        public byte Status { get; set; } // Status

        ///<summary>
        /// Employee who created the purchase order. Foreign key to Employee.BusinessEntityID.
        ///</summary>
        public int EmployeeId { get; set; } // EmployeeID

        ///<summary>
        /// Vendor with whom the purchase order is placed. Foreign key to Vendor.BusinessEntityID.
        ///</summary>
        public int VendorId { get; set; } // VendorID

        ///<summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        ///</summary>
        public int ShipMethodId { get; set; } // ShipMethodID

        ///<summary>
        /// Purchase order creation date.
        ///</summary>
        public DateTime OrderDate { get; set; } // OrderDate

        ///<summary>
        /// Estimated shipment date from the vendor.
        ///</summary>
        public DateTime? ShipDate { get; set; } // ShipDate

        ///<summary>
        /// Purchase order subtotal. Computed as SUM(PurchaseOrderDetail.LineTotal)for the appropriate PurchaseOrderID.
        ///</summary>
        public decimal SubTotal { get; set; } // SubTotal

        ///<summary>
        /// Tax amount.
        ///</summary>
        public decimal TaxAmt { get; set; } // TaxAmt

        ///<summary>
        /// Shipping cost.
        ///</summary>
        public decimal Freight { get; set; } // Freight

        ///<summary>
        /// Total due to vendor. Computed as Subtotal + TaxAmt + Freight.
        ///</summary>
        public decimal TotalDue { get; set; } // TotalDue

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Purchasing_PurchaseOrderDetail> Purchasing_PurchaseOrderDetails { get; set; } // Many to many mapping

        // Foreign keys
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // FK_PurchaseOrderHeader_Employee_EmployeeID
        public virtual Purchasing_ShipMethod Purchasing_ShipMethod { get; set; } // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
        public virtual Purchasing_Vendor Purchasing_Vendor { get; set; } // FK_PurchaseOrderHeader_Vendor_VendorID
        
        public Purchasing_PurchaseOrderHeader()
        {
            RevisionNumber = 0;
            Status = 1;
            OrderDate = System.DateTime.Now;
            SubTotal = 0.00m;
            TaxAmt = 0.00m;
            Freight = 0.00m;
            ModifiedDate = System.DateTime.Now;
            Purchasing_PurchaseOrderDetails = new List<Purchasing_PurchaseOrderDetail>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
