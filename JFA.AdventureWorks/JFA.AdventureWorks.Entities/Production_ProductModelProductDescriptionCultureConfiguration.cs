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
    // ProductModelProductDescriptionCulture
    public partial class Production_ProductModelProductDescriptionCultureConfiguration : EntityTypeConfiguration<Production_ProductModelProductDescriptionCulture>
    {
        public Production_ProductModelProductDescriptionCultureConfiguration()
            : this("Production")
        {
        }
 
        public Production_ProductModelProductDescriptionCultureConfiguration(string schema)
        {
            ToTable(schema + ".ProductModelProductDescriptionCulture");
            HasKey(x => new { x.ProductModelId, x.ProductDescriptionId, x.CultureId });

            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.CultureId).HasColumnName("CultureID").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(6).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Production_Culture).WithMany(b => b.Production_ProductModelProductDescriptionCultures).HasForeignKey(c => c.CultureId); // FK_ProductModelProductDescriptionCulture_Culture_CultureID
            HasRequired(a => a.Production_ProductDescription).WithMany(b => b.Production_ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductDescriptionId); // FK_ProductModelProductDescriptionCulture_ProductDescription_ProductDescriptionID
            HasRequired(a => a.Production_ProductModel).WithMany(b => b.Production_ProductModelProductDescriptionCultures).HasForeignKey(c => c.ProductModelId); // FK_ProductModelProductDescriptionCulture_ProductModel_ProductModelID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>