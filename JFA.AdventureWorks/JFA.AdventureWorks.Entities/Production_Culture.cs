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
    // Culture
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Production_Culture
    {

        ///<summary>
        /// Primary key for Culture records.
        ///</summary>
        public string CultureId { get; set; } // CultureID (Primary key)

        ///<summary>
        /// Culture description.
        ///</summary>
        public string Name { get; set; } // Name

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_ProductModelProductDescriptionCulture> Production_ProductModelProductDescriptionCultures { get; set; } // Many to many mapping
        
        public Production_Culture()
        {
            ModifiedDate = System.DateTime.Now;
            Production_ProductModelProductDescriptionCultures = new List<Production_ProductModelProductDescriptionCulture>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>