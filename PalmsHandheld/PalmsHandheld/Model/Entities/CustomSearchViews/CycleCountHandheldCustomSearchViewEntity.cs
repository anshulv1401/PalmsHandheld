//// Warning: Do not modify!
//// This file (CycleCountHandheldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Monday, May 7, 2018' at '5:15:23 PM'
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
	public partial class CycleCountHandheldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, CycleCountInstructionID
			, CycleCountInstructionNo
			, IsClosed
			, IsBlindCount
			, CycleCountAdjustmentReadiness
			, VerifyBatchAndExpiryDate
			, VerifyManufactureDate
			, VerifySerialNo
			, VerifyPackNumber
			, IsRecountRequired
			, IsRecountOnLocation
			, IsRecountOnBatchAndExpiryDate
			, IsRecountOnManufactureDate
			, IsRecountOnSerialNo
			, IsRecountOnPackNumber
			, PreviousCycleCountInstructionID
			, LocationID
			, PartID
			, PartCode
			, PartName
			, LocationCode
			, CumulativeLocationCode
			
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
		public int? cycleCountInstructionID;
		public string cycleCountInstructionNo;
		public bool? isClosed;
		public bool? isBlindCount;
		public int? cycleCountAdjustmentReadiness;
		public bool? verifyBatchAndExpiryDate;
		public bool? verifyManufactureDate;
		public bool? verifySerialNo;
		public bool? verifyPackNumber;
		public bool? isRecountRequired;
		public bool? isRecountOnLocation;
		public bool? isRecountOnBatchAndExpiryDate;
		public bool? isRecountOnManufactureDate;
		public bool? isRecountOnSerialNo;
		public bool? isRecountOnPackNumber;
		public int? previousCycleCountInstructionID;
		public int? locationID;
		public int? partID;
		public string partCode;
		public string partName;
		public string locationCode;
		public string cumulativeLocationCode;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new CycleCountHandheldCustomSearchViewPrimaryKey()
			{
				warehouseID = (int)warehouseID
				, primaryCompanyID = (int)primaryCompanyID
				, costBucketID = (int)costBucketID
				, cycleCountInstructionID = (int)cycleCountInstructionID
				, locationID = (int)locationID
				, partID = (int)partID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new CycleCountHandheldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<CycleCountHandheldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new CycleCountHandheldCustomSearchViewUniqueKey()
					{
						warehouseID = (int?)warehouseID
						, primaryCompanyID = (int?)primaryCompanyID
						, costBucketID = (int?)costBucketID
						, cycleCountInstructionID = (int?)cycleCountInstructionID
						, locationID = (int?)locationID
						, partID = (int?)partID
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

		public EntityKey<CycleCountHandheldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new CycleCountHandheldCustomSearchViewUniqueKey();
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
				case Field.CycleCountInstructionID:
					return cycleCountInstructionID;
				case Field.CycleCountInstructionNo:
					return cycleCountInstructionNo;
				case Field.IsClosed:
					return isClosed;
				case Field.IsBlindCount:
					return isBlindCount;
				case Field.CycleCountAdjustmentReadiness:
					return cycleCountAdjustmentReadiness;
				case Field.VerifyBatchAndExpiryDate:
					return verifyBatchAndExpiryDate;
				case Field.VerifyManufactureDate:
					return verifyManufactureDate;
				case Field.VerifySerialNo:
					return verifySerialNo;
				case Field.VerifyPackNumber:
					return verifyPackNumber;
				case Field.IsRecountRequired:
					return isRecountRequired;
				case Field.IsRecountOnLocation:
					return isRecountOnLocation;
				case Field.IsRecountOnBatchAndExpiryDate:
					return isRecountOnBatchAndExpiryDate;
				case Field.IsRecountOnManufactureDate:
					return isRecountOnManufactureDate;
				case Field.IsRecountOnSerialNo:
					return isRecountOnSerialNo;
				case Field.IsRecountOnPackNumber:
					return isRecountOnPackNumber;
				case Field.PreviousCycleCountInstructionID:
					return previousCycleCountInstructionID;
				case Field.LocationID:
					return locationID;
				case Field.PartID:
					return partID;
				case Field.PartCode:
					return partCode;
				case Field.PartName:
					return partName;
				case Field.LocationCode:
					return locationCode;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
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
				case Field.CycleCountInstructionID:
					return typeof(int?);
				case Field.CycleCountInstructionNo:
					return typeof(string);
				case Field.IsClosed:
					return typeof(bool?);
				case Field.IsBlindCount:
					return typeof(bool?);
				case Field.CycleCountAdjustmentReadiness:
					return typeof(int?);
				case Field.VerifyBatchAndExpiryDate:
					return typeof(bool?);
				case Field.VerifyManufactureDate:
					return typeof(bool?);
				case Field.VerifySerialNo:
					return typeof(bool?);
				case Field.VerifyPackNumber:
					return typeof(bool?);
				case Field.IsRecountRequired:
					return typeof(bool?);
				case Field.IsRecountOnLocation:
					return typeof(bool?);
				case Field.IsRecountOnBatchAndExpiryDate:
					return typeof(bool?);
				case Field.IsRecountOnManufactureDate:
					return typeof(bool?);
				case Field.IsRecountOnSerialNo:
					return typeof(bool?);
				case Field.IsRecountOnPackNumber:
					return typeof(bool?);
				case Field.PreviousCycleCountInstructionID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
				case Field.PartID:
					return typeof(int?);
				case Field.PartCode:
					return typeof(string);
				case Field.PartName:
					return typeof(string);
				case Field.LocationCode:
					return typeof(string);
				case Field.CumulativeLocationCode:
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
				case Field.IsClosed:
					isClosed = value;
					break;
				case Field.IsBlindCount:
					isBlindCount = value;
					break;
				case Field.VerifyBatchAndExpiryDate:
					verifyBatchAndExpiryDate = value;
					break;
				case Field.VerifyManufactureDate:
					verifyManufactureDate = value;
					break;
				case Field.VerifySerialNo:
					verifySerialNo = value;
					break;
				case Field.VerifyPackNumber:
					verifyPackNumber = value;
					break;
				case Field.IsRecountRequired:
					isRecountRequired = value;
					break;
				case Field.IsRecountOnLocation:
					isRecountOnLocation = value;
					break;
				case Field.IsRecountOnBatchAndExpiryDate:
					isRecountOnBatchAndExpiryDate = value;
					break;
				case Field.IsRecountOnManufactureDate:
					isRecountOnManufactureDate = value;
					break;
				case Field.IsRecountOnSerialNo:
					isRecountOnSerialNo = value;
					break;
				case Field.IsRecountOnPackNumber:
					isRecountOnPackNumber = value;
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
				case Field.CycleCountInstructionID:
					cycleCountInstructionID = value;
					break;
				case Field.CycleCountAdjustmentReadiness:
					cycleCountAdjustmentReadiness = value;
					break;
				case Field.PreviousCycleCountInstructionID:
					previousCycleCountInstructionID = value;
					break;
				case Field.LocationID:
					locationID = value;
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
				case Field.CycleCountInstructionNo:
					cycleCountInstructionNo = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.PartName:
					partName = value;
					break;
				case Field.LocationCode:
					locationCode = value;
					break;
				case Field.CumulativeLocationCode:
					cumulativeLocationCode = value;
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
