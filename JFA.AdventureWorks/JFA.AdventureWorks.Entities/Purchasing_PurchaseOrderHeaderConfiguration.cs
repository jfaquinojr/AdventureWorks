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
    public partial class Purchasing_PurchaseOrderHeaderConfiguration : EntityTypeConfiguration<Purchasing_PurchaseOrderHeader>
    {
        public Purchasing_PurchaseOrderHeaderConfiguration()
            : this("Purchasing")
        {
        }
 
        public Purchasing_PurchaseOrderHeaderConfiguration(string schema)
        {
            ToTable(schema + ".PurchaseOrderHeader");
            HasKey(x => x.PurchaseOrderId);

            Property(x => x.PurchaseOrderId).HasColumnName("PurchaseOrderID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.RevisionNumber).HasColumnName("RevisionNumber").IsRequired().HasColumnType("tinyint");
            Property(x => x.Status).HasColumnName("Status").IsRequired().HasColumnType("tinyint");
            Property(x => x.EmployeeId).HasColumnName("EmployeeID").IsRequired().HasColumnType("int");
            Property(x => x.VendorId).HasColumnName("VendorID").IsRequired().HasColumnType("int");
            Property(x => x.ShipMethodId).HasColumnName("ShipMethodID").IsRequired().HasColumnType("int");
            Property(x => x.OrderDate).HasColumnName("OrderDate").IsRequired().HasColumnType("datetime");
            Property(x => x.ShipDate).HasColumnName("ShipDate").IsOptional().HasColumnType("datetime");
            Property(x => x.SubTotal).HasColumnName("SubTotal").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.TaxAmt).HasColumnName("TaxAmt").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.Freight).HasColumnName("Freight").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.TotalDue).HasColumnName("TotalDue").IsRequired().HasColumnType("money").HasPrecision(19,4).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.HumanResources_Employee).WithMany(b => b.Purchasing_PurchaseOrderHeaders).HasForeignKey(c => c.EmployeeId); // FK_PurchaseOrderHeader_Employee_EmployeeID
            HasRequired(a => a.Purchasing_ShipMethod).WithMany(b => b.Purchasing_PurchaseOrderHeaders).HasForeignKey(c => c.ShipMethodId); // FK_PurchaseOrderHeader_ShipMethod_ShipMethodID
            HasRequired(a => a.Purchasing_Vendor).WithMany(b => b.Purchasing_PurchaseOrderHeaders).HasForeignKey(c => c.VendorId); // FK_PurchaseOrderHeader_Vendor_VendorID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
