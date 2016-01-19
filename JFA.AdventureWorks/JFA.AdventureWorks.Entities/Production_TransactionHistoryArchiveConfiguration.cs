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
    // TransactionHistoryArchive
    public partial class Production_TransactionHistoryArchiveConfiguration : EntityTypeConfiguration<Production_TransactionHistoryArchive>
    {
        public Production_TransactionHistoryArchiveConfiguration()
            : this("Production")
        {
        }
 
        public Production_TransactionHistoryArchiveConfiguration(string schema)
        {
            ToTable(schema + ".TransactionHistoryArchive");
            HasKey(x => x.TransactionId);

            Property(x => x.TransactionId).HasColumnName("TransactionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int");
            Property(x => x.ReferenceOrderId).HasColumnName("ReferenceOrderID").IsRequired().HasColumnType("int");
            Property(x => x.ReferenceOrderLineId).HasColumnName("ReferenceOrderLineID").IsRequired().HasColumnType("int");
            Property(x => x.TransactionDate).HasColumnName("TransactionDate").IsRequired().HasColumnType("datetime");
            Property(x => x.TransactionType).HasColumnName("TransactionType").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(1);
            Property(x => x.Quantity).HasColumnName("Quantity").IsRequired().HasColumnType("int");
            Property(x => x.ActualCost).HasColumnName("ActualCost").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>