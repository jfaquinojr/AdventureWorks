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
    // vEmployeeDepartment
    public partial class HumanResources_VEmployeeDepartmentConfiguration : EntityTypeConfiguration<HumanResources_VEmployeeDepartment>
    {
        public HumanResources_VEmployeeDepartmentConfiguration()
            : this("HumanResources")
        {
        }
 
        public HumanResources_VEmployeeDepartmentConfiguration(string schema)
        {
            ToTable(schema + ".vEmployeeDepartment");
            HasKey(x => new { x.BusinessEntityId, x.FirstName, x.LastName, x.JobTitle, x.Department, x.GroupName, x.StartDate });

            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsRequired().HasColumnType("int");
            Property(x => x.Title).HasColumnName("Title").IsOptional().HasColumnType("nvarchar").HasMaxLength(8);
            Property(x => x.FirstName).HasColumnName("FirstName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.MiddleName).HasColumnName("MiddleName").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LastName).HasColumnName("LastName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Suffix).HasColumnName("Suffix").IsOptional().HasColumnType("nvarchar").HasMaxLength(10);
            Property(x => x.JobTitle).HasColumnName("JobTitle").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.Department).HasColumnName("Department").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.GroupName).HasColumnName("GroupName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.StartDate).HasColumnName("StartDate").IsRequired().HasColumnType("date");
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
