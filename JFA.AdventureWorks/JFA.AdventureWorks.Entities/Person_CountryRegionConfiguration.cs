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
    // CountryRegion
    public partial class Person_CountryRegionConfiguration : EntityTypeConfiguration<Person_CountryRegion>
    {
        public Person_CountryRegionConfiguration()
            : this("Person")
        {
        }
 
        public Person_CountryRegionConfiguration(string schema)
        {
            ToTable(schema + ".CountryRegion");
            HasKey(x => x.CountryRegionCode);

            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(3).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
