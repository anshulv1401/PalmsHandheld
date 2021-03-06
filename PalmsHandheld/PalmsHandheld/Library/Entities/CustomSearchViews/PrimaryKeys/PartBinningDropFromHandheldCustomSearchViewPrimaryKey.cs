//// Warning: Do not modify!
//// This file (PartBinningDropFromHandheldCustomSearchViewPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, March 2, 2017' at '9:47:34 AM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys
{
	[Serializable]
	public partial class PartBinningDropFromHandheldCustomSearchViewPrimaryKey : EntityKey<PartBinningDropFromHandheldCustomSearchViewEntity>
	{
		#region Enums

		public enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, StockChangeInstructionID
			, StockChangeInstructionLineNo
			, LiftNo
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? warehouseID;
		public int? costBucketID;
		public int? stockChangeInstructionID;
		public int? stockChangeInstructionLineNo;
		public int? liftNo;

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
				case Field.LiftNo:
					return liftNo;
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
				case Field.LiftNo:
					return typeof(int?);
			}

			return null;
		}

		public override PartBinningDropFromHandheldCustomSearchViewEntity GetBlankEntityWithKey()
		{
			return new PartBinningDropFromHandheldCustomSearchViewEntity()
			{
				primaryCompanyID = primaryCompanyID
				, warehouseID = warehouseID
				, costBucketID = costBucketID
				, stockChangeInstructionID = stockChangeInstructionID
				, stockChangeInstructionLineNo = stockChangeInstructionLineNo
				, liftNo = liftNo
			};
		}

		public override string GetClassName()
		{
			return "PartBinningDropFromHandheldCustomSearchViewPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}
