//// Warning: Do not modify!
//// This file (LocationEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '15 June 2012' at '14:02:23'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;
using Technoforte.PALMS.Entities.Views.PrimaryKeys;
using Technoforte.PALMS.Entities.Views.UniqueKeys;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views
{
	[Serializable]
	public partial class LocationEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, LocationHierarchyID
			, LocationID
			, LocationCode
			, CumulativeLocationCode
			, UpperLocationID
			, DimensionDefinitionID
			, LocationRestrictionID
			, IsUsable
			, LocationPriority
			, BinningSequenceNo
			, PickingSequenceNo
			, ReservedForPrimaryCompanyID
			, IsUnderStocktaking
			, DimensionDefinitionID_DimensionDefinitionCode
			, DimensionDefinitionID_DimensionDefinitionName
			, UpperLocationID_CumulativeLocationCode
			, LocationHierarchyID_LocationHierarchyCode
			, LocationHierarchyID_LocationHierarchyName
			, LocationHierarchyID_LocationTypeID
			, LocationRestrictionID_LocationRestrictionCode
			, LocationRestrictionID_LocationRestrictionName
			, CreatedBy_PalmsUserLoginName
			, ModifiedBy_PalmsUserLoginName
			, ReservedForPrimaryCompanyID_PrimaryCompanyCode
			, ReservedForPrimaryCompanyID_PrimaryCompanyName
			, WarehouseID_WarehouseCode
			, WarehouseID_WarehouseName
			, WarehouseID_WarehouseShipToCode
			, LocationHierarchyID_LocationTypeID_LocationTypeCode
			, LocationHierarchyID_LocationTypeID_LocationTypeName
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			CumulativeCode
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? locationHierarchyID;
		public int? locationID;
		public string locationCode;
		public string cumulativeLocationCode;
		public int? upperLocationID;
		public int? dimensionDefinitionID;
		public int? locationRestrictionID;
		public bool? isUsable;
		public int? locationPriority;
		public int? binningSequenceNo;
		public int? pickingSequenceNo;
		public int? reservedForPrimaryCompanyID;
		public bool? isUnderStocktaking;
		public string dimensionDefinitionID_DimensionDefinitionCode;
		public string dimensionDefinitionID_DimensionDefinitionName;
		public string upperLocationID_CumulativeLocationCode;
		public string locationHierarchyID_LocationHierarchyCode;
		public string locationHierarchyID_LocationHierarchyName;
		public int? locationHierarchyID_LocationTypeID;
		public string locationRestrictionID_LocationRestrictionCode;
		public string locationRestrictionID_LocationRestrictionName;
		public string createdBy_PalmsUserLoginName;
		public string modifiedBy_PalmsUserLoginName;
		public string reservedForPrimaryCompanyID_PrimaryCompanyCode;
		public string reservedForPrimaryCompanyID_PrimaryCompanyName;
		public string warehouseID_WarehouseCode;
		public string warehouseID_WarehouseName;
		public string warehouseID_WarehouseShipToCode;
		public string locationHierarchyID_LocationTypeID_LocationTypeCode;
		public string locationHierarchyID_LocationTypeID_LocationTypeName;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new LocationPrimaryKey()
			{
				locationID = (int)locationID
				, warehouseID = (int)warehouseID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new LocationPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "CumulativeCode";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<LocationEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.CumulativeCode:
					return new LocationUniqueKey_CumulativeCode()
					{
						cumulativeLocationCode = (string)cumulativeLocationCode
						, warehouseID = (int?)warehouseID
					};
			}

			return null;
		}

		public override IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "CumulativeCode";
			}

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<LocationEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.CumulativeCode:
					return new LocationUniqueKey_CumulativeCode();
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
				case Field.LocationHierarchyID:
					return locationHierarchyID;
				case Field.LocationID:
					return locationID;
				case Field.LocationCode:
					return locationCode;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.UpperLocationID:
					return upperLocationID;
				case Field.DimensionDefinitionID:
					return dimensionDefinitionID;
				case Field.LocationRestrictionID:
					return locationRestrictionID;
				case Field.IsUsable:
					return isUsable;
				case Field.LocationPriority:
					return locationPriority;
				case Field.BinningSequenceNo:
					return binningSequenceNo;
				case Field.PickingSequenceNo:
					return pickingSequenceNo;
				case Field.ReservedForPrimaryCompanyID:
					return reservedForPrimaryCompanyID;
				case Field.IsUnderStocktaking:
					return isUnderStocktaking;
				case Field.DimensionDefinitionID_DimensionDefinitionCode:
					return dimensionDefinitionID_DimensionDefinitionCode;
				case Field.DimensionDefinitionID_DimensionDefinitionName:
					return dimensionDefinitionID_DimensionDefinitionName;
				case Field.UpperLocationID_CumulativeLocationCode:
					return upperLocationID_CumulativeLocationCode;
				case Field.LocationHierarchyID_LocationHierarchyCode:
					return locationHierarchyID_LocationHierarchyCode;
				case Field.LocationHierarchyID_LocationHierarchyName:
					return locationHierarchyID_LocationHierarchyName;
				case Field.LocationHierarchyID_LocationTypeID:
					return locationHierarchyID_LocationTypeID;
				case Field.LocationRestrictionID_LocationRestrictionCode:
					return locationRestrictionID_LocationRestrictionCode;
				case Field.LocationRestrictionID_LocationRestrictionName:
					return locationRestrictionID_LocationRestrictionName;
				case Field.CreatedBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
				case Field.ModifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
				case Field.ReservedForPrimaryCompanyID_PrimaryCompanyCode:
					return reservedForPrimaryCompanyID_PrimaryCompanyCode;
				case Field.ReservedForPrimaryCompanyID_PrimaryCompanyName:
					return reservedForPrimaryCompanyID_PrimaryCompanyName;
				case Field.WarehouseID_WarehouseCode:
					return warehouseID_WarehouseCode;
				case Field.WarehouseID_WarehouseName:
					return warehouseID_WarehouseName;
				case Field.WarehouseID_WarehouseShipToCode:
					return warehouseID_WarehouseShipToCode;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeCode:
					return locationHierarchyID_LocationTypeID_LocationTypeCode;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeName:
					return locationHierarchyID_LocationTypeID_LocationTypeName;
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
				case Field.LocationHierarchyID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
				case Field.LocationCode:
					return typeof(string);
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.UpperLocationID:
					return typeof(int?);
				case Field.DimensionDefinitionID:
					return typeof(int?);
				case Field.LocationRestrictionID:
					return typeof(int?);
				case Field.IsUsable:
					return typeof(bool?);
				case Field.LocationPriority:
					return typeof(int?);
				case Field.BinningSequenceNo:
					return typeof(int?);
				case Field.PickingSequenceNo:
					return typeof(int?);
				case Field.ReservedForPrimaryCompanyID:
					return typeof(int?);
				case Field.IsUnderStocktaking:
					return typeof(bool?);
				case Field.DimensionDefinitionID_DimensionDefinitionCode:
					return typeof(string);
				case Field.DimensionDefinitionID_DimensionDefinitionName:
					return typeof(string);
				case Field.UpperLocationID_CumulativeLocationCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationHierarchyCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationHierarchyName:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID:
					return typeof(int?);
				case Field.LocationRestrictionID_LocationRestrictionCode:
					return typeof(string);
				case Field.LocationRestrictionID_LocationRestrictionName:
					return typeof(string);
				case Field.CreatedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.ModifiedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.ReservedForPrimaryCompanyID_PrimaryCompanyCode:
					return typeof(string);
				case Field.ReservedForPrimaryCompanyID_PrimaryCompanyName:
					return typeof(string);
				case Field.WarehouseID_WarehouseCode:
					return typeof(string);
				case Field.WarehouseID_WarehouseName:
					return typeof(string);
				case Field.WarehouseID_WarehouseShipToCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeCode:
					return typeof(string);
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeName:
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
				case Field.IsUsable:
					isUsable = value;
					break;
				case Field.IsUnderStocktaking:
					isUnderStocktaking = value;
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
				case Field.UpperLocationID:
					upperLocationID = value;
					break;
				case Field.DimensionDefinitionID:
					dimensionDefinitionID = value;
					break;
				case Field.LocationRestrictionID:
					locationRestrictionID = value;
					break;
				case Field.LocationPriority:
					locationPriority = value;
					break;
				case Field.BinningSequenceNo:
					binningSequenceNo = value;
					break;
				case Field.PickingSequenceNo:
					pickingSequenceNo = value;
					break;
				case Field.ReservedForPrimaryCompanyID:
					reservedForPrimaryCompanyID = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID:
					locationHierarchyID_LocationTypeID = value;
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
				case Field.LocationCode:
					locationCode = value;
					break;
				case Field.CumulativeLocationCode:
					cumulativeLocationCode = value;
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
				case Field.LocationHierarchyID_LocationHierarchyCode:
					locationHierarchyID_LocationHierarchyCode = value;
					break;
				case Field.LocationHierarchyID_LocationHierarchyName:
					locationHierarchyID_LocationHierarchyName = value;
					break;
				case Field.LocationRestrictionID_LocationRestrictionCode:
					locationRestrictionID_LocationRestrictionCode = value;
					break;
				case Field.LocationRestrictionID_LocationRestrictionName:
					locationRestrictionID_LocationRestrictionName = value;
					break;
				case Field.CreatedBy_PalmsUserLoginName:
					createdBy_PalmsUserLoginName = value;
					break;
				case Field.ModifiedBy_PalmsUserLoginName:
					modifiedBy_PalmsUserLoginName = value;
					break;
				case Field.ReservedForPrimaryCompanyID_PrimaryCompanyCode:
					reservedForPrimaryCompanyID_PrimaryCompanyCode = value;
					break;
				case Field.ReservedForPrimaryCompanyID_PrimaryCompanyName:
					reservedForPrimaryCompanyID_PrimaryCompanyName = value;
					break;
				case Field.WarehouseID_WarehouseCode:
					warehouseID_WarehouseCode = value;
					break;
				case Field.WarehouseID_WarehouseName:
					warehouseID_WarehouseName = value;
					break;
				case Field.WarehouseID_WarehouseShipToCode:
					warehouseID_WarehouseShipToCode = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeCode:
					locationHierarchyID_LocationTypeID_LocationTypeCode = value;
					break;
				case Field.LocationHierarchyID_LocationTypeID_LocationTypeName:
					locationHierarchyID_LocationTypeID_LocationTypeName = value;
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
			if ((Field)field == Field.LocationID)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion Overriding / Public Members
	}
}
