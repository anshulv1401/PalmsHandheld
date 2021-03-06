//// Warning: Do not modify!
//// This file (InvoiceCreationFromHandHeldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Wednesday, February 14, 2018' at '12:17:13 PM'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;
using Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys;
using Technoforte.PALMS.Entities.CustomSearchViews.UniqueKeys;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.CustomSearchViews
{
	[Serializable]
	public partial class InvoiceCreationFromHandHeldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, PrimaryCompanyID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, PartStockID
			, BucketQuantityInStorageUOM
			, ShippingModeID
			, CustomerBillToID
			, CustomerShipToID
			, FreightForwarderID
			, ToPortID
			, FromPortID
			, TradeTermID
			, FinalDestinationCode
			, IsShippedSeparately
			, SpecificAddressID
			, SpecificBillToCode
			, SpecificBillingAddressID
			, SpecificShipToCode
			, SalesOrderNo
			, CustomerID
			, SalesOrderLineNo
			, PartID
			, IsFOC
			, PartCostID
			, InvoicedQuantityInStorageUOM
			, InvoicedQuantityInBillingUOM
			, FromLocationID
			, SalesOrderID
			, BillingUOMID
			, StorageUOMID
			, StorageUOMCode
			, UnitPriceOfBillingUOMInCustomerCurrency
			, LineAmountOfBillingUOMInCustomerCurrency
			, InvoicedPartCode
			, OrderedPartCode
			, InvoicedPartName
			, OrderedPartName
			, PartBatchID
			, PartBatchNo
			, SerialNo
			, ExpiryDate
			, BillingUOMID_UOMCode
			, BillingUOMID_UOMName
			, StockBucketID
			, ManufacturingDate
			, CumulativeLocationCode
			, CustomerShipToCode
			, PackNo
			, PackID
			, OriginalPackNo
			, OuterMostPackID
			, PackStatusID
			, IsActive
			, VehicleNo
			, VehicleID
			, OriginalVehicleNo
			, VehicleStatusID
			, ShippingInformationID
			, PalmsStatusID
			, PalmsStatusCode
			, PalmsStatusName
			, PalmsStatusType
			, CustomerName
			, CustomerCode
			, IsExpirySensitive
			, IsSerialNumberTracked
			, IsTrackedByManufactureDate
			, IsScanningCompulsory
			, IsBatchSensitive
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? primaryCompanyID;
		public int? costBucketID;
		public int? warehousePrimaryCompanyID;
		public int? partStockID;
		public decimal? bucketQuantityInStorageUOM;
		public int? shippingModeID;
		public int? customerBillToID;
		public int? customerShipToID;
		public int? freightForwarderID;
		public int? toPortID;
		public int? fromPortID;
		public int? tradeTermID;
		public string finalDestinationCode;
		public bool? isShippedSeparately;
		public int? specificAddressID;
		public string specificBillToCode;
		public int? specificBillingAddressID;
		public string specificShipToCode;
		public string salesOrderNo;
		public int? customerID;
		public int? salesOrderLineNo;
		public int? partID;
		public bool? isFOC;
		public int? partCostID;
		public decimal? invoicedQuantityInStorageUOM;
		public decimal? invoicedQuantityInBillingUOM;
		public int? fromLocationID;
		public int? salesOrderID;
		public int? billingUOMID;
		public int? storageUOMID;
		public string storageUOMCode;
		public decimal? unitPriceOfBillingUOMInCustomerCurrency;
		public decimal? lineAmountOfBillingUOMInCustomerCurrency;
		public string invoicedPartCode;
		public string orderedPartCode;
		public string invoicedPartName;
		public string orderedPartName;
		public int? partBatchID;
		public string partBatchNo;
		public string serialNo;
		public DateTime? expiryDate;
		public string billingUOMID_UOMCode;
		public string billingUOMID_UOMName;
		public int? stockBucketID;
		public DateTime? manufacturingDate;
		public string cumulativeLocationCode;
		public string customerShipToCode;
		public string packNo;
		public int? packID;
		public string originalPackNo;
		public int? outerMostPackID;
		public int? packStatusID;
		public bool? isActive;
		public string vehicleNo;
		public int? vehicleID;
		public string originalVehicleNo;
		public int? vehicleStatusID;
		public int? shippingInformationID;
		public int? palmsStatusID;
		public string palmsStatusCode;
		public string palmsStatusName;
		public string palmsStatusType;
		public string customerName;
		public string customerCode;
		public bool? isExpirySensitive;
		public bool? isSerialNumberTracked;
		public bool? isTrackedByManufactureDate;
		public bool? isScanningCompulsory;
		public bool? isBatchSensitive;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>) new InvoiceCreationFromHandHeldCustomSearchViewPrimaryKey()
			{
				partBatchID = (int)partBatchID
				, fromLocationID = (int)fromLocationID
				, primaryCompanyID = (int)primaryCompanyID
				, warehouseID = (int)warehouseID
				, costBucketID = (int)costBucketID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>) new InvoiceCreationFromHandHeldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<InvoiceCreationFromHandHeldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new InvoiceCreationFromHandHeldCustomSearchViewUniqueKey()
					{
						partBatchID = (int?)partBatchID
						, fromLocationID = (int?)fromLocationID
						, primaryCompanyID = (int?)primaryCompanyID
						, warehouseID = (int?)warehouseID
						, costBucketID = (int?)costBucketID
					};
			}

			return null;
		}

		public override IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<InvoiceCreationFromHandHeldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new InvoiceCreationFromHandHeldCustomSearchViewUniqueKey();
			}

			return null;
		}

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
				case Field.PartStockID:
					return partStockID;
				case Field.BucketQuantityInStorageUOM:
					return bucketQuantityInStorageUOM;
				case Field.ShippingModeID:
					return shippingModeID;
				case Field.CustomerBillToID:
					return customerBillToID;
				case Field.CustomerShipToID:
					return customerShipToID;
				case Field.FreightForwarderID:
					return freightForwarderID;
				case Field.ToPortID:
					return toPortID;
				case Field.FromPortID:
					return fromPortID;
				case Field.TradeTermID:
					return tradeTermID;
				case Field.FinalDestinationCode:
					return finalDestinationCode;
				case Field.IsShippedSeparately:
					return isShippedSeparately;
				case Field.SpecificAddressID:
					return specificAddressID;
				case Field.SpecificBillToCode:
					return specificBillToCode;
				case Field.SpecificBillingAddressID:
					return specificBillingAddressID;
				case Field.SpecificShipToCode:
					return specificShipToCode;
				case Field.SalesOrderNo:
					return salesOrderNo;
				case Field.CustomerID:
					return customerID;
				case Field.SalesOrderLineNo:
					return salesOrderLineNo;
				case Field.PartID:
					return partID;
				case Field.IsFOC:
					return isFOC;
				case Field.PartCostID:
					return partCostID;
				case Field.InvoicedQuantityInStorageUOM:
					return invoicedQuantityInStorageUOM;
				case Field.InvoicedQuantityInBillingUOM:
					return invoicedQuantityInBillingUOM;
				case Field.FromLocationID:
					return fromLocationID;
				case Field.SalesOrderID:
					return salesOrderID;
				case Field.BillingUOMID:
					return billingUOMID;
				case Field.StorageUOMID:
					return storageUOMID;
				case Field.StorageUOMCode:
					return storageUOMCode;
				case Field.UnitPriceOfBillingUOMInCustomerCurrency:
					return unitPriceOfBillingUOMInCustomerCurrency;
				case Field.LineAmountOfBillingUOMInCustomerCurrency:
					return lineAmountOfBillingUOMInCustomerCurrency;
				case Field.InvoicedPartCode:
					return invoicedPartCode;
				case Field.OrderedPartCode:
					return orderedPartCode;
				case Field.InvoicedPartName:
					return invoicedPartName;
				case Field.OrderedPartName:
					return orderedPartName;
				case Field.PartBatchID:
					return partBatchID;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.SerialNo:
					return serialNo;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.BillingUOMID_UOMCode:
					return billingUOMID_UOMCode;
				case Field.BillingUOMID_UOMName:
					return billingUOMID_UOMName;
				case Field.StockBucketID:
					return stockBucketID;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.CustomerShipToCode:
					return customerShipToCode;
				case Field.PackNo:
					return packNo;
				case Field.PackID:
					return packID;
				case Field.OriginalPackNo:
					return originalPackNo;
				case Field.OuterMostPackID:
					return outerMostPackID;
				case Field.PackStatusID:
					return packStatusID;
				case Field.IsActive:
					return isActive;
				case Field.VehicleNo:
					return vehicleNo;
				case Field.VehicleID:
					return vehicleID;
				case Field.OriginalVehicleNo:
					return originalVehicleNo;
				case Field.VehicleStatusID:
					return vehicleStatusID;
				case Field.ShippingInformationID:
					return shippingInformationID;
				case Field.PalmsStatusID:
					return palmsStatusID;
				case Field.PalmsStatusCode:
					return palmsStatusCode;
				case Field.PalmsStatusName:
					return palmsStatusName;
				case Field.PalmsStatusType:
					return palmsStatusType;
				case Field.CustomerName:
					return customerName;
				case Field.CustomerCode:
					return customerCode;
				case Field.IsExpirySensitive:
					return isExpirySensitive;
				case Field.IsSerialNumberTracked:
					return isSerialNumberTracked;
				case Field.IsTrackedByManufactureDate:
					return isTrackedByManufactureDate;
				case Field.IsScanningCompulsory:
					return isScanningCompulsory;
				case Field.IsBatchSensitive:
					return isBatchSensitive;
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
				case Field.PartStockID:
					return typeof(int?);
				case Field.BucketQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.ShippingModeID:
					return typeof(int?);
				case Field.CustomerBillToID:
					return typeof(int?);
				case Field.CustomerShipToID:
					return typeof(int?);
				case Field.FreightForwarderID:
					return typeof(int?);
				case Field.ToPortID:
					return typeof(int?);
				case Field.FromPortID:
					return typeof(int?);
				case Field.TradeTermID:
					return typeof(int?);
				case Field.FinalDestinationCode:
					return typeof(string);
				case Field.IsShippedSeparately:
					return typeof(bool?);
				case Field.SpecificAddressID:
					return typeof(int?);
				case Field.SpecificBillToCode:
					return typeof(string);
				case Field.SpecificBillingAddressID:
					return typeof(int?);
				case Field.SpecificShipToCode:
					return typeof(string);
				case Field.SalesOrderNo:
					return typeof(string);
				case Field.CustomerID:
					return typeof(int?);
				case Field.SalesOrderLineNo:
					return typeof(int?);
				case Field.PartID:
					return typeof(int?);
				case Field.IsFOC:
					return typeof(bool?);
				case Field.PartCostID:
					return typeof(int?);
				case Field.InvoicedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.InvoicedQuantityInBillingUOM:
					return typeof(decimal?);
				case Field.FromLocationID:
					return typeof(int?);
				case Field.SalesOrderID:
					return typeof(int?);
				case Field.BillingUOMID:
					return typeof(int?);
				case Field.StorageUOMID:
					return typeof(int?);
				case Field.StorageUOMCode:
					return typeof(string);
				case Field.UnitPriceOfBillingUOMInCustomerCurrency:
					return typeof(decimal?);
				case Field.LineAmountOfBillingUOMInCustomerCurrency:
					return typeof(decimal?);
				case Field.InvoicedPartCode:
					return typeof(string);
				case Field.OrderedPartCode:
					return typeof(string);
				case Field.InvoicedPartName:
					return typeof(string);
				case Field.OrderedPartName:
					return typeof(string);
				case Field.PartBatchID:
					return typeof(int?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.SerialNo:
					return typeof(string);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.BillingUOMID_UOMCode:
					return typeof(string);
				case Field.BillingUOMID_UOMName:
					return typeof(string);
				case Field.StockBucketID:
					return typeof(int?);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.CustomerShipToCode:
					return typeof(string);
				case Field.PackNo:
					return typeof(string);
				case Field.PackID:
					return typeof(int?);
				case Field.OriginalPackNo:
					return typeof(string);
				case Field.OuterMostPackID:
					return typeof(int?);
				case Field.PackStatusID:
					return typeof(int?);
				case Field.IsActive:
					return typeof(bool?);
				case Field.VehicleNo:
					return typeof(string);
				case Field.VehicleID:
					return typeof(int?);
				case Field.OriginalVehicleNo:
					return typeof(string);
				case Field.VehicleStatusID:
					return typeof(int?);
				case Field.ShippingInformationID:
					return typeof(int?);
				case Field.PalmsStatusID:
					return typeof(int?);
				case Field.PalmsStatusCode:
					return typeof(string);
				case Field.PalmsStatusName:
					return typeof(string);
				case Field.PalmsStatusType:
					return typeof(string);
				case Field.CustomerName:
					return typeof(string);
				case Field.CustomerCode:
					return typeof(string);
				case Field.IsExpirySensitive:
					return typeof(bool?);
				case Field.IsSerialNumberTracked:
					return typeof(bool?);
				case Field.IsTrackedByManufactureDate:
					return typeof(bool?);
				case Field.IsScanningCompulsory:
					return typeof(bool?);
				case Field.IsBatchSensitive:
					return typeof(bool?);

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
				case Field.IsShippedSeparately:
					isShippedSeparately = value;
					break;
				case Field.IsFOC:
					isFOC = value;
					break;
				case Field.IsActive:
					isActive = value;
					break;
				case Field.IsExpirySensitive:
					isExpirySensitive = value;
					break;
				case Field.IsSerialNumberTracked:
					isSerialNumberTracked = value;
					break;
				case Field.IsTrackedByManufactureDate:
					isTrackedByManufactureDate = value;
					break;
				case Field.IsScanningCompulsory:
					isScanningCompulsory = value;
					break;
				case Field.IsBatchSensitive:
					isBatchSensitive = value;
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
				case Field.PartStockID:
					partStockID = value;
					break;
				case Field.ShippingModeID:
					shippingModeID = value;
					break;
				case Field.CustomerBillToID:
					customerBillToID = value;
					break;
				case Field.CustomerShipToID:
					customerShipToID = value;
					break;
				case Field.FreightForwarderID:
					freightForwarderID = value;
					break;
				case Field.ToPortID:
					toPortID = value;
					break;
				case Field.FromPortID:
					fromPortID = value;
					break;
				case Field.TradeTermID:
					tradeTermID = value;
					break;
				case Field.SpecificAddressID:
					specificAddressID = value;
					break;
				case Field.SpecificBillingAddressID:
					specificBillingAddressID = value;
					break;
				case Field.CustomerID:
					customerID = value;
					break;
				case Field.SalesOrderLineNo:
					salesOrderLineNo = value;
					break;
				case Field.PartID:
					partID = value;
					break;
				case Field.PartCostID:
					partCostID = value;
					break;
				case Field.FromLocationID:
					fromLocationID = value;
					break;
				case Field.SalesOrderID:
					salesOrderID = value;
					break;
				case Field.BillingUOMID:
					billingUOMID = value;
					break;
				case Field.StorageUOMID:
					storageUOMID = value;
					break;
				case Field.PartBatchID:
					partBatchID = value;
					break;
				case Field.StockBucketID:
					stockBucketID = value;
					break;
				case Field.PackID:
					packID = value;
					break;
				case Field.OuterMostPackID:
					outerMostPackID = value;
					break;
				case Field.PackStatusID:
					packStatusID = value;
					break;
				case Field.VehicleID:
					vehicleID = value;
					break;
				case Field.VehicleStatusID:
					vehicleStatusID = value;
					break;
				case Field.ShippingInformationID:
					shippingInformationID = value;
					break;
				case Field.PalmsStatusID:
					palmsStatusID = value;
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
				case Field.BucketQuantityInStorageUOM:
					bucketQuantityInStorageUOM = value;
					break;
				case Field.InvoicedQuantityInStorageUOM:
					invoicedQuantityInStorageUOM = value;
					break;
				case Field.InvoicedQuantityInBillingUOM:
					invoicedQuantityInBillingUOM = value;
					break;
				case Field.UnitPriceOfBillingUOMInCustomerCurrency:
					unitPriceOfBillingUOMInCustomerCurrency = value;
					break;
				case Field.LineAmountOfBillingUOMInCustomerCurrency:
					lineAmountOfBillingUOMInCustomerCurrency = value;
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
				case Field.FinalDestinationCode:
					finalDestinationCode = value;
					break;
				case Field.SpecificBillToCode:
					specificBillToCode = value;
					break;
				case Field.SpecificShipToCode:
					specificShipToCode = value;
					break;
				case Field.SalesOrderNo:
					salesOrderNo = value;
					break;
				case Field.StorageUOMCode:
					storageUOMCode = value;
					break;
				case Field.InvoicedPartCode:
					invoicedPartCode = value;
					break;
				case Field.OrderedPartCode:
					orderedPartCode = value;
					break;
				case Field.InvoicedPartName:
					invoicedPartName = value;
					break;
				case Field.OrderedPartName:
					orderedPartName = value;
					break;
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.BillingUOMID_UOMCode:
					billingUOMID_UOMCode = value;
					break;
				case Field.BillingUOMID_UOMName:
					billingUOMID_UOMName = value;
					break;
				case Field.CumulativeLocationCode:
					cumulativeLocationCode = value;
					break;
				case Field.CustomerShipToCode:
					customerShipToCode = value;
					break;
				case Field.PackNo:
					packNo = value;
					break;
				case Field.OriginalPackNo:
					originalPackNo = value;
					break;
				case Field.VehicleNo:
					vehicleNo = value;
					break;
				case Field.OriginalVehicleNo:
					originalVehicleNo = value;
					break;
				case Field.PalmsStatusCode:
					palmsStatusCode = value;
					break;
				case Field.PalmsStatusName:
					palmsStatusName = value;
					break;
				case Field.PalmsStatusType:
					palmsStatusType = value;
					break;
				case Field.CustomerName:
					customerName = value;
					break;
				case Field.CustomerCode:
					customerCode = value;
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
				case Field.ExpiryDate:
					expiryDate = value;
					break;
				case Field.ManufacturingDate:
					manufacturingDate = value;
					break;
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
