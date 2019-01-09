//// Warning: Do not modify!
//// This file (InvoiceCreationFromHandHeldCustomSearchViewPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, March 2, 2017' at '6:24:20 PM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.CustomSearchViews.PrimaryKeys
{
	[Serializable]
	public partial class InvoiceCreationFromHandHeldCustomSearchViewPrimaryKey : EntityKey<InvoiceCreationFromHandHeldCustomSearchViewEntity>
	{
		#region Enums

		public enum Field
		{
			PartBatchID
			, FromLocationID
			, PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? partBatchID;
		public int? fromLocationID;
		public int? primaryCompanyID;
		public int? warehouseID;
		public int? costBucketID;

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
				case Field.PartBatchID:
					return partBatchID;
				case Field.FromLocationID:
					return fromLocationID;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.WarehouseID:
					return warehouseID;
				case Field.CostBucketID:
					return costBucketID;
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
				case Field.PartBatchID:
					return typeof(int?);
				case Field.FromLocationID:
					return typeof(int?);
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
			}

			return null;
		}

		public override InvoiceCreationFromHandHeldCustomSearchViewEntity GetBlankEntityWithKey()
		{
			return new InvoiceCreationFromHandHeldCustomSearchViewEntity()
			{
				partBatchID = partBatchID
				, fromLocationID = fromLocationID
				, primaryCompanyID = primaryCompanyID
				, warehouseID = warehouseID
				, costBucketID = costBucketID
			};
		}

		public override string GetClassName()
		{
			return "InvoiceCreationFromHandHeldCustomSearchViewPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}