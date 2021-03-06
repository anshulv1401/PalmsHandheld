//// Warning: Do not modify!
//// This file (CycleCountInstructionLineEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Friday, June 1, 2018' at '10:53:59 AM'
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
	public partial class CycleCountInstructionLineEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, CycleCountInstructionID
			, PartID
			, CostBucketID_CostBucketCode
			, CostBucketID_CostBucketName
			, CycleCountInstructionID_CycleCountInstructionNo
			, CreatedBy_PalmsUserLoginName
			, ModifiedBy_PalmsUserLoginName
			, PartID_PartCode
			, PrimaryCompanyID_DocumentNoPrefix
			, PrimaryCompanyID_PrimaryCompanyCode
			, PrimaryCompanyID_PrimaryCompanyName
			, WarehouseID_DocumentNoPrefix
			, WarehouseID_WarehouseCode
			, WarehouseID_WarehouseName
			, WarehouseID_WarehouseShipToCode
			, WarehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode
			
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
		public int? partID;
		public string costBucketID_CostBucketCode;
		public string costBucketID_CostBucketName;
		public string cycleCountInstructionID_CycleCountInstructionNo;
		public string createdBy_PalmsUserLoginName;
		public string modifiedBy_PalmsUserLoginName;
		public string partID_PartCode;
		public string primaryCompanyID_DocumentNoPrefix;
		public string primaryCompanyID_PrimaryCompanyCode;
		public string primaryCompanyID_PrimaryCompanyName;
		public string warehouseID_DocumentNoPrefix;
		public string warehouseID_WarehouseCode;
		public string warehouseID_WarehouseName;
		public string warehouseID_WarehouseShipToCode;
		public string warehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new CycleCountInstructionLinePrimaryKey()
			{
				costBucketID = (int)costBucketID
				, cycleCountInstructionID = (int)cycleCountInstructionID
				, partID = (int)partID
				, primaryCompanyID = (int)primaryCompanyID
				, warehouseID = (int)warehouseID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new CycleCountInstructionLinePrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<CycleCountInstructionLineEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new CycleCountInstructionLineUniqueKey()
					{
						costBucketID = (int?)costBucketID
						, cycleCountInstructionID = (int?)cycleCountInstructionID
						, partID = (int?)partID
						, primaryCompanyID = (int?)primaryCompanyID
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

		public EntityKey<CycleCountInstructionLineEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new CycleCountInstructionLineUniqueKey();
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
				case Field.PartID:
					return partID;
				case Field.CostBucketID_CostBucketCode:
					return costBucketID_CostBucketCode;
				case Field.CostBucketID_CostBucketName:
					return costBucketID_CostBucketName;
				case Field.CycleCountInstructionID_CycleCountInstructionNo:
					return cycleCountInstructionID_CycleCountInstructionNo;
				case Field.CreatedBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
				case Field.ModifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
				case Field.PartID_PartCode:
					return partID_PartCode;
				case Field.PrimaryCompanyID_DocumentNoPrefix:
					return primaryCompanyID_DocumentNoPrefix;
				case Field.PrimaryCompanyID_PrimaryCompanyCode:
					return primaryCompanyID_PrimaryCompanyCode;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return primaryCompanyID_PrimaryCompanyName;
				case Field.WarehouseID_DocumentNoPrefix:
					return warehouseID_DocumentNoPrefix;
				case Field.WarehouseID_WarehouseCode:
					return warehouseID_WarehouseCode;
				case Field.WarehouseID_WarehouseName:
					return warehouseID_WarehouseName;
				case Field.WarehouseID_WarehouseShipToCode:
					return warehouseID_WarehouseShipToCode;
				case Field.WarehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode:
					return warehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode;
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
				case Field.PartID:
					return typeof(int?);
				case Field.CostBucketID_CostBucketCode:
					return typeof(string);
				case Field.CostBucketID_CostBucketName:
					return typeof(string);
				case Field.CycleCountInstructionID_CycleCountInstructionNo:
					return typeof(string);
				case Field.CreatedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.ModifiedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.PartID_PartCode:
					return typeof(string);
				case Field.PrimaryCompanyID_DocumentNoPrefix:
					return typeof(string);
				case Field.PrimaryCompanyID_PrimaryCompanyCode:
					return typeof(string);
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return typeof(string);
				case Field.WarehouseID_DocumentNoPrefix:
					return typeof(string);
				case Field.WarehouseID_WarehouseCode:
					return typeof(string);
				case Field.WarehouseID_WarehouseName:
					return typeof(string);
				case Field.WarehouseID_WarehouseShipToCode:
					return typeof(string);
				case Field.WarehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode:
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
				case Field.CycleCountInstructionID:
					cycleCountInstructionID = value;
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
				case Field.CostBucketID_CostBucketCode:
					costBucketID_CostBucketCode = value;
					break;
				case Field.CostBucketID_CostBucketName:
					costBucketID_CostBucketName = value;
					break;
				case Field.CycleCountInstructionID_CycleCountInstructionNo:
					cycleCountInstructionID_CycleCountInstructionNo = value;
					break;
				case Field.CreatedBy_PalmsUserLoginName:
					createdBy_PalmsUserLoginName = value;
					break;
				case Field.ModifiedBy_PalmsUserLoginName:
					modifiedBy_PalmsUserLoginName = value;
					break;
				case Field.PartID_PartCode:
					partID_PartCode = value;
					break;
				case Field.PrimaryCompanyID_DocumentNoPrefix:
					primaryCompanyID_DocumentNoPrefix = value;
					break;
				case Field.PrimaryCompanyID_PrimaryCompanyCode:
					primaryCompanyID_PrimaryCompanyCode = value;
					break;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					primaryCompanyID_PrimaryCompanyName = value;
					break;
				case Field.WarehouseID_DocumentNoPrefix:
					warehouseID_DocumentNoPrefix = value;
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
				case Field.WarehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode:
					warehousePrimaryCompanyID_WarehousePrimaryCompanyShipToCode = value;
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
