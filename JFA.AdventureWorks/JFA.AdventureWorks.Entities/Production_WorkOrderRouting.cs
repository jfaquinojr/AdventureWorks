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
    // WorkOrderRouting
    public partial class Production_WorkOrderRouting
    {

        ///<summary>
        /// Primary key. Foreign key to WorkOrder.WorkOrderID.
        ///</summary>
        public int WorkOrderId { get; set; } // WorkOrderID (Primary key)

        ///<summary>
        /// Primary key. Foreign key to Product.ProductID.
        ///</summary>
        public int ProductId { get; set; } // ProductID (Primary key)

        ///<summary>
        /// Primary key. Indicates the manufacturing process sequence.
        ///</summary>
        public short OperationSequence { get; set; } // OperationSequence (Primary key)

        ///<summary>
        /// Manufacturing location where the part is processed. Foreign key to Location.LocationID.
        ///</summary>
        public short LocationId { get; set; } // LocationID

        ///<summary>
        /// Planned manufacturing start date.
        ///</summary>
        public DateTime ScheduledStartDate { get; set; } // ScheduledStartDate

        ///<summary>
        /// Planned manufacturing end date.
        ///</summary>
        public DateTime ScheduledEndDate { get; set; } // ScheduledEndDate

        ///<summary>
        /// Actual start date.
        ///</summary>
        public DateTime? ActualStartDate { get; set; } // ActualStartDate

        ///<summary>
        /// Actual end date.
        ///</summary>
        public DateTime? ActualEndDate { get; set; } // ActualEndDate

        ///<summary>
        /// Number of manufacturing hours used.
        ///</summary>
        public decimal? ActualResourceHrs { get; set; } // ActualResourceHrs

        ///<summary>
        /// Estimated manufacturing cost.
        ///</summary>
        public decimal PlannedCost { get; set; } // PlannedCost

        ///<summary>
        /// Actual manufacturing cost.
        ///</summary>
        public decimal? ActualCost { get; set; } // ActualCost

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Production_Location Production_Location { get; set; } // FK_WorkOrderRouting_Location_LocationID
        public virtual Production_WorkOrder Production_WorkOrder { get; set; } // FK_WorkOrderRouting_WorkOrder_WorkOrderID
        
        public Production_WorkOrderRouting()
        {
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>