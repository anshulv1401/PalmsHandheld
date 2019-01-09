//// Warning: Do not modify!
//// This file (WeightCaptureForGateInwardFromHHTActionEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, August 23, 2018' at '12:52:41 PM'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Actions
{
	[Serializable]
	public partial class WeightCaptureForGateInwardFromHHTActionEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, PartStockID
			, PartID
			, LocationID
			, PartBatchID
			, IncomingWeight
			, GateInwardID
			, GateInwardLineNo
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? warehouseID;
		public int? costBucketID;
		public int? warehousePrimaryCompanyID;
		public int? partStockID;
		public int? partID;
		public int? locationID;
		public int? partBatchID;
		public decimal? incomingWeight;
		public int? gateInwardID;
		public int? gateInwardLineNo;

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
				case Field.WarehousePrimaryCompanyID:
					return warehousePrimaryCompanyID;
				case Field.PartStockID:
					return partStockID;
				case Field.PartID:
					return partID;
				case Field.LocationID:
					return locationID;
				case Field.PartBatchID:
					return partBatchID;
				case Field.IncomingWeight:
					return incomingWeight;
				case Field.GateInwardID:
					return gateInwardID;
				case Field.GateInwardLineNo:
					return gateInwardLineNo;
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
				case Field.PartStockID:
					return typeof(int?);
				case Field.PartID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
				case Field.PartBatchID:
					return typeof(int?);
				case Field.IncomingWeight:
					return typeof(decimal?);
				case Field.GateInwardID:
					return typeof(int?);
				case Field.GateInwardLineNo:
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
				case Field.PartStockID:
					partStockID = value;
					break;
				case Field.PartID:
					partID = value;
					break;
				case Field.LocationID:
					locationID = value;
					break;
				case Field.PartBatchID:
					partBatchID = value;
					break;
				case Field.GateInwardID:
					gateInwardID = value;
					break;
				case Field.GateInwardLineNo:
					gateInwardLineNo = value;
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
				case Field.IncomingWeight:
					incomingWeight = value;
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