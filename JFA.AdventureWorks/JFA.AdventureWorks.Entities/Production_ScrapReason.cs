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
    // ScrapReason
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Production_ScrapReason
    {

        ///<summary>
        /// Primary key for ScrapReason records.
        ///</summary>
        public short ScrapReasonId { get; set; } // ScrapReasonID (Primary key)

        ///<summary>
        /// Failure description.
        ///</summary>
        public string Name { get; set; } // Name

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual ICollection<Production_WorkOrder> Production_WorkOrders { get; set; } // WorkOrder.FK_WorkOrder_ScrapReason_ScrapReasonID
        
        public Production_ScrapReason()
        {
            ModifiedDate = System.DateTime.Now;
            Production_WorkOrders = new List<Production_WorkOrder>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
