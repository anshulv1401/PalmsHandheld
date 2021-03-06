//// Warning: Do not modify!
//// This file (SuggestEmptyLocationForPartBinningFromHHTActionEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Wednesday, January 24, 2018' at '2:24:09 PM'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Actions
{
	[Serializable]
	public partial class SuggestEmptyLocationForPartBinningFromHHTActionEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, PrimaryCompanyID
			, CostBucketID
			, StockChangeInstructionID
			, MoveableLocationID
			, MoveableLocationCode
			, ActualBatchID
			, LiftedQuantityInStorageUOM
			, TotalDroppedQuantityInStorageUOM
			, LiftNo
			, NoOfDrops
			, StockChangeInstructionLineNo
			, StockChangeDocumentLineNo
			, StorageLocationID
			, StorageLocationCode
			, ExpiryDate
			, ManufacturingDate
			, PartBatchNo
			, SerialNo
			, IsTrackedByManufactureDate
			, IsExpirySensitive
			, IsSerialNumberTracked
			, IsBatchSensitive
			, LocationTypeID
			, GateInWardID
			, PartID
			, PartCode
			, TransactionTypeCode
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? primaryCompanyID;
		public int? costBucketID;
		public int? stockChangeInstructionID;
		public int? moveableLocationID;
		public string moveableLocationCode;
		public int? actualBatchID;
		public decimal? liftedQuantityInStorageUOM;
		public decimal? totalDroppedQuantityInStorageUOM;
		public int? liftNo;
		public int? noOfDrops;
		public int? stockChangeInstructionLineNo;
		public string stockChangeDocumentLineNo;
		public int? storageLocationID;
		public string storageLocationCode;
		public DateTime? expiryDate;
		public DateTime? manufacturingDate;
		public string partBatchNo;
		public string serialNo;
		public bool? isTrackedByManufactureDate;
		public bool? isExpirySensitive;
		public bool? isSerialNumberTracked;
		public bool? isBatchSensitive;
		public int? locationTypeID;
		public int? gateInWardID;
		public int? partID;
		public string partCode;
		public string transactionTypeCode;

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
				case Field.StockChangeInstructionID:
					return stockChangeInstructionID;
				case Field.MoveableLocationID:
					return moveableLocationID;
				case Field.MoveableLocationCode:
					return moveableLocationCode;
				case Field.ActualBatchID:
					return actualBatchID;
				case Field.LiftedQuantityInStorageUOM:
					return liftedQuantityInStorageUOM;
				case Field.TotalDroppedQuantityInStorageUOM:
					return totalDroppedQuantityInStorageUOM;
				case Field.LiftNo:
					return liftNo;
				case Field.NoOfDrops:
					return noOfDrops;
				case Field.StockChangeInstructionLineNo:
					return stockChangeInstructionLineNo;
				case Field.StockChangeDocumentLineNo:
					return stockChangeDocumentLineNo;
				case Field.StorageLocationID:
					return storageLocationID;
				case Field.StorageLocationCode:
					return storageLocationCode;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.SerialNo:
					return serialNo;
				case Field.IsTrackedByManufactureDate:
					return isTrackedByManufactureDate;
				case Field.IsExpirySensitive:
					return isExpirySensitive;
				case Field.IsSerialNumberTracked:
					return isSerialNumberTracked;
				case Field.IsBatchSensitive:
					return isBatchSensitive;
				case Field.LocationTypeID:
					return locationTypeID;
				case Field.GateInWardID:
					return gateInWardID;
				case Field.PartID:
					return partID;
				case Field.PartCode:
					return partCode;
				case Field.TransactionTypeCode:
					return transactionTypeCode;
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
				case Field.StockChangeInstructionID:
					return typeof(int?);
				case Field.MoveableLocationID:
					return typeof(int?);
				case Field.MoveableLocationCode:
					return typeof(string);
				case Field.ActualBatchID:
					return typeof(int?);
				case Field.LiftedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.TotalDroppedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.LiftNo:
					return typeof(int?);
				case Field.NoOfDrops:
					return typeof(int?);
				case Field.StockChangeInstructionLineNo:
					return typeof(int?);
				case Field.StockChangeDocumentLineNo:
					return typeof(string);
				case Field.StorageLocationID:
					return typeof(int?);
				case Field.StorageLocationCode:
					return typeof(string);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.SerialNo:
					return typeof(string);
				case Field.IsTrackedByManufactureDate:
					return typeof(bool?);
				case Field.IsExpirySensitive:
					return typeof(bool?);
				case Field.IsSerialNumberTracked:
					return typeof(bool?);
				case Field.IsBatchSensitive:
					return typeof(bool?);
				case Field.LocationTypeID:
					return typeof(int?);
				case Field.GateInWardID:
					return typeof(int?);
				case Field.PartID:
					return typeof(int?);
				case Field.PartCode:
					return typeof(string);
				case Field.TransactionTypeCode:
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
				case Field.IsTrackedByManufactureDate:
					isTrackedByManufactureDate = value;
					break;
				case Field.IsExpirySensitive:
					isExpirySensitive = value;
					break;
				case Field.IsSerialNumberTracked:
					isSerialNumberTracked = value;
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
				case Field.StockChangeInstructionID:
					stockChangeInstructionID = value;
					break;
				case Field.MoveableLocationID:
					moveableLocationID = value;
					break;
				case Field.ActualBatchID:
					actualBatchID = value;
					break;
				case Field.LiftNo:
					liftNo = value;
					break;
				case Field.NoOfDrops:
					noOfDrops = value;
					break;
				case Field.StockChangeInstructionLineNo:
					stockChangeInstructionLineNo = value;
					break;
				case Field.StorageLocationID:
					storageLocationID = value;
					break;
				case Field.LocationTypeID:
					locationTypeID = value;
					break;
				case Field.GateInWardID:
					gateInWardID = value;
					break;
				case Field.PartID:
					partID = value;
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
				case Field.LiftedQuantityInStorageUOM:
					liftedQuantityInStorageUOM = value;
					break;
				case Field.TotalDroppedQuantityInStorageUOM:
					totalDroppedQuantityInStorageUOM = value;
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
				case Field.MoveableLocationCode:
					moveableLocationCode = value;
					break;
				case Field.StockChangeDocumentLineNo:
					stockChangeDocumentLineNo = value;
					break;
				case Field.StorageLocationCode:
					storageLocationCode = value;
					break;
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.TransactionTypeCode:
					transactionTypeCode = value;
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
