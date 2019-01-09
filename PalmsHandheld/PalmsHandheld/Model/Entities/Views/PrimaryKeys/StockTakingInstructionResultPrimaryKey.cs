//// Warning: Do not modify!
//// This file (StockTakingInstructionResultPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on '22 May 2015' at '15:04:36'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.PrimaryKeys
{
	[Serializable]
	public partial class StockTakingInstructionResultPrimaryKey : EntityKey<StockTakingInstructionResultEntity>
	{
		#region Enums

		public enum Field
		{
			CostBucketID
			, PrimaryCompanyID
			, StockTakingInstructionResultID
			, WarehouseID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? costBucketID;
		public int? primaryCompanyID;
		public int? stockTakingInstructionResultID;
		public int? warehouseID;

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
				case Field.CostBucketID:
					return costBucketID;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.StockTakingInstructionResultID:
					return stockTakingInstructionResultID;
				case Field.WarehouseID:
					return warehouseID;
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
				case Field.CostBucketID:
					return typeof(int?);
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.StockTakingInstructionResultID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
			}

			return null;
		}

		public override StockTakingInstructionResultEntity GetBlankEntityWithKey()
		{
			return new StockTakingInstructionResultEntity()
			{
				costBucketID = costBucketID
				, primaryCompanyID = primaryCompanyID
				, stockTakingInstructionResultID = stockTakingInstructionResultID
				, warehouseID = warehouseID
			};
		}

		public override string GetClassName()
		{
			return "StockTakingInstructionResultPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}
