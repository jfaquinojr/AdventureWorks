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
    // PersonCreditCard
    public partial class Sales_PersonCreditCard
    {

        ///<summary>
        /// Business entity identification number. Foreign key to Person.BusinessEntityID.
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Credit card identification number. Foreign key to CreditCard.CreditCardID.
        ///</summary>
        public int CreditCardId { get; set; } // CreditCardID (Primary key)

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Foreign keys
        public virtual Person_Person Person_Person { get; set; } // FK_PersonCreditCard_Person_BusinessEntityID
        public virtual Sales_CreditCard Sales_CreditCard { get; set; } // FK_PersonCreditCard_CreditCard_CreditCardID
        
        public Sales_PersonCreditCard()
        {
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
