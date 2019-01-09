//// Warning: Do not modify!
//// This file (PalletContentCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, August 18, 2016' at '3:29:53 PM'
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
	public partial class PalletContentCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PartCode
			, PartName
			, IsSerialNumberTracked
			, IsExpirySensitive
			, IsTrackedByManufactureDate
			, PartBatchNo
			, ExpiryDate
			, ManufacturingDate
			, SerialNo
			, IsClosed
			, CumulativeLocationCode
			, LocationID
			, PrimaryCompanyID
			, WarehouseID
			, LiftedQuantityInStorageUOM
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public string partCode;
		public string partName;
		public bool? isSerialNumberTracked;
		public bool? isExpirySensitive;
		public bool? isTrackedByManufactureDate;
		public string partBatchNo;
		public DateTime? expiryDate;
		public DateTime? manufacturingDate;
		public string serialNo;
		public bool? isClosed;
		public string cumulativeLocationCode;
		public int? locationID;
		public int? primaryCompanyID;
		public int? warehouseID;
		public decimal? liftedQuantityInStorageUOM;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new PalletContentCustomSearchViewPrimaryKey()
			{
				partCode = (string)partCode
				, locationID = (int)locationID
				, warehouseID = (int)warehouseID
				, primaryCompanyID = (int)primaryCompanyID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new PalletContentCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<PalletContentCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new PalletContentCustomSearchViewUniqueKey()
					{
						partCode = (string)partCode
						, locationID = (int?)locationID
						, warehouseID = (int?)warehouseID
						, primaryCompanyID = (int?)primaryCompanyID
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

		public EntityKey<PalletContentCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new PalletContentCustomSearchViewUniqueKey();
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
				case Field.PartCode:
					return partCode;
				case Field.PartName:
					return partName;
				case Field.IsSerialNumberTracked:
					return isSerialNumberTracked;
				case Field.IsExpirySensitive:
					return isExpirySensitive;
				case Field.IsTrackedByManufactureDate:
					return isTrackedByManufactureDate;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.SerialNo:
					return serialNo;
				case Field.IsClosed:
					return isClosed;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.LocationID:
					return locationID;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.WarehouseID:
					return warehouseID;
				case Field.LiftedQuantityInStorageUOM:
					return liftedQuantityInStorageUOM;
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
				case Field.PartCode:
					return typeof(string);
				case Field.PartName:
					return typeof(string);
				case Field.IsSerialNumberTracked:
					return typeof(bool?);
				case Field.IsExpirySensitive:
					return typeof(bool?);
				case Field.IsTrackedByManufactureDate:
					return typeof(bool?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.SerialNo:
					return typeof(string);
				case Field.IsClosed:
					return typeof(bool?);
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.LocationID:
					return typeof(int?);
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
				case Field.LiftedQuantityInStorageUOM:
					return typeof(decimal?);

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
				case Field.IsSerialNumberTracked:
					isSerialNumberTracked = value;
					break;
				case Field.IsExpirySensitive:
					isExpirySensitive = value;
					break;
				case Field.IsTrackedByManufactureDate:
					isTrackedByManufactureDate = value;
					break;
				case Field.IsClosed:
					isClosed = value;
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
				case Field.LocationID:
					locationID = value;
					break;
				case Field.PrimaryCompanyID:
					primaryCompanyID = value;
					break;
				case Field.WarehouseID:
					warehouseID = value;
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
				case Field.PartCode:
					partCode = value;
					break;
				case Field.PartName:
					partName = value;
					break;
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
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
