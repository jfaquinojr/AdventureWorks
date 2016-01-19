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
    // StateProvince
    public partial class Person_StateProvinceConfiguration : EntityTypeConfiguration<Person_StateProvince>
    {
        public Person_StateProvinceConfiguration()
            : this("Person")
        {
        }
 
        public Person_StateProvinceConfiguration(string schema)
        {
            ToTable(schema + ".StateProvince");
            HasKey(x => x.StateProvinceId);

            Property(x => x.StateProvinceId).HasColumnName("StateProvinceID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.StateProvinceCode).HasColumnName("StateProvinceCode").IsRequired().IsFixedLength().HasColumnType("nchar").HasMaxLength(3);
            Property(x => x.CountryRegionCode).HasColumnName("CountryRegionCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(3);
            Property(x => x.IsOnlyStateProvinceFlag).HasColumnName("IsOnlyStateProvinceFlag").IsRequired().HasColumnType("bit");
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.TerritoryId).HasColumnName("TerritoryID").IsRequired().HasColumnType("int");
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasRequired(a => a.Person_CountryRegion).WithMany(b => b.Person_StateProvinces).HasForeignKey(c => c.CountryRegionCode); // FK_StateProvince_CountryRegion_CountryRegionCode
            HasRequired(a => a.Sales_SalesTerritory).WithMany(b => b.Person_StateProvinces).HasForeignKey(c => c.TerritoryId); // FK_StateProvince_SalesTerritory_TerritoryID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>