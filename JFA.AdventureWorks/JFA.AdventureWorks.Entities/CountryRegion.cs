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
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class CountryRegion
    {

        ///<summary>
        /// ISO standard code for countries and regions.
        ///</summary>
        public string CountryRegionCode { get; set; }

        ///<summary>
        /// Country or region name.
        ///</summary>
        public string Name { get; set; }

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        public virtual ICollection<SalesTerritory> SalesTerritories { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        
        public CountryRegion()
        {
            ModifiedDate = System.DateTime.Now;
            CountryRegionCurrencies = new List<CountryRegionCurrency>();
            SalesTerritories = new List<SalesTerritory>();
            StateProvinces = new List<StateProvince>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>