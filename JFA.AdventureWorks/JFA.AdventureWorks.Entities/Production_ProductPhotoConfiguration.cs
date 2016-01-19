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
    // ProductPhoto
    public partial class Production_ProductPhotoConfiguration : EntityTypeConfiguration<Production_ProductPhoto>
    {
        public Production_ProductPhotoConfiguration()
            : this("Production")
        {
        }
 
        public Production_ProductPhotoConfiguration(string schema)
        {
            ToTable(schema + ".ProductPhoto");
            HasKey(x => x.ProductPhotoId);

            Property(x => x.ProductPhotoId).HasColumnName("ProductPhotoID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ThumbNailPhoto).HasColumnName("ThumbNailPhoto").IsOptional().HasColumnType("varbinary");
            Property(x => x.ThumbnailPhotoFileName).HasColumnName("ThumbnailPhotoFileName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LargePhoto).HasColumnName("LargePhoto").IsOptional().HasColumnType("varbinary");
            Property(x => x.LargePhotoFileName).HasColumnName("LargePhotoFileName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
