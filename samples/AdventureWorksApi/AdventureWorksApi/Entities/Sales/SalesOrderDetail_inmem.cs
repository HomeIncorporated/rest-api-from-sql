// DISCLAIMER
// This file contains auto generated code.
// Changes to this file may be overwritten when the files are regenerated.
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;

namespace Sales
{
    [Table("SalesOrderDetail_inmem", Schema = "Sales")]
    public class SalesOrderDetail_inmem
    {
		[Column("SalesOrderID")]
		public int SalesOrderID { get; set; }
		[Column("SalesOrderDetailID")]
		public long SalesOrderDetailID { get; set; }
		[Column("CarrierTrackingNumber")]
		public string CarrierTrackingNumber { get; set; }
		[Column("OrderQty")]
		public short OrderQty { get; set; }
		[Column("ProductID")]
		public int ProductID { get; set; }
		[Column("SpecialOfferID")]
		public int SpecialOfferID { get; set; }
		[Column("UnitPrice")]
		public decimal UnitPrice { get; set; }
		[Column("UnitPriceDiscount")]
		public decimal UnitPriceDiscount { get; set; }
		[Column("ModifiedDate")]
		public DateTime ModifiedDate { get; set; }

	}
}