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
    // CreditCard
    public partial class Sales_CreditCardConfiguration : EntityTypeConfiguration<Sales_CreditCard>
    {
        public Sales_CreditCardConfiguration()
            : this("Sales")
        {
        }
 
        public Sales_CreditCardConfiguration(string schema)
        {
            ToTable(schema + ".CreditCard");
            HasKey(x => x.CreditCardId);

            Property(x => x.CreditCardId).HasColumnName("CreditCardID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.CardType).HasColumnName("CardType").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CardNumber).HasColumnName("CardNumber").IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            Property(x => x.ExpMonth).HasColumnName("ExpMonth").IsRequired().HasColumnType("tinyint");
            Property(x => x.ExpYear).HasColumnName("ExpYear").IsRequired().HasColumnType("smallint");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>