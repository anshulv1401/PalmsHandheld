//// Warning: Do not modify!
//// This file (LocationSelectionCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Monday, August 29, 2016' at '9:23:57 AM'
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
	public partial class LocationSelectionCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, CumulativeLocationCode
			, IsUsable
			, IsPicking
			, LocationCode
			, LocationHierarchyID
			, LocationID
			, LocationPriority
			, UpperLocationID
			, IsUnderStocktaking
			, DimensionDefinitionID_DimensionDefinitionCode
			, DimensionDefinitionID_DimensionDefinitionName
			, UpperLocationID_CumulativeLocationCode
			, UpperLocationID_LocationCode
			, UpperLocationID_UpperLocationID
			, LocationHierarchyID_LocationHierarchyCode
			, LocationHierarchyID_LocationHierarchyName
			, LocationHierarchyID_LocationTypeID
			, LocationHierarchyID_UpperLocationHierarchyID
			, CreatedBy_PalmsUserLoginName
			, ModifiedBy_PalmsUserLoginName
			, LocationHierarchyID_LocationTypeID_LocationTypeCode
			, LocationHierarchyID_LocationTypeID_LocationTypeName
			, LocationHierarchyID_LocationTypeID_WarehouseID
			, LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode
			, LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseName
			, LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode
			, IsReceivingLocation
			, IsStorageLocation
			, IsDispatchLocation
			, IsMoveableLocation
			, IsDamageLocation
			, LocationTypeCode
			, LocationTypeID
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public string cumulativeLocationCode;
		public bool? isUsable;
		public bool? isPicking;
		public string locationCode;
		public int? locationHierarchyID;
		public int? locationID;
		public int? locationPriority;
		public int? upperLocationID;
		public bool? isUnderStocktaking;
		public string dimensionDefinitionID_DimensionDefinitionCode;
		public string dimensionDefinitionID_DimensionDefinitionName;
		public string upperLocationID_CumulativeLocationCode;
		public string upperLocationID_LocationCode;
		public int? upperLocationID_UpperLocationID;
		public string locationHierarchyID_LocationHierarchyCode;
		public string locationHierarchyID_LocationHierarchyName;
		public int? locationHierarchyID_LocationTypeID;
		public int? locationHierarchyID_UpperLocationHierarchyID;
		public string createdBy_PalmsUserLoginName;
		public string modifiedBy_PalmsUserLoginName;
		public string locationHierarchyID_LocationTypeID_LocationTypeCode;
		public string locationHierarchyID_LocationTypeID_LocationTypeName;
		public int? locationHierarchyID_LocationTypeID_WarehouseID;
		public string locationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode;
		public string locationHierarchyID_LocationTypeID_WarehouseID_WarehouseName;
		public string locationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode;
		public bool? isReceivingLocation;
		public bool? isStorageLocation;
		public bool? isDispatchLocation;
		public bool? isMoveableLocation;
		public bool? isDamageLocation;
		public string locationTypeCode;
		public int? locationTypeID;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new LocationSelectionCustomSearchViewPrimaryKey()
			{
				warehouseID = (int)warehouseID
				, locationID = (int)locationID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new LocationSelectionCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<LocationSelectionCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new LocationSelectionCustomSearchViewUniqueKey()
					{
						warehouseID = (int?)warehouseID
						, locationID = (int?)locationID
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

		public EntityKey<LocationSelectionCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new LocationSelectionCustomSearchViewUniqueKey();
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
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.IsUsable:
					return isUsable;
				case Field.IsPicking:
					return isPicking;
				case Field.LocationCode:
					return locationCode;
				case Field.LocationHierarchyID:
					return locationHierarchyID;
				case Field.LocationID:
					return locationID;
				case Field.LocationPriority:
					return locationPriority;
				case Field.UpperLocationID:
					return upperLocationID;
				case Field.IsUnderStocktaking:
					return isUnderStocktaking;
				case Field.DimensionDefinitionID_DimensionDefinitionCode:
					return dimensionDefinitionID_DimensionDefinitionCode;
				case Field.DimensionDefinitionID_DimensionDefinitionName:
					return dimensionDefinitionID_DimensionDefinitionName;
				case Field.UpperLocationID_CumulativeLocationCode:
					return upperLocationID_CumulativeLocationCode;
				case Field.UpperLocationID_LocationCode:
					return upperLocationID_LocationCode;
				case Field.UpperLocationID_UpperLocationID:
					return upperLocationID_UpperLocationID;
				case Field.LocationHierarchyID_LocationHierarchyCode:
					return locationHierarchyID_LocationHierarchyCode;
				case Field.LocationHierarchyID_LocationHierarchyName:
					return locationHierarchyID_LocationHierarchyName;
				case Field.LocationHierarchyID_LocationTypeID:
					return locationHierarchyID_LocationTypeID;
				case Field.LocationHierarchyID_UpperLocationHierarchyID:
					return locationHierarchyID_UpperLocationHierarchyID;
				case Field.CreatedBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
				case Field.ModifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeCode:
					return locationHierarchyID_LocationTypeID_LocationTypeCode;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeName:
					return locationHierarchyID_LocationTypeID_LocationTypeName;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID:
					return locationHierarchyID_LocationTypeID_WarehouseID;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode:
					return locationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseName:
					return locationHierarchyID_LocationTypeID_WarehouseID_WarehouseName;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode:
					return locationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode;
				case Field.IsReceivingLocation:
					return isReceivingLocation;
				case Field.IsStorageLocation:
					return isStorageLocation;
				case Field.IsDispatchLocation:
					return isDispatchLocation;
				case Field.IsMoveableLocation:
					return isMoveableLocation;
				case Field.IsDamageLocation:
					return isDamageLocation;
				case Field.LocationTypeCode:
					return locationTypeCode;
				case Field.LocationTypeID:
					return locationTypeID;
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
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.IsUsable:
					return typeof(bool?);
				case Field.IsPicking:
					return typeof(bool?);
				case Field.LocationCode:
					return typeof(string);
				case Field.LocationHierarchyID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
				case Field.LocationPriority:
					return typeof(int?);
				case Field.UpperLocationID:
					return typeof(int?);
				case Field.IsUnderStocktaking:
					return typeof(bool?);
				case Field.DimensionDefinitionID_DimensionDefinitionCode:
					return typeof(string);
				case Field.DimensionDefinitionID_DimensionDefinitionName:
					return typeof(string);
				case Field.UpperLocationID_CumulativeLocationCode:
					return typeof(string);
				case Field.UpperLocationID_LocationCode:
					return typeof(string);
				case Field.UpperLocationID_UpperLocationID:
					return typeof(int?);
				case Field.LocationHierarchyID_LocationHierarchyCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationHierarchyName:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID:
					return typeof(int?);
				case Field.LocationHierarchyID_UpperLocationHierarchyID:
					return typeof(int?);
				case Field.CreatedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.ModifiedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeName:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID:
					return typeof(int?);
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseName:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode:
					return typeof(string);
				case Field.IsReceivingLocation:
					return typeof(bool?);
				case Field.IsStorageLocation:
					return typeof(bool?);
				case Field.IsDispatchLocation:
					return typeof(bool?);
				case Field.IsMoveableLocation:
					return typeof(bool?);
				case Field.IsDamageLocation:
					return typeof(bool?);
				case Field.LocationTypeCode:
					return typeof(string);
				case Field.LocationTypeID:
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
				case Field.IsUsable:
					isUsable = value;
					break;
				case Field.IsPicking:
					isPicking = value;
					break;
				case Field.IsUnderStocktaking:
					isUnderStocktaking = value;
					break;
				case Field.IsReceivingLocation:
					isReceivingLocation = value;
					break;
				case Field.IsStorageLocation:
					isStorageLocation = value;
					break;
				case Field.IsDispatchLocation:
					isDispatchLocation = value;
					break;
				case Field.IsMoveableLocation:
					isMoveableLocation = value;
					break;
				case Field.IsDamageLocation:
					isDamageLocation = value;
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
				case Field.LocationHierarchyID:
					locationHierarchyID = value;
					break;
				case Field.LocationID:
					locationID = value;
					break;
				case Field.LocationPriority:
					locationPriority = value;
					break;
				case Field.UpperLocationID:
					upperLocationID = value;
					break;
				case Field.UpperLocationID_UpperLocationID:
					upperLocationID_UpperLocationID = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID:
					locationHierarchyID_LocationTypeID = value;
					break;
				case Field.LocationHierarchyID_UpperLocationHierarchyID:
					locationHierarchyID_UpperLocationHierarchyID = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID:
					locationHierarchyID_LocationTypeID_WarehouseID = value;
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
				case Field.LocationCode:
					locationCode = value;
					break;
				case Field.DimensionDefinitionID_DimensionDefinitionCode:
					dimensionDefinitionID_DimensionDefinitionCode = value;
					break;
				case Field.DimensionDefinitionID_DimensionDefinitionName:
					dimensionDefinitionID_DimensionDefinitionName = value;
					break;
				case Field.UpperLocationID_CumulativeLocationCode:
					upperLocationID_CumulativeLocationCode = value;
					break;
				case Field.UpperLocationID_LocationCode:
					upperLocationID_LocationCode = value;
					break;
				case Field.LocationHierarchyID_LocationHierarchyCode:
					locationHierarchyID_LocationHierarchyCode = value;
					break;
				case Field.LocationHierarchyID_LocationHierarchyName:
					locationHierarchyID_LocationHierarchyName = value;
					break;
				case Field.CreatedBy_PalmsUserLoginName:
					createdBy_PalmsUserLoginName = value;
					break;
				case Field.ModifiedBy_PalmsUserLoginName:
					modifiedBy_PalmsUserLoginName = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeCode:
					locationHierarchyID_LocationTypeID_LocationTypeCode = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeName:
					locationHierarchyID_LocationTypeID_LocationTypeName = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode:
					locationHierarchyID_LocationTypeID_WarehouseID_WarehouseCode = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseName:
					locationHierarchyID_LocationTypeID_WarehouseID_WarehouseName = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode:
					locationHierarchyID_LocationTypeID_WarehouseID_WarehouseShipToCode = value;
					break;
				case Field.LocationTypeCode:
					locationTypeCode = value;
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
