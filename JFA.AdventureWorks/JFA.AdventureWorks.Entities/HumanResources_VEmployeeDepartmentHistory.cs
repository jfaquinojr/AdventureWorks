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
    // vEmployeeDepartmentHistory
    public partial class HumanResources_VEmployeeDepartmentHistory
    {
        public int BusinessEntityId { get; set; } // BusinessEntityID
        public string Title { get; set; } // Title
        public string FirstName { get; set; } // FirstName
        public string MiddleName { get; set; } // MiddleName
        public string LastName { get; set; } // LastName
        public string Suffix { get; set; } // Suffix
        public string Shift { get; set; } // Shift
        public string Department { get; set; } // Department
        public string GroupName { get; set; } // GroupName
        public DateTime StartDate { get; set; } // StartDate
        public DateTime? EndDate { get; set; } // EndDate
        
        public HumanResources_VEmployeeDepartmentHistory()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>