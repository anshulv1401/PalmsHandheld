//// Warning: Do not modify!
//// This file (PartTransactionsFromHandheldActionEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, February 8, 2018' at '12:51:42 PM'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Actions
{
	[Serializable]
	public partial class PartTransactionsFromHandheldActionEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, PrimaryCompanyID
			, WarehousePrimaryCompanyID
			, CostBucketID
			, PartCostID
			, PartBatchID
			, FromLocationID
			, ToLocationID
			, AvailableQuantityInStorageUOM
			, StockTransferQuantityInStorageUOM
			, TransactionTypeID
			, MaximumNoOfLinesPerDocument
			, IsMixedShippingInfoPackTypesAllowed
			, PrimaryCompanyID_PrimaryCompanyName
			, WarehouseID_WarehouseName
			, CostBucketID_CostBucketName
			, PartCode
			, LocationCode
			, SerialNo
			, PartBatchNo
			, ManufacturingDate
			, ShippingInformationID
			, FromPackID
			, ToPackID
			, FromVehicleID
			, ToVehicleID
			, SalesOrderID
			, SalesOrderLineNo
			, StockBucketID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? primaryCompanyID;
		public int? warehousePrimaryCompanyID;
		public int? costBucketID;
		public int? partCostID;
		public int? partBatchID;
		public int? fromLocationID;
		public int? toLocationID;
		public decimal? availableQuantityInStorageUOM;
		public decimal? stockTransferQuantityInStorageUOM;
		public int? transactionTypeID;
		public int? maximumNoOfLinesPerDocument;
		public bool? isMixedShippingInfoPackTypesAllowed;
		public string primaryCompanyID_PrimaryCompanyName;
		public string warehouseID_WarehouseName;
		public string costBucketID_CostBucketName;
		public string partCode;
		public string locationCode;
		public string serialNo;
		public string partBatchNo;
		public DateTime? manufacturingDate;
		public int? shippingInformationID;
		public int? fromPackID;
		public int? toPackID;
		public int? fromVehicleID;
		public int? toVehicleID;
		public int? salesOrderID;
		public int? salesOrderLineNo;
		public int? stockBucketID;

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
				case Field.WarehousePrimaryCompanyID:
					return warehousePrimaryCompanyID;
				case Field.CostBucketID:
					return costBucketID;
				case Field.PartCostID:
					return partCostID;
				case Field.PartBatchID:
					return partBatchID;
				case Field.FromLocationID:
					return fromLocationID;
				case Field.ToLocationID:
					return toLocationID;
				case Field.AvailableQuantityInStorageUOM:
					return availableQuantityInStorageUOM;
				case Field.StockTransferQuantityInStorageUOM:
					return stockTransferQuantityInStorageUOM;
				case Field.TransactionTypeID:
					return transactionTypeID;
				case Field.MaximumNoOfLinesPerDocument:
					return maximumNoOfLinesPerDocument;
				case Field.IsMixedShippingInfoPackTypesAllowed:
					return isMixedShippingInfoPackTypesAllowed;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return primaryCompanyID_PrimaryCompanyName;
				case Field.WarehouseID_WarehouseName:
					return warehouseID_WarehouseName;
				case Field.CostBucketID_CostBucketName:
					return costBucketID_CostBucketName;
				case Field.PartCode:
					return partCode;
				case Field.LocationCode:
					return locationCode;
				case Field.SerialNo:
					return serialNo;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.ShippingInformationID:
					return shippingInformationID;
				case Field.FromPackID:
					return fromPackID;
				case Field.ToPackID:
					return toPackID;
				case Field.FromVehicleID:
					return fromVehicleID;
				case Field.ToVehicleID:
					return toVehicleID;
				case Field.SalesOrderID:
					return salesOrderID;
				case Field.SalesOrderLineNo:
					return salesOrderLineNo;
				case Field.StockBucketID:
					return stockBucketID;
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
				case Field.WarehousePrimaryCompanyID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
				case Field.PartCostID:
					return typeof(int?);
				case Field.PartBatchID:
					return typeof(int?);
				case Field.FromLocationID:
					return typeof(int?);
				case Field.ToLocationID:
					return typeof(int?);
				case Field.AvailableQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.StockTransferQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.TransactionTypeID:
					return typeof(int?);
				case Field.MaximumNoOfLinesPerDocument:
					return typeof(int?);
				case Field.IsMixedShippingInfoPackTypesAllowed:
					return typeof(bool?);
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return typeof(string);
				case Field.WarehouseID_WarehouseName:
					return typeof(string);
				case Field.CostBucketID_CostBucketName:
					return typeof(string);
				case Field.PartCode:
					return typeof(string);
				case Field.LocationCode:
					return typeof(string);
				case Field.SerialNo:
					return typeof(string);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.ShippingInformationID:
					return typeof(int?);
				case Field.FromPackID:
					return typeof(int?);
				case Field.ToPackID:
					return typeof(int?);
				case Field.FromVehicleID:
					return typeof(int?);
				case Field.ToVehicleID:
					return typeof(int?);
				case Field.SalesOrderID:
					return typeof(int?);
				case Field.SalesOrderLineNo:
					return typeof(int?);
				case Field.StockBucketID:
					return typeof(int?);

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
				case Field.IsMixedShippingInfoPackTypesAllowed:
					isMixedShippingInfoPackTypesAllowed = value;
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
				case Field.WarehousePrimaryCompanyID:
					warehousePrimaryCompanyID = value;
					break;
				case Field.CostBucketID:
					costBucketID = value;
					break;
				case Field.PartCostID:
					partCostID = value;
					break;
				case Field.PartBatchID:
					partBatchID = value;
					break;
				case Field.FromLocationID:
					fromLocationID = value;
					break;
				case Field.ToLocationID:
					toLocationID = value;
					break;
				case Field.TransactionTypeID:
					transactionTypeID = value;
					break;
				case Field.MaximumNoOfLinesPerDocument:
					maximumNoOfLinesPerDocument = value;
					break;
				case Field.ShippingInformationID:
					shippingInformationID = value;
					break;
				case Field.FromPackID:
					fromPackID = value;
					break;
				case Field.ToPackID:
					toPackID = value;
					break;
				case Field.FromVehicleID:
					fromVehicleID = value;
					break;
				case Field.ToVehicleID:
					toVehicleID = value;
					break;
				case Field.SalesOrderID:
					salesOrderID = value;
					break;
				case Field.SalesOrderLineNo:
					salesOrderLineNo = value;
					break;
				case Field.StockBucketID:
					stockBucketID = value;
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
				case Field.AvailableQuantityInStorageUOM:
					availableQuantityInStorageUOM = value;
					break;
				case Field.StockTransferQuantityInStorageUOM:
					stockTransferQuantityInStorageUOM = value;
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
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					primaryCompanyID_PrimaryCompanyName = value;
					break;
				case Field.WarehouseID_WarehouseName:
					warehouseID_WarehouseName = value;
					break;
				case Field.CostBucketID_CostBucketName:
					costBucketID_CostBucketName = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.LocationCode:
					locationCode = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.PartBatchNo:
					partBatchNo = value;
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

        //public override List<IEntityKey<Entity>> GetKeys()
        //{
        //    List<IEntityKey<Entity>> keys = new List<IEntityKey<Entity>>();

        //    keys.Add(GetPrimaryKey());

        //    return keys;
        //}

		#endregion Overriding / Public Members
	}
}
