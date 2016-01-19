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
    // vStoreWithAddresses
    public partial class Sales_VStoreWithAddressConfiguration : EntityTypeConfiguration<Sales_VStoreWithAddress>
    {
        public Sales_VStoreWithAddressConfiguration()
            : this("Sales")
        {
        }
 
        public Sales_VStoreWithAddressConfiguration(string schema)
        {
            ToTable(schema + ".vStoreWithAddresses");
            HasKey(x => new { x.BusinessEntityId, x.Name, x.AddressType, x.AddressLine1, x.City, x.StateProvinceName, x.PostalCode, x.CountryRegionName });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasColumnType("int");
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AddressType).HasColumnName("AddressType").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.AddressLine1).HasColumnName("AddressLine1").IsRequired().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.AddressLine2).HasColumnName("AddressLine2").IsOptional().HasColumnType("nvarchar").HasMaxLength(60);
            Property(x => x.City).HasColumnName("City").IsRequired().HasColumnType("nvarchar").HasMaxLength(30);
            Property(x => x.StateProvinceName).HasColumnName("StateProvinceName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.PostalCode).HasColumnName("PostalCode").IsRequired().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.CountryRegionName).HasColumnName("CountryRegionName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
