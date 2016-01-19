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
    // Product
    public partial class Production_ProductConfiguration : EntityTypeConfiguration<Production_Product>
    {
        public Production_ProductConfiguration()
            : this("Production")
        {
        }
 
        public Production_ProductConfiguration(string schema)
        {
            ToTable(schema + ".Product");
            HasKey(x => x.ProductId);

            Property(x => x.ProductId).HasColumnName("ProductID").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProductNumber).HasColumnName("ProductNumber").IsRequired().HasColumnType("nvarchar").HasMaxLength(25);
            Property(x => x.MakeFlag).HasColumnName("MakeFlag").IsRequired().HasColumnType("bit");
            Property(x => x.FinishedGoodsFlag).HasColumnName("FinishedGoodsFlag").IsRequired().HasColumnType("bit");
            Property(x => x.Color).HasColumnName("Color").IsOptional().HasColumnType("nvarchar").HasMaxLength(15);
            Property(x => x.SafetyStockLevel).HasColumnName("SafetyStockLevel").IsRequired().HasColumnType("smallint");
            Property(x => x.ReorderPoint).HasColumnName("ReorderPoint").IsRequired().HasColumnType("smallint");
            Property(x => x.StandardCost).HasColumnName("StandardCost").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.ListPrice).HasColumnName("ListPrice").IsRequired().HasColumnType("money").HasPrecision(19,4);
            Property(x => x.Size).HasColumnName("Size").IsOptional().HasColumnType("nvarchar").HasMaxLength(5);
            Property(x => x.SizeUnitMeasureCode).HasColumnName("SizeUnitMeasureCode").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(3);
            Property(x => x.WeightUnitMeasureCode).HasColumnName("WeightUnitMeasureCode").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(3);
            Property(x => x.Weight).HasColumnName("Weight").IsOptional().HasColumnType("decimal").HasPrecision(8,2);
            Property(x => x.DaysToManufacture).HasColumnName("DaysToManufacture").IsRequired().HasColumnType("int");
            Property(x => x.ProductLine).HasColumnName("ProductLine").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(2);
            Property(x => x.Class).HasColumnName("Class").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(2);
            Property(x => x.Style).HasColumnName("Style").IsOptional().IsFixedLength().HasColumnType("nchar").HasMaxLength(2);
            Property(x => x.ProductSubcategoryId).HasColumnName("ProductSubcategoryID").IsOptional().HasColumnType("int");
            Property(x => x.ProductModelId).HasColumnName("ProductModelID").IsOptional().HasColumnType("int");
            Property(x => x.SellStartDate).HasColumnName("SellStartDate").IsRequired().HasColumnType("datetime");
            Property(x => x.SellEndDate).HasColumnName("SellEndDate").IsOptional().HasColumnType("datetime");
            Property(x => x.DiscontinuedDate).HasColumnName("DiscontinuedDate").IsOptional().HasColumnType("datetime");
            Property(x => x.Rowguid).HasColumnName("rowguid").IsRequired().HasColumnType("uniqueidentifier");
            Property(x => x.ModifiedDate).HasColumnName("ModifiedDate").IsRequired().HasColumnType("datetime");

            // Foreign keys
            HasOptional(a => a.Production_ProductModel).WithMany(b => b.Production_Products).HasForeignKey(c => c.ProductModelId); // FK_Product_ProductModel_ProductModelID
            HasOptional(a => a.Production_ProductSubcategory).WithMany(b => b.Production_Products).HasForeignKey(c => c.ProductSubcategoryId); // FK_Product_ProductSubcategory_ProductSubcategoryID
            HasOptional(a => a.Production_UnitMeasure_SizeUnitMeasureCode).WithMany(b => b.Production_Products_SizeUnitMeasureCode).HasForeignKey(c => c.SizeUnitMeasureCode); // FK_Product_UnitMeasure_SizeUnitMeasureCode
            HasOptional(a => a.Production_UnitMeasure_WeightUnitMeasureCode).WithMany(b => b.Production_Products_WeightUnitMeasureCode).HasForeignKey(c => c.WeightUnitMeasureCode); // FK_Product_UnitMeasure_WeightUnitMeasureCode
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
// </auto-generated>
