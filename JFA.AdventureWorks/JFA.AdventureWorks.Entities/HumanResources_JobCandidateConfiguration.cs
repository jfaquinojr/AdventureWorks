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
    // JobCandidate
    public partial class HumanResources_JobCandidateConfiguration : EntityTypeConfiguration<HumanResources_JobCandidate>
    {
        public HumanResources_JobCandidateConfiguration()
            : this("HumanResources")
        {
        }
 
        public HumanResources_JobCandidateConfiguration(string schema)
        {
            ToTable(schema + ".JobCandidate");
            HasKey(x => x.JobCandidateId);

            Property(x => x.JobCandidateId).HasColumnName("JobCandidateID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.BusinessEntityId).HasColumnName("BusinessEntityID").IsOptional().HasColumnType("int");
            Property(x => x.Resume).HasColumnName("Resume").IsOptional().HasColumnType("xml");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasOptional(a => a.HumanResources_Employee).WithMany(b => b.HumanResources_JobCandidates).HasForeignKey(c => c.BusinessEntityId); // FK_JobCandidate_Employee_BusinessEntityID
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>