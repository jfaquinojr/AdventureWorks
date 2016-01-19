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
    // ProductInventory
    public partial class Production_ProductInventory
    {

        ///<summary>
        /// Product identification number. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Inventory location identification number. Foreign key to Location.LocationID.
        ///</summary>
        public short LocationId { get; set; } // LocationID (Primary key)

        ///<summary>
        /// Storage compartment within an inventory location.
        ///</summary>
        public string Shelf { get; set; } // Shelf

        ///<summary>
        /// Storage container on a shelf in an inventory location.
        ///</summary>
        public byte Bin { get; set; } // Bin

        ///<summary>
        /// Quantity of products in the inventory location.
        ///</summary>
        public short Quantity { get; set; } // Quantity

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Location Production_Location { get; set; } // FK_ProductInventory_Location_LocationID
        public virtual Production_Product Production_Product { get; set; } // FK_ProductInventory_Product_ProductID
        
        public Production_ProductInventory()
        {
            Quantity = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
