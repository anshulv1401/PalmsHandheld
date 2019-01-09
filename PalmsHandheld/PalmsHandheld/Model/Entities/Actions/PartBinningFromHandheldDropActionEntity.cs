//// Warning: Do not modify!
//// This file (PartBinningFromHandheldDropActionEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '08 April 2013' at '13:46:46'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Actions
{
	[Serializable]
	public partial class PartBinningFromHandheldDropActionEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			WarehouseID
			, PrimaryCompanyID
			, CostBucketID
			, DroppedQuantityInStorageUOM
			, DroppedLocationID
			, LiftNo
			, ReferenceLineNo
			, StockChangeInstructionID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? warehouseID;
		public int? primaryCompanyID;
		public int? costBucketID;
		public decimal? droppedQuantityInStorageUOM;
		public int? droppedLocationID;
		public int? liftNo;
		public int? referenceLineNo;
		public int? stockChangeInstructionID;

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
				case Field.WarehouseID:
					return warehouseID;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.CostBucketID:
					return costBucketID;
				case Field.DroppedQuantityInStorageUOM:
					return droppedQuantityInStorageUOM;
				case Field.DroppedLocationID:
					return droppedLocationID;
				case Field.LiftNo:
					return liftNo;
				case Field.ReferenceLineNo:
					return referenceLineNo;
				case Field.StockChangeInstructionID:
					return stockChangeInstructionID;
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
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
				case Field.DroppedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.DroppedLocationID:
					return typeof(int?);
				case Field.LiftNo:
					return typeof(int?);
				case Field.ReferenceLineNo:
					return typeof(int?);
				case Field.StockChangeInstructionID:
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
				case Field.PrimaryCompanyID:
					primaryCompanyID = value;
					break;
				case Field.CostBucketID:
					costBucketID = value;
					break;
				case Field.DroppedLocationID:
					droppedLocationID = value;
					break;
				case Field.LiftNo:
					liftNo = value;
					break;
				case Field.ReferenceLineNo:
					referenceLineNo = value;
					break;
				case Field.StockChangeInstructionID:
					stockChangeInstructionID = value;
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
				case Field.DroppedQuantityInStorageUOM:
					droppedQuantityInStorageUOM = value;
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
