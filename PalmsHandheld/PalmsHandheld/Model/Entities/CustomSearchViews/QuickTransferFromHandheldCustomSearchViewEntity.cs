//// Warning: Do not modify!
//// This file (QuickTransferFromHandheldCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Thursday, May 24, 2018' at '11:37:41 AM'
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
	public partial class QuickTransferFromHandheldCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, WarehouseID
			, WarehousePrimaryCompanyID
			, CostBucketID
			, PartCostID
			, PartStockID
			, StockBucketID
			, LocationID
			, PartBatchID
			, BucketQuantityInStorageUOM
			, SalesOrderID
			, SalesOrderLineNo
			, ShippingInformationID
			, IsScanningCompulsory
			, TransactionTypeID
			, TransactionTypeCode
			, IsAvailableForQuickTransfer
			, StockBucketCode
			, StockBucketName
			, CumulativeLocationCode
			, IsUnderStocktaking
			, IsUsable
			, PartBatchNo
			, ManufacturingDate
			, SerialNo
			, PartCode
			, IsExpirySensitive
			, IsSerialNumberTracked
			, IsTrackedByManufactureDate
			, PackID
			, IsBatchSensitive
			, IsFractionalQuantityAllowed
			, UOMCode
			, partid
			, ExpiryDate
			
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
		public int? warehousePrimaryCompanyID;
		public int? costBucketID;
		public int? partCostID;
		public int? partStockID;
		public int? stockBucketID;
		public int? locationID;
		public int? partBatchID;
		public decimal? bucketQuantityInStorageUOM;
		public int? salesOrderID;
		public int? salesOrderLineNo;
		public int? shippingInformationID;
		public bool? isScanningCompulsory;
		public int? transactionTypeID;
		public string transactionTypeCode;
		public bool? isAvailableForQuickTransfer;
		public string stockBucketCode;
		public string stockBucketName;
		public string cumulativeLocationCode;
		public bool? isUnderStocktaking;
		public bool? isUsable;
		public string partBatchNo;
		public DateTime? manufacturingDate;
		public string serialNo;
		public string partCode;
		public bool? isExpirySensitive;
		public bool? isSerialNumberTracked;
		public bool? isTrackedByManufactureDate;
		public int? packID;
		public bool? isBatchSensitive;
		public bool? isFractionalQuantityAllowed;
		public string uOMCode;
		public int? partid;
		public DateTime? expiryDate;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
            return (IEntityKey <Entity>) new QuickTransferFromHandheldCustomSearchViewPrimaryKey()
			{
				primaryCompanyID = (int)primaryCompanyID
				, warehouseID = (int)warehouseID
				, costBucketID = (int)costBucketID
				, partStockID = (int)partStockID
				, partBatchID = (int)partBatchID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new QuickTransferFromHandheldCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey,false));
		}

		public EntityKey<QuickTransferFromHandheldCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey )
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new QuickTransferFromHandheldCustomSearchViewUniqueKey()
					{
						primaryCompanyID = (int?)primaryCompanyID
						, warehouseID = (int?)warehouseID
						, costBucketID = (int?)costBucketID
						, partStockID = (int?)partStockID
						, partBatchID = (int?)partBatchID
					};
			}

			return null;
		}

		public override IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey )
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey,false));
		}

		public EntityKey<QuickTransferFromHandheldCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey )
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new QuickTransferFromHandheldCustomSearchViewUniqueKey();
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
				case Field.WarehousePrimaryCompanyID:
					return warehousePrimaryCompanyID;
				case Field.CostBucketID:
					return costBucketID;
				case Field.PartCostID:
					return partCostID;
				case Field.PartStockID:
					return partStockID;
				case Field.StockBucketID:
					return stockBucketID;
				case Field.LocationID:
					return locationID;
				case Field.PartBatchID:
					return partBatchID;
				case Field.BucketQuantityInStorageUOM:
					return bucketQuantityInStorageUOM;
				case Field.SalesOrderID:
					return salesOrderID;
				case Field.SalesOrderLineNo:
					return salesOrderLineNo;
				case Field.ShippingInformationID:
					return shippingInformationID;
				case Field.IsScanningCompulsory:
					return isScanningCompulsory;
				case Field.TransactionTypeID:
					return transactionTypeID;
				case Field.TransactionTypeCode:
					return transactionTypeCode;
				case Field.IsAvailableForQuickTransfer:
					return isAvailableForQuickTransfer;
				case Field.StockBucketCode:
					return stockBucketCode;
				case Field.StockBucketName:
					return stockBucketName;
				case Field.CumulativeLocationCode:
					return cumulativeLocationCode;
				case Field.IsUnderStocktaking:
					return isUnderStocktaking;
				case Field.IsUsable:
					return isUsable;
				case Field.PartBatchNo:
					return partBatchNo;
				case Field.ManufacturingDate:
					return manufacturingDate;
				case Field.SerialNo:
					return serialNo;
				case Field.PartCode:
					return partCode;
				case Field.IsExpirySensitive:
					return isExpirySensitive;
				case Field.IsSerialNumberTracked:
					return isSerialNumberTracked;
				case Field.IsTrackedByManufactureDate:
					return isTrackedByManufactureDate;
				case Field.PackID:
					return packID;
				case Field.IsBatchSensitive:
					return isBatchSensitive;
				case Field.IsFractionalQuantityAllowed:
					return isFractionalQuantityAllowed;
				case Field.UOMCode:
					return uOMCode;
				case Field.partid:
					return partid;
				case Field.ExpiryDate:
					return expiryDate;
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
				case Field.WarehousePrimaryCompanyID:
					return typeof(int?);
				case Field.CostBucketID:
					return typeof(int?);
				case Field.PartCostID:
					return typeof(int?);
				case Field.PartStockID:
					return typeof(int?);
				case Field.StockBucketID:
					return typeof(int?);
				case Field.LocationID:
					return typeof(int?);
				case Field.PartBatchID:
					return typeof(int?);
				case Field.BucketQuantityInStorageUOM:
					return typeof(decimal?);
				case Field.SalesOrderID:
					return typeof(int?);
				case Field.SalesOrderLineNo:
					return typeof(int?);
				case Field.ShippingInformationID:
					return typeof(int?);
				case Field.IsScanningCompulsory:
					return typeof(bool?);
				case Field.TransactionTypeID:
					return typeof(int?);
				case Field.TransactionTypeCode:
					return typeof(string);
				case Field.IsAvailableForQuickTransfer:
					return typeof(bool?);
				case Field.StockBucketCode:
					return typeof(string);
				case Field.StockBucketName:
					return typeof(string);
				case Field.CumulativeLocationCode:
					return typeof(string);
				case Field.IsUnderStocktaking:
					return typeof(bool?);
				case Field.IsUsable:
					return typeof(bool?);
				case Field.PartBatchNo:
					return typeof(string);
				case Field.ManufacturingDate:
					return typeof(DateTime?);
				case Field.SerialNo:
					return typeof(string);
				case Field.PartCode:
					return typeof(string);
				case Field.IsExpirySensitive:
					return typeof(bool?);
				case Field.IsSerialNumberTracked:
					return typeof(bool?);
				case Field.IsTrackedByManufactureDate:
					return typeof(bool?);
				case Field.PackID:
					return typeof(int?);
				case Field.IsBatchSensitive:
					return typeof(bool?);
				case Field.IsFractionalQuantityAllowed:
					return typeof(bool?);
				case Field.UOMCode:
					return typeof(string);
				case Field.partid:
					return typeof(int?);
				case Field.ExpiryDate:
					return typeof(DateTime?);

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
				case Field.IsScanningCompulsory:
					isScanningCompulsory = value;
					break;
				case Field.IsAvailableForQuickTransfer:
					isAvailableForQuickTransfer = value;
					break;
				case Field.IsUnderStocktaking:
					isUnderStocktaking = value;
					break;
				case Field.IsUsable:
					isUsable = value;
					break;
				case Field.IsExpirySensitive:
					isExpirySensitive = value;
					break;
				case Field.IsSerialNumberTracked:
					isSerialNumberTracked = value;
					break;
				case Field.IsTrackedByManufactureDate:
					isTrackedByManufactureDate = value;
					break;
				case Field.IsBatchSensitive:
					isBatchSensitive = value;
					break;
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
				case Field.WarehousePrimaryCompanyID:
					warehousePrimaryCompanyID = value;
					break;
				case Field.CostBucketID:
					costBucketID = value;
					break;
				case Field.PartCostID:
					partCostID = value;
					break;
				case Field.PartStockID:
					partStockID = value;
					break;
				case Field.StockBucketID:
					stockBucketID = value;
					break;
				case Field.LocationID:
					locationID = value;
					break;
				case Field.PartBatchID:
					partBatchID = value;
					break;
				case Field.SalesOrderID:
					salesOrderID = value;
					break;
				case Field.SalesOrderLineNo:
					salesOrderLineNo = value;
					break;
				case Field.ShippingInformationID:
					shippingInformationID = value;
					break;
				case Field.TransactionTypeID:
					transactionTypeID = value;
					break;
				case Field.PackID:
					packID = value;
					break;
				case Field.partid:
					partid = value;
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
				case Field.BucketQuantityInStorageUOM:
					bucketQuantityInStorageUOM = value;
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
				case Field.TransactionTypeCode:
					transactionTypeCode = value;
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
				case Field.PartBatchNo:
					partBatchNo = value;
					break;
				case Field.SerialNo:
					serialNo = value;
					break;
				case Field.PartCode:
					partCode = value;
					break;
				case Field.UOMCode:
					uOMCode = value;
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