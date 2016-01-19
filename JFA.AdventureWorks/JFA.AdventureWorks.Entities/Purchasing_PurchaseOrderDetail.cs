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
    // PurchaseOrderDetail
    public partial class Purchasing_PurchaseOrderDetail
    {

        ///<summary>
        /// Primary key. Foreign key to PurchaseOrderHeader.PurchaseOrderID.
        ///</summary>
        public int PurchaseOrderId { get; set; } // PurchaseOrderID (Primary key)

        ///<summary>
        /// Primary key. One line number per purchased product.
        ///</summary>
        public int PurchaseOrderDetailId { get; set; } // PurchaseOrderDetailID (Primary key)

        ///<summary>
        /// Date the product is expected to be received.
        ///</summary>
        public DateTime DueDate { get; set; } // DueDate

        ///<summary>
        /// Quantity ordered.
        ///</summary>
        public short OrderQty { get; set; } // OrderQty

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId { get; set; } // ProductID

        ///<summary>
        /// Vendor's selling price of a single product.
        ///</summary>
        public decimal UnitPrice { get; set; } // UnitPrice

        ///<summary>
        /// Per product subtotal. Computed as OrderQty * UnitPrice.
        ///</summary>
        public decimal LineTotal { get; set; } // LineTotal

        ///<summary>
        /// Quantity actually received from the vendor.
        ///</summary>
        public decimal ReceivedQty { get; set; } // ReceivedQty

        ///<summary>
        /// Quantity rejected during inspection.
        ///</summary>
        public decimal RejectedQty { get; set; } // RejectedQty

        ///<summary>
        /// Quantity accepted into inventory. Computed as ReceivedQty - RejectedQty.
        ///</summary>
        public decimal StockedQty { get; set; } // StockedQty

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Product Production_Product { get; set; } // FK_PurchaseOrderDetail_Product_ProductID
        public virtual Purchasing_PurchaseOrderHeader Purchasing_PurchaseOrderHeader { get; set; } // FK_PurchaseOrderDetail_PurchaseOrderHeader_PurchaseOrderID
        
        public Purchasing_PurchaseOrderDetail()
        {
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
