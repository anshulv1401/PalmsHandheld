//// Warning: Do not modify!
//// This file (PickAndLoadLiftFromHandheldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, March 2, 2017' at '6:24:22 PM'
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
	public partial class PickAndLoadLiftFromHandheldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, StockChangeInstructionID
			, StockChangeDocumentNo
			, StockChangeInstructionLineNo
			, StockChangeDocumentLineNo
			, TransactionTypeID
			, TransactionTypeCode
			, IsUserRequested
			, IsPartMovement
			, IsClosed
			, ExpectedQuantityInStorageUOM
			, TotalActualQuantityInStorageUOM
			, TotalOKQuantityInStorageUOM
			, PartBatchNo
			, SerialNo
			, ExpiryDate
			, ManufacturingDate
			, GateInWardID
			, PartID
			, PartCode
			, IsSerialNumberTracked
			, IsExpirySensitive
			, IsTrackedByManufactureDate
			, IsScanningCompulsory
			, FromLocationID
			, FromLocationID_LocationCode
			, FromLocationPickingSequenceNo
			, ToLocationID
			, ToLocationID_LocationCode
			, modifiedBy_PalmsUserLoginName
			, createdBy_PalmsUserLoginName
			, IsBatchSensitive
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? warehouseID;
		public int? costBucketID;
		public int? warehousePrimaryCompanyID;
		public int? stockChangeInstructionID;
		public string stockChangeDocumentNo;
		public int? stockChangeInstructionLineNo;
		public string stockChangeDocumentLineNo;
		public int? transactionTypeID;
		public string transactionTypeCode;
		public bool? isUserRequested;
		public bool? isPartMovement;
		public bool? isClosed;
		public decimal? expectedQuantityInStorageUOM;
		public decimal? totalActualQuantityInStorageUOM;
		public decimal? totalOKQuantityInStorageUOM;
		public string partBatchNo;
		public string serialNo;
		public DateTime? expiryDate;
		public DateTime? manufacturingDate;
		public int? gateInWardID;
		public int? partID;
		public string partCode;
		public bool? isSerialNumberTracked;
		public bool? isExpirySensitive;
		public bool? isTrackedByManufactureDate;
		public bool? isScanningCompulsory;
		public int? fromLocationID;
		public string fromLocationID_LocationCode;
		public int? fromLocationPickingSequenceNo;
		public int? toLocationID;
		public string toLocationID_LocationCode;
		public string modifiedBy_PalmsUserLoginName;
		public string createdBy_PalmsUserLoginName;
		public bool? isBatchSensitive;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new PickAndLoadLiftFromHandheldCustomSearchViewPrimaryKey()
			{
				warehouseID = (int)warehouseID
				, primaryCompanyID = (int)primaryCompanyID
				, costBucketID = (int)costBucketID
				, stockChangeInstructionID = (int)stockChangeInstructionID
				, stockChangeInstructionLineNo = (int)stockChangeInstructionLineNo
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new PickAndLoadLiftFromHandheldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<PickAndLoadLiftFromHandheldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new PickAndLoadLiftFromHandheldCustomSearchViewUniqueKey()
					{
						warehouseID = (int?)warehouseID
						, primaryCompanyID = (int?)primaryCompanyID
						, costBucketID = (int?)costBucketID
						, stockChangeInstructionID = (int?)stockChangeInstructionID
						, stockChangeInstructionLineNo = (int?)stockChangeInstructionLineNo
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

		public EntityKey<PickAndLoadLiftFromHandheldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new PickAndLoadLiftFromHandheldCustomSearchViewUniqueKey();
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
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.WarehouseID:
					return warehouseID;
				case Field.CostBucketID:
					return costBucketID;
				case Field.WarehousePrimaryCompanyID:
					return warehousePrimaryCompanyID;
				case Field.StockChangeInstructionID:
					return stockChangeInstructionID;
				case Field.StockChangeDocumentNo:
					return stockChangeDocumentNo;
				case Field.StockChangeInstructionLineNo:
					return stockChangeInstructionLineNo;
				case Field.StockChangeDocumentLineNo:
					return stockChangeDocumentLineNo;
				case Field.TransactionTypeID:
					return transactionTypeID;
				case Field.TransactionTypeCode:
					return transactionTypeCode;
				case Field.IsUserRequested:
					return isUserRequested;
				case Field.IsPartMovement:
					return isPartMovement;
				case Field.IsClosed:
					return isClosed;
				case Field.ExpectedQuantityInStorageUOM:
					return expectedQuantityInStorageUOM;
				case Field.TotalActualQuantityInStorageUOM:
					return totalActualQuantityInStorageUOM;
				case Field.TotalOKQuantityInStorageUOM:
					return totalOKQuantityInStorageUOM;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.SerialNo:
					return serialNo;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.GateInWardID:
					return gateInWardID;
				case Field.PartID:
					return partID;
				case Field.PartCode:
					return partCode;
				case Field.IsSerialNumberTracked:
					return isSerialNumberTracked;
				case Field.IsExpirySensitive:
					return isExpirySensitive;
				case Field.IsTrackedByManufactureDate:
					return isTrackedByManufactureDate;
				case Field.IsScanningCompulsory:
					return isScanningCompulsory;
				case Field.FromLocationID:
					return fromLocationID;
				case Field.FromLocationID_LocationCode:
					return fromLocationID_LocationCode;
				case Field.FromLocationPickingSequenceNo:
					return fromLocationPickingSequenceNo;
				case Field.ToLocationID:
					return toLocationID;
				case Field.ToLocationID_LocationCode:
					return toLocationID_LocationCode;
				case Field.modifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
				case Field.createdBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
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
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
				case Field.WarehousePrimaryCompanyID:
					return typeof(int?);
				case Field.StockChangeInstructionID:
					return typeof(int?);
				case Field.StockChangeDocumentNo:
					return typeof(string);
				case Field.StockChangeInstructionLineNo:
					return typeof(int?);
				case Field.StockChangeDocumentLineNo:
					return typeof(string);
				case Field.TransactionTypeID:
					return typeof(int?);
				case Field.TransactionTypeCode:
					return typeof(string);
				case Field.IsUserRequested:
					return typeof(bool?);
				case Field.IsPartMovement:
					return typeof(bool?);
				case Field.IsClosed:
					return typeof(bool?);
				case Field.ExpectedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.TotalActualQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.TotalOKQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.SerialNo:
					return typeof(string);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.GateInWardID:
					return typeof(int?);
				case Field.PartID:
					return typeof(int?);
				case Field.PartCode:
					return typeof(string);
				case Field.IsSerialNumberTracked:
					return typeof(bool?);
				case Field.IsExpirySensitive:
					return typeof(bool?);
				case Field.IsTrackedByManufactureDate:
					return typeof(bool?);
				case Field.IsScanningCompulsory:
					return typeof(bool?);
				case Field.FromLocationID:
					return typeof(int?);
				case Field.FromLocationID_LocationCode:
					return typeof(string);
				case Field.FromLocationPickingSequenceNo:
					return typeof(int?);
				case Field.ToLocationID:
					return typeof(int?);
				case Field.ToLocationID_LocationCode:
					return typeof(string);
				case Field.modifiedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.createdBy_PalmsUserLoginName:
					return typeof(string);
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
				case Field.IsUserRequested:
					isUserRequested = value;
					break;
				case Field.IsPartMovement:
					isPartMovement = value;
					break;
				case Field.IsClosed:
					isClosed = value;
					break;
				case Field.IsSerialNumberTracked:
					isSerialNumberTracked = value;
					break;
				case Field.IsExpirySensitive:
					isExpirySensitive = value;
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
				case Field.PrimaryCompanyID:
					primaryCompanyID = value;
					break;
				case Field.WarehouseID:
					warehouseID = value;
					break;
				case Field.CostBucketID:
					costBucketID = value;
					break;
				case Field.WarehousePrimaryCompanyID:
					warehousePrimaryCompanyID = value;
					break;
				case Field.StockChangeInstructionID:
					stockChangeInstructionID = value;
					break;
				case Field.StockChangeInstructionLineNo:
					stockChangeInstructionLineNo = value;
					break;
				case Field.TransactionTypeID:
					transactionTypeID = value;
					break;
				case Field.GateInWardID:
					gateInWardID = value;
					break;
				case Field.PartID:
					partID = value;
					break;
				case Field.FromLocationID:
					fromLocationID = value;
					break;
				case Field.FromLocationPickingSequenceNo:
					fromLocationPickingSequenceNo = value;
					break;
				case Field.ToLocationID:
					toLocationID = value;
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
				case Field.ExpectedQuantityInStorageUOM:
					expectedQuantityInStorageUOM = value;
					break;
				case Field.TotalActualQuantityInStorageUOM:
					totalActualQuantityInStorageUOM = value;
					break;
				case Field.TotalOKQuantityInStorageUOM:
					totalOKQuantityInStorageUOM = value;
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
				case Field.StockChangeDocumentNo:
					stockChangeDocumentNo = value;
					break;
				case Field.StockChangeDocumentLineNo:
					stockChangeDocumentLineNo = value;
					break;
				case Field.TransactionTypeCode:
					transactionTypeCode = value;
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
				case Field.FromLocationID_LocationCode:
					fromLocationID_LocationCode = value;
					break;
				case Field.ToLocationID_LocationCode:
					toLocationID_LocationCode = value;
					break;
				case Field.modifiedBy_PalmsUserLoginName:
					modifiedBy_PalmsUserLoginName = value;
					break;
				case Field.createdBy_PalmsUserLoginName:
					createdBy_PalmsUserLoginName = value;
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
