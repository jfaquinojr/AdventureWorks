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
    // TransactionHistory
    public partial class Production_TransactionHistoryConfiguration : EntityTypeConfiguration<Production_TransactionHistory>
    {
        public Production_TransactionHistoryConfiguration()
            : this("Production")
        {
        }
 
        public Production_TransactionHistoryConfiguration(string schema)
        {
            ToTable(schema + ".TransactionHistory");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int");
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired().HasColumnType("int");
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired().HasColumnType("int");
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired().HasColumnType("datetime");
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired().HasColumnType("int");
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_TransactionHistories).HasForeignKey(c => c.ProductId); // FK_TransactionHistory_Product_ProductID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
