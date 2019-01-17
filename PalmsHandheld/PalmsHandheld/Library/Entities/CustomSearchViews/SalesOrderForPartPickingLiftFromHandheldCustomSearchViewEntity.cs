//// Warning: Do not modify!
//// This file (SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Friday, December 29, 2017' at '4:58:49 PM'
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
	public partial class SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, StockChangeInstructionID
			, StockChangeInstructionLineNo
			, StockChangeDocumentLineNo
			, PartID
			, PartCode
			, StorageUOMID
			, StorageUOMCode
			, StorageUOMCategory
			, StorageUOM
			, BillingUOMID
			, BillingUOMCode
			, BillingUOMCategory
			, BillingUOM
			, PartCostID
			, SalesOrderID
			, SalesOrderLineNo
			, IsFractionalQuantityAllowed
			
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
		public int? stockChangeInstructionID;
		public int? stockChangeInstructionLineNo;
		public string stockChangeDocumentLineNo;
		public int? partID;
		public string partCode;
		public int? storageUOMID;
		public string storageUOMCode;
		public int? storageUOMCategory;
		public decimal? storageUOM;
		public int? billingUOMID;
		public string billingUOMCode;
		public int? billingUOMCategory;
		public decimal? billingUOM;
		public int? partCostID;
		public int? salesOrderID;
		public int? salesOrderLineNo;
		public bool? isFractionalQuantityAllowed;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
            return (IEntityKey<Entity>)new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewPrimaryKey()
			{
				primaryCompanyID = (int)primaryCompanyID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
            return (IEntityKey<Entity>)new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey )
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

            return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewUniqueKey()
					{
						primaryCompanyID = (int?)primaryCompanyID
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

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey,false));
		}

		public EntityKey<SalesOrderForPartPickingLiftFromHandheldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new SalesOrderForPartPickingLiftFromHandheldCustomSearchViewUniqueKey();
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
				case Field.StockChangeInstructionID:
					return stockChangeInstructionID;
				case Field.StockChangeInstructionLineNo:
					return stockChangeInstructionLineNo;
				case Field.StockChangeDocumentLineNo:
					return stockChangeDocumentLineNo;
				case Field.PartID:
					return partID;
				case Field.PartCode:
					return partCode;
				case Field.StorageUOMID:
					return storageUOMID;
				case Field.StorageUOMCode:
					return storageUOMCode;
				case Field.StorageUOMCategory:
					return storageUOMCategory;
				case Field.StorageUOM:
					return storageUOM;
				case Field.BillingUOMID:
					return billingUOMID;
				case Field.BillingUOMCode:
					return billingUOMCode;
				case Field.BillingUOMCategory:
					return billingUOMCategory;
				case Field.BillingUOM:
					return billingUOM;
				case Field.PartCostID:
					return partCostID;
				case Field.SalesOrderID:
					return salesOrderID;
				case Field.SalesOrderLineNo:
					return salesOrderLineNo;
				case Field.IsFractionalQuantityAllowed:
					return isFractionalQuantityAllowed;
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
				case Field.StockChangeInstructionID:
					return typeof(int?);
				case Field.StockChangeInstructionLineNo:
					return typeof(int?);
				case Field.StockChangeDocumentLineNo:
					return typeof(string);
				case Field.PartID:
					return typeof(int?);
				case Field.PartCode:
					return typeof(string);
				case Field.StorageUOMID:
					return typeof(int?);
				case Field.StorageUOMCode:
					return typeof(string);
				case Field.StorageUOMCategory:
					return typeof(int?);
				case Field.StorageUOM:
					return typeof(decimal?);
				case Field.BillingUOMID:
					return typeof(int?);
				case Field.BillingUOMCode:
					return typeof(string);
				case Field.BillingUOMCategory:
					return typeof(int?);
				case Field.BillingUOM:
					return typeof(decimal?);
				case Field.PartCostID:
					return typeof(int?);
				case Field.SalesOrderID:
					return typeof(int?);
				case Field.SalesOrderLineNo:
					return typeof(int?);
				case Field.IsFractionalQuantityAllowed:
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
				case Field.IsFractionalQuantityAllowed:
					isFractionalQuantityAllowed = value;
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
				case Field.StockChangeInstructionID:
					stockChangeInstructionID = value;
					break;
				case Field.StockChangeInstructionLineNo:
					stockChangeInstructionLineNo = value;
					break;
				case Field.PartID:
					partID = value;
					break;
				case Field.StorageUOMID:
					storageUOMID = value;
					break;
				case Field.StorageUOMCategory:
					storageUOMCategory = value;
					break;
				case Field.BillingUOMID:
					billingUOMID = value;
					break;
				case Field.BillingUOMCategory:
					billingUOMCategory = value;
					break;
				case Field.PartCostID:
					partCostID = value;
					break;
				case Field.SalesOrderID:
					salesOrderID = value;
					break;
				case Field.SalesOrderLineNo:
					salesOrderLineNo = value;
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
				case Field.StorageUOM:
					storageUOM = value;
					break;
				case Field.BillingUOM:
					billingUOM = value;
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
				case Field.StockChangeDocumentLineNo:
					stockChangeDocumentLineNo = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.StorageUOMCode:
					storageUOMCode = value;
					break;
				case Field.BillingUOMCode:
					billingUOMCode = value;
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