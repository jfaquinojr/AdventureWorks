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
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Threading;

namespace JFA.AdventureWorks.Entities
{
    public partial class AwBuildVersion
    {

        ///<summary>
        /// Primary key for AWBuildVersion records.
        ///</summary>
        public byte SystemInformationId { get; set; }

        ///<summary>
        /// Version number of the database in 9.yy.mm.dd.00 format.
        ///</summary>
        public string DatabaseVersion { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime VersionDate { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; }
        
        public AwBuildVersion()
        {
            ModifiedDate = System.DateTime.Now;
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
