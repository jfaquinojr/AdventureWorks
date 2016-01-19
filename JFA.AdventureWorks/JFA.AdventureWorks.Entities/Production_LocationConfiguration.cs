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
    // Location
    public partial class Production_LocationConfiguration : EntityTypeConfiguration<Production_Location>
    {
        public Production_LocationConfiguration()
            : this("Production")
        {
        }
 
        public Production_LocationConfiguration(string schema)
        {
            ToTable(schema + ".Location");
            HasKey(x => x.LocationId);

            Property(x => x.LocationId).HasColumnName("LocationID").IsRequired().HasColumnType("smallint").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.CostRate).HasColumnName("CostRate").IsRequired().HasColumnType("smallmoney").HasPrecision(10,4);
            Property(x => x.Availability).HasColumnName("Availability").IsRequired().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>