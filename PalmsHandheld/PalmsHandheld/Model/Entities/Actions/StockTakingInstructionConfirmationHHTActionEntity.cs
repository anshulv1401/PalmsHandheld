//// Warning: Do not modify!
//// This file (StockTakingInstructionConfirmationHHTActionEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '22 May 2015' at '09:06:33'
//// If modification is required, consider 'partial class'.

using System;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Actions
{
	[Serializable]
	public partial class StockTakingInstructionConfirmationHHTActionEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, CostBucketID
			, WarehousePrimaryCompanyID
			, OKQuantityInStorageUOM
			, DamagedQuantityInStorageUOM
			, PartBatchNo
			, SerialNo
			, PackNo
			, ManufacturingDate
			, ExpiryDate
			, LocationID
			, StockTakingInstructionID
			, DamageLocationID
			, PartID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? warehouseID;
		public int? costBucketID;
		public int? warehousePrimaryCompanyID;
		public decimal? oKQuantityInStorageUOM;
		public decimal? damagedQuantityInStorageUOM;
		public string partBatchNo;
		public string serialNo;
		public string packNo;
		public DateTime? manufacturingDate;
		public DateTime? expiryDate;
		public int? locationID;
		public int? stockTakingInstructionID;
		public int? damageLocationID;
		public int? partID;

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
				case Field.OKQuantityInStorageUOM:
					return oKQuantityInStorageUOM;
				case Field.DamagedQuantityInStorageUOM:
					return damagedQuantityInStorageUOM;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.SerialNo:
					return serialNo;
				case Field.PackNo:
					return packNo;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.LocationID:
					return locationID;
				case Field.StockTakingInstructionID:
					return stockTakingInstructionID;
				case Field.DamageLocationID:
					return damageLocationID;
				case Field.PartID:
					return partID;
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
				case Field.OKQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.DamagedQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.SerialNo:
					return typeof(string);
				case Field.PackNo:
					return typeof(string);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.LocationID:
					return typeof(int?);
				case Field.StockTakingInstructionID:
					return typeof(int?);
				case Field.DamageLocationID:
					return typeof(int?);
				case Field.PartID:
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
				case Field.LocationID:
					locationID = value;
					break;
				case Field.StockTakingInstructionID:
					stockTakingInstructionID = value;
					break;
				case Field.DamageLocationID:
					damageLocationID = value;
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
				case Field.OKQuantityInStorageUOM:
					oKQuantityInStorageUOM = value;
					break;
				case Field.DamagedQuantityInStorageUOM:
					damagedQuantityInStorageUOM = value;
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
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.PackNo:
					packNo = value;
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
				case Field.ManufacturingDate:
					manufacturingDate = value;
					break;
				case Field.ExpiryDate:
					expiryDate = value;
					break;
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