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
    // Person
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Person_Person
    {

        ///<summary>
        /// Primary key for Person records.
        ///</summary>
        public int BusinessEntityId { get; set; } // BusinessEntityID (Primary key)

        ///<summary>
        /// Primary type of person: SC = Store Contact, IN = Individual (retail) customer, SP = Sales person, EM = Employee (non-sales), VC = Vendor contact, GC = General contact
        ///</summary>
        public string PersonType { get; set; } // PersonType

        ///<summary>
        /// 0 = The data in FirstName and LastName are stored in western style (first name, last name) order.  1 = Eastern style (last name, first name) order.
        ///</summary>
        public bool NameStyle { get; set; } // NameStyle

        ///<summary>
        /// A courtesy title. For example, Mr. or Ms.
        ///</summary>
        public string Title { get; set; } // Title

        ///<summary>
        /// First name of the person.
        ///</summary>
        public string FirstName { get; set; } // FirstName

        ///<summary>
        /// Middle name or middle initial of the person.
        ///</summary>
        public string MiddleName { get; set; } // MiddleName

        ///<summary>
        /// Last name of the person.
        ///</summary>
        public string LastName { get; set; } // LastName

        ///<summary>
        /// Surname suffix. For example, Sr. or Jr.
        ///</summary>
        public string Suffix { get; set; } // Suffix

        ///<summary>
        /// 0 = Contact does not wish to receive e-mail promotions, 1 = Contact does wish to receive e-mail promotions from AdventureWorks, 2 = Contact does wish to receive e-mail promotions from AdventureWorks and selected partners.
        ///</summary>
        public int EmailPromotion { get; set; } // EmailPromotion

        ///<summary>
        /// Additional contact information about the person stored in xml format.
        ///</summary>
        public string AdditionalContactInfo { get; set; } // AdditionalContactInfo

        ///<summary>
        /// Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
        ///</summary>
        public string Demographics { get; set; } // Demographics

        ///<summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        ///</summary>
        public Guid Rowguid { get; set; } // rowguid

        ///<summary>
        /// Date and time the record was last updated.
        ///</summary>
        public DateTime ModifiedDate { get; set; } // ModifiedDate

        // Reverse navigation
        public virtual HumanResources_Employee HumanResources_Employee { get; set; } // Employee.FK_Employee_Person_BusinessEntityID
        public virtual ICollection<Person_BusinessEntityContact> Person_BusinessEntityContacts { get; set; } // Many to many mapping
        public virtual ICollection<Person_EmailAddress> Person_EmailAddresses { get; set; } // Many to many mapping
        public virtual ICollection<Person_PersonPhone> Person_PersonPhones { get; set; } // Many to many mapping
        public virtual ICollection<Sales_Customer> Sales_Customers { get; set; } // Customer.FK_Customer_Person_PersonID
        public virtual ICollection<Sales_PersonCreditCard> Sales_PersonCreditCards { get; set; } // Many to many mapping
        public virtual Person_Password Person_Password { get; set; } // Password.FK_Password_Person_BusinessEntityID

        // Foreign keys
        public virtual Person_BusinessEntity Person_BusinessEntity { get; set; } // FK_Person_BusinessEntity_BusinessEntityID
        
        public Person_Person()
        {
            NameStyle = false;
            EmailPromotion = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Person_BusinessEntityContacts = new List<Person_BusinessEntityContact>();
            Sales_Customers = new List<Sales_Customer>();
            Person_EmailAddresses = new List<Person_EmailAddress>();
            Sales_PersonCreditCards = new List<Sales_PersonCreditCard>();
            Person_PersonPhones = new List<Person_PersonPhone>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
