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
    // ProductListPriceHistory
    public partial class Production_ProductListPriceHistoryConfiguration : EntityTypeConfiguration<Production_ProductListPriceHistory>
    {
        public Production_ProductListPriceHistoryConfiguration()
            : this("Production")
        {
        }
 
        public Production_ProductListPriceHistoryConfiguration(string schema)
        {
            ToTable(schema + ".ProductListPriceHistory");
            HasKey(x => new { x.ProductId, x.StartDate });

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired().HasColumnType("datetime").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.EndDate).HasColumnName("EndDate").IsOptional().HasColumnType("datetime");
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductListPriceHistories).HasForeignKey(c => c.ProductId); // FK_ProductListPriceHistory_Product_ProductID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>