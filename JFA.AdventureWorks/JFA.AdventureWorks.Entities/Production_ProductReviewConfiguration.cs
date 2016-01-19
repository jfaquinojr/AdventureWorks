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
    // ProductReview
    public partial class Production_ProductReviewConfiguration : EntityTypeConfiguration<Production_ProductReview>
    {
        public Production_ProductReviewConfiguration()
            : this("Production")
        {
        }
 
        public Production_ProductReviewConfiguration(string schema)
        {
            ToTable(schema + ".ProductReview");
            HasKey(x => x.ProductReviewId);

            Property(x => x.ProductReviewId).HasColumnName("ProductReviewID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int");
            Property(x => x.ReviewerName).HasColumnName("ReviewerName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ReviewDate).HasColumnName("ReviewDate").IsRequired().HasColumnType("datetime");
            Property(x => x.EmailAddress).HasColumnName("EmailAddress").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Rating).HasColumnName("Rating").IsRequired().HasColumnType("int");
            Property(x => x.Comments).HasColumnName("Comments").IsOptional().HasColumnType("nvarchar").HasMaxLength(3850);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Production_Product).WithMany(b => b.Production_ProductReviews).HasForeignKey(c => c.ProductId); // FK_ProductReview_Product_ProductID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>