//// Warning: Do not modify!
//// This file (TransactionTypeEntity.cs) has been auto-generated by PALMS Entity Generation Tool on 'Tuesday, July 26, 2016' at '11:33:26 AM'
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
	public partial class TransactionTypeEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			TransactionTypeID
			, TransactionTypeName
			, TransactionTypeCode
			, FromStockBucketID
			, ToStockBucketID
			, IsWriteOffTransaction
			, IsStockTransferTransaction
			, ToLocationTypeID
			, FromLocationTypeID
			, IsPackMovement
			, IsPartMovement
			, IsAutoConfirmed
			, IsPacking
			, IsUnpacking
			, IsUserRequested
			, IsExcessPermitted
			, IsShortagePermitted
			, IsDamagePermitted
			, IsSortedByFromLocation
			, IsSortedByToLocation
			, IsBatchModifiable
			, IsAutoRollbackOnLocationSuggestionFailure
			, NotificationText
			, IsInboundTransaction
			, IsOutboundTransaction
			, IsInStockTransaction
			, IsSalesOrderReferenceToBeCleared
			, IsLocationSuggestionRequired
			, ActionOnAutoLocationSuggestionFailure
			, IsMixedShippingInfoPackTypesAllowed
			, IsSwappingAllowed
			, OkDropExportFile
			, IsAvailableForQuickTransfer
			, IsPartialKITQuantityAllowed
			, CreatedBy_PalmsUserLoginName
			, ModifiedBy_PalmsUserLoginName
			, FromStockBucketID_StockBucketCode
			, FromStockBucketID_StockBucketName
			, ToStockBucketID_StockBucketCode
			, ToStockBucketID_StockBucketName
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Code
			, Name
		}

		#endregion Enums

		#region Members

		public int? transactionTypeID;
		public string transactionTypeName;
		public string transactionTypeCode;
		public int? fromStockBucketID;
		public int? toStockBucketID;
		public bool? isWriteOffTransaction;
		public bool? isStockTransferTransaction;
		public int? toLocationTypeID;
		public int? fromLocationTypeID;
		public bool? isPackMovement;
		public bool? isPartMovement;
		public bool? isAutoConfirmed;
		public bool? isPacking;
		public bool? isUnpacking;
		public bool? isUserRequested;
		public bool? isExcessPermitted;
		public bool? isShortagePermitted;
		public bool? isDamagePermitted;
		public bool? isSortedByFromLocation;
		public bool? isSortedByToLocation;
		public bool? isBatchModifiable;
		public bool? isAutoRollbackOnLocationSuggestionFailure;
		public string notificationText;
		public bool? isInboundTransaction;
		public bool? isOutboundTransaction;
		public bool? isInStockTransaction;
		public bool? isSalesOrderReferenceToBeCleared;
		public bool? isLocationSuggestionRequired;
		public int? actionOnAutoLocationSuggestionFailure;
		public bool? isMixedShippingInfoPackTypesAllowed;
		public bool? isSwappingAllowed;
		public string okDropExportFile;
		public bool? isAvailableForQuickTransfer;
		public bool? isPartialKITQuantityAllowed;
		public string createdBy_PalmsUserLoginName;
		public string modifiedBy_PalmsUserLoginName;
		public string fromStockBucketID_StockBucketCode;
		public string fromStockBucketID_StockBucketName;
		public string toStockBucketID_StockBucketCode;
		public string toStockBucketID_StockBucketName;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new TransactionTypePrimaryKey()
			{
				transactionTypeID = (int)transactionTypeID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new TransactionTypePrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Name";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<TransactionTypeEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Code:
					return new TransactionTypeUniqueKey_Code()
					{
						transactionTypeCode = (string)transactionTypeCode
					};
				case UniqueKey.Name:
					return new TransactionTypeUniqueKey_Name()
					{
						transactionTypeName = (string)transactionTypeName
					};
			}

			return null;
		}

		public override IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Name";
			}

			return (IEntityKey<Entity>)GetBlankUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<TransactionTypeEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Code:
					return new TransactionTypeUniqueKey_Code();
				case UniqueKey.Name:
					return new TransactionTypeUniqueKey_Name();
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
				case Field.TransactionTypeID:
					return transactionTypeID;
				case Field.TransactionTypeName:
					return transactionTypeName;
				case Field.TransactionTypeCode:
					return transactionTypeCode;
				case Field.FromStockBucketID:
					return fromStockBucketID;
				case Field.ToStockBucketID:
					return toStockBucketID;
				case Field.IsWriteOffTransaction:
					return isWriteOffTransaction;
				case Field.IsStockTransferTransaction:
					return isStockTransferTransaction;
				case Field.ToLocationTypeID:
					return toLocationTypeID;
				case Field.FromLocationTypeID:
					return fromLocationTypeID;
				case Field.IsPackMovement:
					return isPackMovement;
				case Field.IsPartMovement:
					return isPartMovement;
				case Field.IsAutoConfirmed:
					return isAutoConfirmed;
				case Field.IsPacking:
					return isPacking;
				case Field.IsUnpacking:
					return isUnpacking;
				case Field.IsUserRequested:
					return isUserRequested;
				case Field.IsExcessPermitted:
					return isExcessPermitted;
				case Field.IsShortagePermitted:
					return isShortagePermitted;
				case Field.IsDamagePermitted:
					return isDamagePermitted;
				case Field.IsSortedByFromLocation:
					return isSortedByFromLocation;
				case Field.IsSortedByToLocation:
					return isSortedByToLocation;
				case Field.IsBatchModifiable:
					return isBatchModifiable;
				case Field.IsAutoRollbackOnLocationSuggestionFailure:
					return isAutoRollbackOnLocationSuggestionFailure;
				case Field.NotificationText:
					return notificationText;
				case Field.IsInboundTransaction:
					return isInboundTransaction;
				case Field.IsOutboundTransaction:
					return isOutboundTransaction;
				case Field.IsInStockTransaction:
					return isInStockTransaction;
				case Field.IsSalesOrderReferenceToBeCleared:
					return isSalesOrderReferenceToBeCleared;
				case Field.IsLocationSuggestionRequired:
					return isLocationSuggestionRequired;
				case Field.ActionOnAutoLocationSuggestionFailure:
					return actionOnAutoLocationSuggestionFailure;
				case Field.IsMixedShippingInfoPackTypesAllowed:
					return isMixedShippingInfoPackTypesAllowed;
				case Field.IsSwappingAllowed:
					return isSwappingAllowed;
				case Field.OkDropExportFile:
					return okDropExportFile;
				case Field.IsAvailableForQuickTransfer:
					return isAvailableForQuickTransfer;
				case Field.IsPartialKITQuantityAllowed:
					return isPartialKITQuantityAllowed;
				case Field.CreatedBy_PalmsUserLoginName:
					return createdBy_PalmsUserLoginName;
				case Field.ModifiedBy_PalmsUserLoginName:
					return modifiedBy_PalmsUserLoginName;
				case Field.FromStockBucketID_StockBucketCode:
					return fromStockBucketID_StockBucketCode;
				case Field.FromStockBucketID_StockBucketName:
					return fromStockBucketID_StockBucketName;
				case Field.ToStockBucketID_StockBucketCode:
					return toStockBucketID_StockBucketCode;
				case Field.ToStockBucketID_StockBucketName:
					return toStockBucketID_StockBucketName;
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
				case Field.TransactionTypeID:
					return typeof(int?);
				case Field.TransactionTypeName:
					return typeof(string);
				case Field.TransactionTypeCode:
					return typeof(string);
				case Field.FromStockBucketID:
					return typeof(int?);
				case Field.ToStockBucketID:
					return typeof(int?);
				case Field.IsWriteOffTransaction:
					return typeof(bool?);
				case Field.IsStockTransferTransaction:
					return typeof(bool?);
				case Field.ToLocationTypeID:
					return typeof(int?);
				case Field.FromLocationTypeID:
					return typeof(int?);
				case Field.IsPackMovement:
					return typeof(bool?);
				case Field.IsPartMovement:
					return typeof(bool?);
				case Field.IsAutoConfirmed:
					return typeof(bool?);
				case Field.IsPacking:
					return typeof(bool?);
				case Field.IsUnpacking:
					return typeof(bool?);
				case Field.IsUserRequested:
					return typeof(bool?);
				case Field.IsExcessPermitted:
					return typeof(bool?);
				case Field.IsShortagePermitted:
					return typeof(bool?);
				case Field.IsDamagePermitted:
					return typeof(bool?);
				case Field.IsSortedByFromLocation:
					return typeof(bool?);
				case Field.IsSortedByToLocation:
					return typeof(bool?);
				case Field.IsBatchModifiable:
					return typeof(bool?);
				case Field.IsAutoRollbackOnLocationSuggestionFailure:
					return typeof(bool?);
				case Field.NotificationText:
					return typeof(string);
				case Field.IsInboundTransaction:
					return typeof(bool?);
				case Field.IsOutboundTransaction:
					return typeof(bool?);
				case Field.IsInStockTransaction:
					return typeof(bool?);
				case Field.IsSalesOrderReferenceToBeCleared:
					return typeof(bool?);
				case Field.IsLocationSuggestionRequired:
					return typeof(bool?);
				case Field.ActionOnAutoLocationSuggestionFailure:
					return typeof(int?);
				case Field.IsMixedShippingInfoPackTypesAllowed:
					return typeof(bool?);
				case Field.IsSwappingAllowed:
					return typeof(bool?);
				case Field.OkDropExportFile:
					return typeof(string);
				case Field.IsAvailableForQuickTransfer:
					return typeof(bool?);
				case Field.IsPartialKITQuantityAllowed:
					return typeof(bool?);
				case Field.CreatedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.ModifiedBy_PalmsUserLoginName:
					return typeof(string);
				case Field.FromStockBucketID_StockBucketCode:
					return typeof(string);
				case Field.FromStockBucketID_StockBucketName:
					return typeof(string);
				case Field.ToStockBucketID_StockBucketCode:
					return typeof(string);
				case Field.ToStockBucketID_StockBucketName:
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
				case Field.IsWriteOffTransaction:
					isWriteOffTransaction = value;
					break;
				case Field.IsStockTransferTransaction:
					isStockTransferTransaction = value;
					break;
				case Field.IsPackMovement:
					isPackMovement = value;
					break;
				case Field.IsPartMovement:
					isPartMovement = value;
					break;
				case Field.IsAutoConfirmed:
					isAutoConfirmed = value;
					break;
				case Field.IsPacking:
					isPacking = value;
					break;
				case Field.IsUnpacking:
					isUnpacking = value;
					break;
				case Field.IsUserRequested:
					isUserRequested = value;
					break;
				case Field.IsExcessPermitted:
					isExcessPermitted = value;
					break;
				case Field.IsShortagePermitted:
					isShortagePermitted = value;
					break;
				case Field.IsDamagePermitted:
					isDamagePermitted = value;
					break;
				case Field.IsSortedByFromLocation:
					isSortedByFromLocation = value;
					break;
				case Field.IsSortedByToLocation:
					isSortedByToLocation = value;
					break;
				case Field.IsBatchModifiable:
					isBatchModifiable = value;
					break;
				case Field.IsAutoRollbackOnLocationSuggestionFailure:
					isAutoRollbackOnLocationSuggestionFailure = value;
					break;
				case Field.IsInboundTransaction:
					isInboundTransaction = value;
					break;
				case Field.IsOutboundTransaction:
					isOutboundTransaction = value;
					break;
				case Field.IsInStockTransaction:
					isInStockTransaction = value;
					break;
				case Field.IsSalesOrderReferenceToBeCleared:
					isSalesOrderReferenceToBeCleared = value;
					break;
				case Field.IsLocationSuggestionRequired:
					isLocationSuggestionRequired = value;
					break;
				case Field.IsMixedShippingInfoPackTypesAllowed:
					isMixedShippingInfoPackTypesAllowed = value;
					break;
				case Field.IsSwappingAllowed:
					isSwappingAllowed = value;
					break;
				case Field.IsAvailableForQuickTransfer:
					isAvailableForQuickTransfer = value;
					break;
				case Field.IsPartialKITQuantityAllowed:
					isPartialKITQuantityAllowed = value;
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
				case Field.TransactionTypeID:
					transactionTypeID = value;
					break;
				case Field.FromStockBucketID:
					fromStockBucketID = value;
					break;
				case Field.ToStockBucketID:
					toStockBucketID = value;
					break;
				case Field.ToLocationTypeID:
					toLocationTypeID = value;
					break;
				case Field.FromLocationTypeID:
					fromLocationTypeID = value;
					break;
				case Field.ActionOnAutoLocationSuggestionFailure:
					actionOnAutoLocationSuggestionFailure = value;
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
				case Field.TransactionTypeName:
					transactionTypeName = value;
					break;
				case Field.TransactionTypeCode:
					transactionTypeCode = value;
					break;
				case Field.NotificationText:
					notificationText = value;
					break;
				case Field.OkDropExportFile:
					okDropExportFile = value;
					break;
				case Field.CreatedBy_PalmsUserLoginName:
					createdBy_PalmsUserLoginName = value;
					break;
				case Field.ModifiedBy_PalmsUserLoginName:
					modifiedBy_PalmsUserLoginName = value;
					break;
				case Field.FromStockBucketID_StockBucketCode:
					fromStockBucketID_StockBucketCode = value;
					break;
				case Field.FromStockBucketID_StockBucketName:
					fromStockBucketID_StockBucketName = value;
					break;
				case Field.ToStockBucketID_StockBucketCode:
					toStockBucketID_StockBucketCode = value;
					break;
				case Field.ToStockBucketID_StockBucketName:
					toStockBucketID_StockBucketName = value;
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
			if ((Field)field == Field.TransactionTypeID)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		#endregion Overriding / Public Members
	}
}
