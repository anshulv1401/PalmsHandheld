//// Warning: Do not modify!
//// This file (PartStockWithEmptyLocationForHandheldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '01 June 2015' at '14:28:32'
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
	public partial class PartStockWithEmptyLocationForHandheldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			STIPartStockKey
			, PrimaryCompanyID
			, WarehouseID
			, WarehousePrimaryCompanyID
			, CostBucketID
			, StockTakingInstructionID
			, StockTakingInstructionNo
			, PartID
			, PartCode
			, PartName
			, StockBucketID
			, StockBucketCode
			, StockBucketName
			, LocationID
			, CumulativeLocationCode
			, PackID
			, PackNo
			, OriginalPackNo
			, PartBatchID
			, PartBatchNo
			, ManufacturingDate
			, ExpiryDate
			, SerialNo
			, Quantity
			, UOMID
			, UOMCode
			, UOMName
			, SalesOrderID
			, SalesOrderNo
			, SalesOrderLineNo
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public string sTIPartStockKey;
		public int? primaryCompanyID;
		public int? warehouseID;
		public int? warehousePrimaryCompanyID;
		public int? costBucketID;
		public int? stockTakingInstructionID;
		public string stockTakingInstructionNo;
		public int? partID;
		public string partCode;
		public string partName;
		public int? stockBucketID;
		public string stockBucketCode;
		public string stockBucketName;
		public int? locationID;
		public string cumulativeLocationCode;
		public int? packID;
		public string packNo;
		public string originalPackNo;
		public int? partBatchID;
		public string partBatchNo;
		public DateTime? manufacturingDate;
		public DateTime? expiryDate;
		public string serialNo;
		public decimal? quantity;
		public int? uOMID;
		public string uOMCode;
		public string uOMName;
		public int? salesOrderID;
		public string salesOrderNo;
		public int? salesOrderLineNo;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new PartStockWithEmptyLocationForHandheldCustomSearchViewPrimaryKey()
			{
				warehouseID = (int)warehouseID
				, primaryCompanyID = (int)primaryCompanyID
				, costBucketID = (int)costBucketID
				, warehousePrimaryCompanyID = (int)warehousePrimaryCompanyID
				, sTIPartStockKey = (string)sTIPartStockKey
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new PartStockWithEmptyLocationForHandheldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<PartStockWithEmptyLocationForHandheldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new PartStockWithEmptyLocationForHandheldCustomSearchViewUniqueKey()
					{
						warehouseID = (int?)warehouseID
						, primaryCompanyID = (int?)primaryCompanyID
						, costBucketID = (int?)costBucketID
						, warehousePrimaryCompanyID = (int?)warehousePrimaryCompanyID
						, sTIPartStockKey = (string)sTIPartStockKey
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

		public EntityKey<PartStockWithEmptyLocationForHandheldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new PartStockWithEmptyLocationForHandheldCustomSearchViewUniqueKey();
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
				case Field.STIPartStockKey:
					return sTIPartStockKey;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.WarehouseID:
					return warehouseID;
				case Field.WarehousePrimaryCompanyID:
					return warehousePrimaryCompanyID;
				case Field.CostBucketID:
					return costBucketID;
				case Field.StockTakingInstructionID:
					return stockTakingInstructionID;
				case Field.StockTakingInstructionNo:
					return stockTakingInstructionNo;
				case Field.PartID:
					return partID;
				case Field.PartCode:
					return partCode;
				case Field.PartName:
					return partName;
				case Field.StockBucketID:
					return stockBucketID;
				case Field.StockBucketCode:
					return stockBucketCode;
				case Field.StockBucketName:
					return stockBucketName;
				case Field.LocationID:
					return locationID;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.PackID:
					return packID;
				case Field.PackNo:
					return packNo;
				case Field.OriginalPackNo:
					return originalPackNo;
				case Field.PartBatchID:
					return partBatchID;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.ExpiryDate:
					return expiryDate;
				case Field.SerialNo:
					return serialNo;
				case Field.Quantity:
					return quantity;
				case Field.UOMID:
					return uOMID;
				case Field.UOMCode:
					return uOMCode;
				case Field.UOMName:
					return uOMName;
				case Field.SalesOrderID:
					return salesOrderID;
				case Field.SalesOrderNo:
					return salesOrderNo;
				case Field.SalesOrderLineNo:
					return salesOrderLineNo;
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
				case Field.STIPartStockKey:
					return typeof(string);
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.WarehouseID:
					return typeof(int?);
				case Field.WarehousePrimaryCompanyID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
				case Field.StockTakingInstructionID:
					return typeof(int?);
				case Field.StockTakingInstructionNo:
					return typeof(string);
				case Field.PartID:
					return typeof(int?);
				case Field.PartCode:
					return typeof(string);
				case Field.PartName:
					return typeof(string);
				case Field.StockBucketID:
					return typeof(int?);
				case Field.StockBucketCode:
					return typeof(string);
				case Field.StockBucketName:
					return typeof(string);
				case Field.LocationID:
					return typeof(int?);
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.PackID:
					return typeof(int?);
				case Field.PackNo:
					return typeof(string);
				case Field.OriginalPackNo:
					return typeof(string);
				case Field.PartBatchID:
					return typeof(int?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.ExpiryDate:
					return typeof(DateTime?);
				case Field.SerialNo:
					return typeof(string);
				case Field.Quantity:
					return typeof(decimal?);
				case Field.UOMID:
					return typeof(int?);
				case Field.UOMCode:
					return typeof(string);
				case Field.UOMName:
					return typeof(string);
				case Field.SalesOrderID:
					return typeof(int?);
				case Field.SalesOrderNo:
					return typeof(string);
				case Field.SalesOrderLineNo:
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
				case Field.WarehousePrimaryCompanyID:
					warehousePrimaryCompanyID = value;
					break;
				case Field.CostBucketID:
					costBucketID = value;
					break;
				case Field.StockTakingInstructionID:
					stockTakingInstructionID = value;
					break;
				case Field.PartID:
					partID = value;
					break;
				case Field.StockBucketID:
					stockBucketID = value;
					break;
				case Field.LocationID:
					locationID = value;
					break;
				case Field.PackID:
					packID = value;
					break;
				case Field.PartBatchID:
					partBatchID = value;
					break;
				case Field.UOMID:
					uOMID = value;
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
				case Field.Quantity:
					quantity = value;
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
				case Field.STIPartStockKey:
					sTIPartStockKey = value;
					break;
				case Field.StockTakingInstructionNo:
					stockTakingInstructionNo = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.PartName:
					partName = value;
					break;
				case Field.StockBucketCode:
					stockBucketCode = value;
					break;
				case Field.StockBucketName:
					stockBucketName = value;
					break;
				case Field.CumulativeLocationCode:
					cumulativeLocationCode = value;
					break;
				case Field.PackNo:
					packNo = value;
					break;
				case Field.OriginalPackNo:
					originalPackNo = value;
					break;
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.UOMCode:
					uOMCode = value;
					break;
				case Field.UOMName:
					uOMName = value;
					break;
				case Field.SalesOrderNo:
					salesOrderNo = value;
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
