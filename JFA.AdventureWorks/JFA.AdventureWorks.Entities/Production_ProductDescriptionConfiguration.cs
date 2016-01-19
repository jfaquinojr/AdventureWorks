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
    // ProductDescription
    public partial class Production_ProductDescriptionConfiguration : EntityTypeConfiguration<Production_ProductDescription>
    {
        public Production_ProductDescriptionConfiguration()
            : this("Production")
        {
        }
 
        public Production_ProductDescriptionConfiguration(string schema)
        {
            ToTable(schema + ".ProductDescription");
            HasKey(x => x.ProductDescriptionId);

            Property(x => x.ProductDescriptionId).HasColumnName("ProductDescriptionID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Description).HasColumnName("Description").IsRequired().HasColumnType("nvarchar").HasMaxLength(400);
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>