//// Warning: Do not modify!
//// This file (LocationForHandheldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '24 April 2013' at '16:12:47'
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
	public partial class LocationForHandheldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, LocationID
			, CumulativeLocationCode
			, IsUnderStocktaking
			, IsUsable
			, LocationTypeID
			, IsStorageLocation
			, IsReceivingLocation
			, IsDispatchLocation
			, IsMoveableLocation
			, modifiedBy_PalmsUserLoginName
			, createdBy_PalmsUserLoginName
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? locationID;
		public string cumulativeLocationCode;
		public bool? isUnderStocktaking;
		public bool? isUsable;
		public int? locationTypeID;
		public bool? isStorageLocation;
		public bool? isReceivingLocation;
		public bool? isDispatchLocation;
		public bool? isMoveableLocation;
		public string modifiedBy_PalmsUserLoginName;
		public string createdBy_PalmsUserLoginName;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new LocationForHandheldCustomSearchViewPrimaryKey()
			{
				locationID = (int)locationID
				, warehouseID = (int)warehouseID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new LocationForHandheldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<LocationForHandheldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new LocationForHandheldCustomSearchViewUniqueKey()
					{
						locationID = (int?)locationID
						, warehouseID = (int?)warehouseID
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

		public EntityKey<LocationForHandheldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new LocationForHandheldCustomSearchViewUniqueKey();
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
				case Field.LocationID:
					return locationID;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.IsUnderStocktaking:
					return isUnderStocktaking;
				case Field.IsUsable:
					return isUsable;
				case Field.LocationTypeID:
					return locationTypeID;
				case Field.IsStorageLocation:
					return isStorageLocation;
				case Field.IsReceivingLocation:
					return isReceivingLocation;
				case Field.IsDispatchLocation:
					return isDispatchLocation;
				case Field.IsMoveableLocation:
					return isMoveableLocation;
				case Field.modifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
				case Field.createdBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
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
				case Field.LocationID:
					return typeof(int?);
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.IsUnderStocktaking:
					return typeof(bool?);
				case Field.IsUsable:
					return typeof(bool?);
				case Field.LocationTypeID:
					return typeof(int?);
				case Field.IsStorageLocation:
					return typeof(bool?);
				case Field.IsReceivingLocation:
					return typeof(bool?);
				case Field.IsDispatchLocation:
					return typeof(bool?);
				case Field.IsMoveableLocation:
					return typeof(bool?);
				case Field.modifiedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.createdBy_PalmsUserLoginName:
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
				case Field.IsUnderStocktaking:
					isUnderStocktaking = value;
					break;
				case Field.IsUsable:
					isUsable = value;
					break;
				case Field.IsStorageLocation:
					isStorageLocation = value;
					break;
				case Field.IsReceivingLocation:
					isReceivingLocation = value;
					break;
				case Field.IsDispatchLocation:
					isDispatchLocation = value;
					break;
				case Field.IsMoveableLocation:
					isMoveableLocation = value;
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
				case Field.LocationID:
					locationID = value;
					break;
				case Field.LocationTypeID:
					locationTypeID = value;
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
				case Field.CumulativeLocationCode:
					cumulativeLocationCode = value;
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
