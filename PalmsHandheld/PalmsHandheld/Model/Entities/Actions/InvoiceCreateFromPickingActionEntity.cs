//// Warning: Do not modify!
//// This file (InvoiceCreateFromPickingActionEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Tuesday, May 12, 2015' at '4:16:56 PM'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Actions
{
	[Serializable]
	public partial class InvoiceCreateFromPickingActionEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, PrimaryCompanyID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, InvoiceType
			, CustomerID
			, IsFOC
			, TotalOfLineAmountsInCustomerCurrency
			, FreightAmountInCustomerCurrency
			, InsuranceAmountInCustomerCurrency
			, AdditionalCharges1InCustomerCurrency
			, AdditionalCharges2InCustomerCurrency
			, AdditionalCharges3InCustomerCurrency
			, TotalLineChargeAmountInCustomerCurrency
			, ActualFreightChargesInCustomerCurrency
			, TransactionTypeID
			, InvoiceLineNo
			, SalesOrderID
			, SalesOrderLineNo
			, InvoicedPartCostID
			, PackID
			, InvoicedQuantityInStorageUOM
			, UnitSalePriceOfStorageUOMInCustomerCurrency
			, DriverName
			, DriverContactNo
			, VehicleName
			, VehicleNumber
			, BillingUOMID
			, FromLocationID
			, PartBatchID
			, FromPortID
			, ToPortID
			, FreightForwarderID
			, TradeTermID
			, ShippingModeID
			, IsShippedSeparately
			, ShipToID
			, SpecificAddressID
			, SpecificShipToCode
			, FinalDestinationCode
			, CustomerBillToID
			, SpecificBillingAddressID
			, SpecificBillToCode
			, PrimaryCompanyID_PrimaryCompanyName
			, WarehouseID_WarehouseName
			, CostBucketID_CostBucketName
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? primaryCompanyID;
		public int? costBucketID;
		public int? warehousePrimaryCompanyID;
		public int? invoiceType;
		public int? customerID;
		public bool? isFOC;
		public decimal? totalOfLineAmountsInCustomerCurrency;
		public decimal? freightAmountInCustomerCurrency;
		public decimal? insuranceAmountInCustomerCurrency;
		public decimal? additionalCharges1InCustomerCurrency;
		public decimal? additionalCharges2InCustomerCurrency;
		public decimal? additionalCharges3InCustomerCurrency;
		public decimal? totalLineChargeAmountInCustomerCurrency;
		public decimal? actualFreightChargesInCustomerCurrency;
		public int? transactionTypeID;
		public int? invoiceLineNo;
		public int? salesOrderID;
		public int? salesOrderLineNo;
		public int? invoicedPartCostID;
		public int? packID;
		public decimal? invoicedQuantityInStorageUOM;
		public decimal? unitSalePriceOfStorageUOMInCustomerCurrency;
		public string driverName;
		public string driverContactNo;
		public string vehicleName;
		public string vehicleNumber;
		public int? billingUOMID;
		public int? fromLocationID;
		public int? partBatchID;
		public int? fromPortID;
		public int? toPortID;
		public int? freightForwarderID;
		public int? tradeTermID;
		public int? shippingModeID;
		public bool? isShippedSeparately;
		public int? shipToID;
		public int? specificAddressID;
		public string specificShipToCode;
		public string finalDestinationCode;
		public int? customerBillToID;
		public int? specificBillingAddressID;
		public string specificBillToCode;
		public string primaryCompanyID_PrimaryCompanyName;
		public string warehouseID_WarehouseName;
		public string costBucketID_CostBucketName;

		#endregion Members

		#region Overriding / Public Members


		public override int GetFieldCount()
		{
			return (int)Field._FieldCount;
		}

		public override object GetValue(int field)
		{
			return GetValue((Field)field);
		}

		public object GetValue(Field field)
		{
			switch (field)
			{
				case Field.WarehouseID:
					return warehouseID;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.CostBucketID:
					return costBucketID;
				case Field.WarehousePrimaryCompanyID:
					return warehousePrimaryCompanyID;
				case Field.InvoiceType:
					return invoiceType;
				case Field.CustomerID:
					return customerID;
				case Field.IsFOC:
					return isFOC;
				case Field.TotalOfLineAmountsInCustomerCurrency:
					return totalOfLineAmountsInCustomerCurrency;
				case Field.FreightAmountInCustomerCurrency:
					return freightAmountInCustomerCurrency;
				case Field.InsuranceAmountInCustomerCurrency:
					return insuranceAmountInCustomerCurrency;
				case Field.AdditionalCharges1InCustomerCurrency:
					return additionalCharges1InCustomerCurrency;
				case Field.AdditionalCharges2InCustomerCurrency:
					return additionalCharges2InCustomerCurrency;
				case Field.AdditionalCharges3InCustomerCurrency:
					return additionalCharges3InCustomerCurrency;
				case Field.TotalLineChargeAmountInCustomerCurrency:
					return totalLineChargeAmountInCustomerCurrency;
				case Field.ActualFreightChargesInCustomerCurrency:
					return actualFreightChargesInCustomerCurrency;
				case Field.TransactionTypeID:
					return transactionTypeID;
				case Field.InvoiceLineNo:
					return invoiceLineNo;
				case Field.SalesOrderID:
					return salesOrderID;
				case Field.SalesOrderLineNo:
					return salesOrderLineNo;
				case Field.InvoicedPartCostID:
					return invoicedPartCostID;
				case Field.PackID:
					return packID;
				case Field.InvoicedQuantityInStorageUOM:
					return invoicedQuantityInStorageUOM;
				case Field.UnitSalePriceOfStorageUOMInCustomerCurrency:
					return unitSalePriceOfStorageUOMInCustomerCurrency;
				case Field.DriverName:
					return driverName;
				case Field.DriverContactNo:
					return driverContactNo;
				case Field.VehicleName:
					return vehicleName;
				case Field.VehicleNumber:
					return vehicleNumber;
				case Field.BillingUOMID:
					return billingUOMID;
				case Field.FromLocationID:
					return fromLocationID;
				case Field.PartBatchID:
					return partBatchID;
				case Field.FromPortID:
					return fromPortID;
				case Field.ToPortID:
					return toPortID;
				case Field.FreightForwarderID:
					return freightForwarderID;
				case Field.TradeTermID:
					return tradeTermID;
				case Field.ShippingModeID:
					return shippingModeID;
				case Field.IsShippedSeparately:
					return isShippedSeparately;
				case Field.ShipToID:
					return shipToID;
				case Field.SpecificAddressID:
					return specificAddressID;
				case Field.SpecificShipToCode:
					return specificShipToCode;
				case Field.FinalDestinationCode:
					return finalDestinationCode;
				case Field.CustomerBillToID:
					return customerBillToID;
				case Field.SpecificBillingAddressID:
					return specificBillingAddressID;
				case Field.SpecificBillToCode:
					return specificBillToCode;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return primaryCompanyID_PrimaryCompanyName;
				case Field.WarehouseID_WarehouseName:
					return warehouseID_WarehouseName;
				case Field.CostBucketID_CostBucketName:
					return costBucketID_CostBucketName;
			}

			return null;
		}

		public override string GetFieldName(int field)
		{
			return GetFieldName((Field)field);
		}

		public string GetFieldName(Field field)
		{
			return field.ToString();
		}

		public override Type GetType(int field)
		{
			return GetType((Field)field);
		}

		public Type GetType(Field field)
		{
			switch (field)
			{
				case Field.WarehouseID:
					return typeof(int?);
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
				case Field.WarehousePrimaryCompanyID:
					return typeof(int?);
				case Field.InvoiceType:
					return typeof(int?);
				case Field.CustomerID:
					return typeof(int?);
				case Field.IsFOC:
					return typeof(bool?);
				case Field.TotalOfLineAmountsInCustomerCurrency:
					return typeof(decimal?);
				case Field.FreightAmountInCustomerCurrency:
					return typeof(decimal?);
				case Field.InsuranceAmountInCustomerCurrency:
					return typeof(decimal?);
				case Field.AdditionalCharges1InCustomerCurrency:
					return typeof(decimal?);
				case Field.AdditionalCharges2InCustomerCurrency:
					return typeof(decimal?);
				case Field.AdditionalCharges3InCustomerCurrency:
					return typeof(decimal?);
				case Field.TotalLineChargeAmountInCustomerCurrency:
					return typeof(decimal?);
				case Field.ActualFreightChargesInCustomerCurrency:
					return typeof(decimal?);
				case Field.TransactionTypeID:
					return typeof(int?);
				case Field.InvoiceLineNo:
					return typeof(int?);
				case Field.SalesOrderID:
					return typeof(int?);
				case Field.SalesOrderLineNo:
					return typeof(int?);
				case Field.InvoicedPartCostID:
					return typeof(int?);
				case Field.PackID:
					return typeof(int?);
				case Field.InvoicedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.UnitSalePriceOfStorageUOMInCustomerCurrency:
					return typeof(decimal?);
				case Field.DriverName:
					return typeof(string);
				case Field.DriverContactNo:
					return typeof(string);
				case Field.VehicleName:
					return typeof(string);
				case Field.VehicleNumber:
					return typeof(string);
				case Field.BillingUOMID:
					return typeof(int?);
				case Field.FromLocationID:
					return typeof(int?);
				case Field.PartBatchID:
					return typeof(int?);
				case Field.FromPortID:
					return typeof(int?);
				case Field.ToPortID:
					return typeof(int?);
				case Field.FreightForwarderID:
					return typeof(int?);
				case Field.TradeTermID:
					return typeof(int?);
				case Field.ShippingModeID:
					return typeof(int?);
				case Field.IsShippedSeparately:
					return typeof(bool?);
				case Field.ShipToID:
					return typeof(int?);
				case Field.SpecificAddressID:
					return typeof(int?);
				case Field.SpecificShipToCode:
					return typeof(string);
				case Field.FinalDestinationCode:
					return typeof(string);
				case Field.CustomerBillToID:
					return typeof(int?);
				case Field.SpecificBillingAddressID:
					return typeof(int?);
				case Field.SpecificBillToCode:
					return typeof(string);
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return typeof(string);
				case Field.WarehouseID_WarehouseName:
					return typeof(string);
				case Field.CostBucketID_CostBucketName:
					return typeof(string);

			}
			return null;
		}

		public override void SetValue(int field, bool? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, bool? value)
		{
			switch (field)
			{
				case Field.IsFOC:
					isFOC = value;
					break;
				case Field.IsShippedSeparately:
					isShippedSeparately = value;
					break;
				default:
					break;
			}
		}

		public override void SetValue(int field, long? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, long? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, int? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, int? value)
		{
			switch (field)
			{
				case Field.WarehouseID:
					warehouseID = value;
					break;
				case Field.PrimaryCompanyID:
					primaryCompanyID = value;
					break;
				case Field.CostBucketID:
					costBucketID = value;
					break;
				case Field.WarehousePrimaryCompanyID:
					warehousePrimaryCompanyID = value;
					break;
				case Field.InvoiceType:
					invoiceType = value;
					break;
				case Field.CustomerID:
					customerID = value;
					break;
				case Field.TransactionTypeID:
					transactionTypeID = value;
					break;
				case Field.InvoiceLineNo:
					invoiceLineNo = value;
					break;
				case Field.SalesOrderID:
					salesOrderID = value;
					break;
				case Field.SalesOrderLineNo:
					salesOrderLineNo = value;
					break;
				case Field.InvoicedPartCostID:
					invoicedPartCostID = value;
					break;
				case Field.PackID:
					packID = value;
					break;
				case Field.BillingUOMID:
					billingUOMID = value;
					break;
				case Field.FromLocationID:
					fromLocationID = value;
					break;
				case Field.PartBatchID:
					partBatchID = value;
					break;
				case Field.FromPortID:
					fromPortID = value;
					break;
				case Field.ToPortID:
					toPortID = value;
					break;
				case Field.FreightForwarderID:
					freightForwarderID = value;
					break;
				case Field.TradeTermID:
					tradeTermID = value;
					break;
				case Field.ShippingModeID:
					shippingModeID = value;
					break;
				case Field.ShipToID:
					shipToID = value;
					break;
				case Field.SpecificAddressID:
					specificAddressID = value;
					break;
				case Field.CustomerBillToID:
					customerBillToID = value;
					break;
				case Field.SpecificBillingAddressID:
					specificBillingAddressID = value;
					break;
				default:
					break;
			}
		}

		public override void SetValue(int field, short? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, short? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, byte? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, byte? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, BitArray value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, BitArray value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, float? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, float? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, double? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, double? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, decimal? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, decimal? value)
		{
			switch (field)
			{
				case Field.TotalOfLineAmountsInCustomerCurrency:
					totalOfLineAmountsInCustomerCurrency = value;
					break;
				case Field.FreightAmountInCustomerCurrency:
					freightAmountInCustomerCurrency = value;
					break;
				case Field.InsuranceAmountInCustomerCurrency:
					insuranceAmountInCustomerCurrency = value;
					break;
				case Field.AdditionalCharges1InCustomerCurrency:
					additionalCharges1InCustomerCurrency = value;
					break;
				case Field.AdditionalCharges2InCustomerCurrency:
					additionalCharges2InCustomerCurrency = value;
					break;
				case Field.AdditionalCharges3InCustomerCurrency:
					additionalCharges3InCustomerCurrency = value;
					break;
				case Field.TotalLineChargeAmountInCustomerCurrency:
					totalLineChargeAmountInCustomerCurrency = value;
					break;
				case Field.ActualFreightChargesInCustomerCurrency:
					actualFreightChargesInCustomerCurrency = value;
					break;
				case Field.InvoicedQuantityInStorageUOM:
					invoicedQuantityInStorageUOM = value;
					break;
				case Field.UnitSalePriceOfStorageUOMInCustomerCurrency:
					unitSalePriceOfStorageUOMInCustomerCurrency = value;
					break;
				default:
					break;
			}
		}

		public override void SetValue(int field, char? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, char? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, string value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, string value)
		{
			switch (field)
			{
				case Field.DriverName:
					driverName = value;
					break;
				case Field.DriverContactNo:
					driverContactNo = value;
					break;
				case Field.VehicleName:
					vehicleName = value;
					break;
				case Field.VehicleNumber:
					vehicleNumber = value;
					break;
				case Field.SpecificShipToCode:
					specificShipToCode = value;
					break;
				case Field.FinalDestinationCode:
					finalDestinationCode = value;
					break;
				case Field.SpecificBillToCode:
					specificBillToCode = value;
					break;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					primaryCompanyID_PrimaryCompanyName = value;
					break;
				case Field.WarehouseID_WarehouseName:
					warehouseID_WarehouseName = value;
					break;
				case Field.CostBucketID_CostBucketName:
					costBucketID_CostBucketName = value;
					break;
				default:
					break;
			}
		}

		public override void SetValue(int field, DateTime? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, DateTime? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override void SetValue(int field, Guid? value)
		{
			SetValue((Field)field, value);
		}

		public void SetValue(Field field, Guid? value)
		{
			switch (field)
			{
				default:
					break;
			}
		}

		public override bool IsIdentity(int field)
		{
			return false;
		}

		#endregion Overriding / Public Members
	}
}