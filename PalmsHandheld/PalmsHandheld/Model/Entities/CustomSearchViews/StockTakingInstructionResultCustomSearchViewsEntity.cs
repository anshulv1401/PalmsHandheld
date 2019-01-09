//// Warning: Do not modify!
//// This file (StockTakingInstructionResultCustomSearchViewsEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, February 11, 2016' at '9:05:52 AM'
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
	public partial class StockTakingInstructionResultCustomSearchViewsEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, StockTakingInstructionID
			, LocationID
			, DamagedLocationID
			, PartID
			, OKQuantityInStorageUOM
			, DamagedQuantityInStorageUOM
			, PartBatchNo
			, ManufacturingDate
			, ExpiryDate
			, SerialNo
			, PackNo
			, PartCode
			, DamagedLocationID_CumulativeLocationCode
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
		public int? stockTakingInstructionID;
		public int? locationID;
		public int? damagedLocationID;
		public int? partID;
		public decimal? oKQuantityInStorageUOM;
		public decimal? damagedQuantityInStorageUOM;
		public string partBatchNo;
		public DateTime? manufacturingDate;
		public DateTime? expiryDate;
		public string serialNo;
		public string packNo;
		public string partCode;
		public string damagedLocationID_CumulativeLocationCode;
		public string cumulativeLocationCode;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new StockTakingInstructionResultCustomSearchViewsPrimaryKey()
			{
				stockTakingInstructionID = (int)stockTakingInstructionID
				, warehouseID = (int)warehouseID
				, primaryCompanyID = (int)primaryCompanyID
				, costBucketID = (int)costBucketID
				, locationID = (int)locationID
				, warehousePrimaryCompanyID = (int)warehousePrimaryCompanyID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new StockTakingInstructionResultCustomSearchViewsPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<StockTakingInstructionResultCustomSearchViewsEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new StockTakingInstructionResultCustomSearchViewsUniqueKey()
					{
						stockTakingInstructionID = (int?)stockTakingInstructionID
						, warehouseID = (int?)warehouseID
						, primaryCompanyID = (int?)primaryCompanyID
						, costBucketID = (int?)costBucketID
						, locationID = (int?)locationID
						, warehousePrimaryCompanyID = (int?)warehousePrimaryCompanyID
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

		public EntityKey<StockTakingInstructionResultCustomSearchViewsEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new StockTakingInstructionResultCustomSearchViewsUniqueKey();
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
				case Field.StockTakingInstructionID:
					return stockTakingInstructionID;
				case Field.LocationID:
					return locationID;
				case Field.DamagedLocationID:
					return damagedLocationID;
				case Field.PartID:
					return partID;
				case Field.OKQuantityInStorageUOM:
					return oKQuantityInStorageUOM;
				case Field.DamagedQuantityInStorageUOM:
					return damagedQuantityInStorageUOM;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.SerialNo:
					return serialNo;
				case Field.PackNo:
					return packNo;
				case Field.PartCode:
					return partCode;
				case Field.DamagedLocationID_CumulativeLocationCode:
					return damagedLocationID_CumulativeLocationCode;
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
				case Field.StockTakingInstructionID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
				case Field.DamagedLocationID:
					return typeof(int?);
				case Field.PartID:
					return typeof(int?);
				case Field.OKQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.DamagedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.SerialNo:
					return typeof(string);
				case Field.PackNo:
					return typeof(string);
				case Field.PartCode:
					return typeof(string);
				case Field.DamagedLocationID_CumulativeLocationCode:
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
				case Field.StockTakingInstructionID:
					stockTakingInstructionID = value;
					break;
				case Field.LocationID:
					locationID = value;
					break;
				case Field.DamagedLocationID:
					damagedLocationID = value;
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
				case Field.OKQuantityInStorageUOM:
					oKQuantityInStorageUOM = value;
					break;
				case Field.DamagedQuantityInStorageUOM:
					damagedQuantityInStorageUOM = value;
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
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.PackNo:
					packNo = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.DamagedLocationID_CumulativeLocationCode:
					damagedLocationID_CumulativeLocationCode = value;
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
				case Field.ManufacturingDate:
					manufacturingDate = value;
					break;
				case Field.ExpiryDate:
					expiryDate = value;
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
