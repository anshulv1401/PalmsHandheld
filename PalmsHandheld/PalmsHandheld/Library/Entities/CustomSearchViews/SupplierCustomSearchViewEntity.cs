//// Warning: Do not modify!
//// This file (SupplierCustomSearchViewEntity.cs) has been auto-generated by PALMS Entity Generation Tool on '27 September 2013' at '17:20:55'
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
	public partial class SupplierCustomSearchViewEntity : Entity
	{
		#region Enums

		public new enum Field
		{
			PrimaryCompanyID
			, AddressID
			, DefaultFreightForwarderID
			, DefaultPurchaseOrderTypeID
			, DefaultShippingModeIDForBackOrders
			, DefaultShippingModeIDForForecastOrders
			, DefaultTradeTermID
			, ShipToCode
			, SupplierCode
			, SupplierCurrencyID
			, SupplierID
			, SupplierName
			, PrimaryCompanyID_PrimaryCompanyCode
			, PrimaryCompanyID_PrimaryCompanyName
			, CityID
			, AddressID_ContactName
			, CountryID
			, AddressID_Line1
			, AddressID_Line2
			, AddressID_OtherCityName
			, AddressID_OtherStateName
			, AddressID_PostalCode
			, AddressID_PostBoxNumber
			, StateID
			, AddressID_InternationalDialingCode
			, AddressID_AreaDialingCode
			, AddressID_PhoneNumber
			, AddressID_PhoneExtensionNumber
			, AddressID_MobileNumber
			, AddressID_FaxNumber
			, AddressID_Email
			, SupplierCurrencyID_CurrencyCode
			, SupplierCurrencyID_CurrencyName
			, SupplierCurrencyID_CurrencySymbol
			, DefaultFreightForwarderID_FreightForwarderCode
			, DefaultFreightForwarderID_FreightForwarderName
			, DefaultPurchaseOrderTypeID_PurchaseOrderTypeCode
			, DefaultPurchaseOrderTypeID_PurchaseOrderTypeName
			, DefaultShippingModeIDForBackOrders_ShippingModeCode
			, DefaultShippingModeIDForBackOrders_ShippingModeName
			, DefaultShippingModeIDForForecastOrders_ShippingModeCode
			, DefaultShippingModeIDForForecastOrders_ShippingModeName
			, DefaultTradeTermID_TradeTermCode
			, DefaultTradeTermID_TradeTermName
			, CountryID_CountryCode
			, CountryID_CountryName
			, StateID_StateCode
			, StateID_StateName
			, CityID_CityCode
			, CityID_CityName
			
			, _FieldCount
		}

		public enum UniqueKey
		{
			Default
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? addressID;
		public int? defaultFreightForwarderID;
		public int? defaultPurchaseOrderTypeID;
		public int? defaultShippingModeIDForBackOrders;
		public int? defaultShippingModeIDForForecastOrders;
		public int? defaultTradeTermID;
		public string shipToCode;
		public string supplierCode;
		public int? supplierCurrencyID;
		public int? supplierID;
		public string supplierName;
		public string primaryCompanyID_PrimaryCompanyCode;
		public string primaryCompanyID_PrimaryCompanyName;
		public int? cityID;
		public string addressID_ContactName;
		public int? countryID;
		public string addressID_Line1;
		public string addressID_Line2;
		public string addressID_OtherCityName;
		public string addressID_OtherStateName;
		public string addressID_PostalCode;
		public string addressID_PostBoxNumber;
		public int? stateID;
		public string addressID_InternationalDialingCode;
		public string addressID_AreaDialingCode;
		public string addressID_PhoneNumber;
		public string addressID_PhoneExtensionNumber;
		public string addressID_MobileNumber;
		public string addressID_FaxNumber;
		public string addressID_Email;
		public string supplierCurrencyID_CurrencyCode;
		public string supplierCurrencyID_CurrencyName;
		public string supplierCurrencyID_CurrencySymbol;
		public string defaultFreightForwarderID_FreightForwarderCode;
		public string defaultFreightForwarderID_FreightForwarderName;
		public string defaultPurchaseOrderTypeID_PurchaseOrderTypeCode;
		public string defaultPurchaseOrderTypeID_PurchaseOrderTypeName;
		public string defaultShippingModeIDForBackOrders_ShippingModeCode;
		public string defaultShippingModeIDForBackOrders_ShippingModeName;
		public string defaultShippingModeIDForForecastOrders_ShippingModeCode;
		public string defaultShippingModeIDForForecastOrders_ShippingModeName;
		public string defaultTradeTermID_TradeTermCode;
		public string defaultTradeTermID_TradeTermName;
		public string countryID_CountryCode;
		public string countryID_CountryName;
		public string stateID_StateCode;
		public string stateID_StateName;
		public string cityID_CityCode;
		public string cityID_CityName;

		#endregion Members

		#region Overriding / Public Members

		public override IEntityKey<Entity> GetPrimaryKey()
		{
			return (IEntityKey<Entity>)new SupplierCustomSearchViewPrimaryKey()
			{
				primaryCompanyID = (int)primaryCompanyID
				, supplierID = (int)supplierID
			};
		}

		public override IEntityKey<Entity> GetBlankPrimaryKey()
		{
			return (IEntityKey<Entity>)new SupplierCustomSearchViewPrimaryKey();
		}

		public override IEntityKey<Entity> GetUniqueKey(string uniqueKey)
		{
			if (uniqueKey == "")
			{
				uniqueKey = "Default";
			}

			return (IEntityKey<Entity>)GetUniqueKey((UniqueKey)Enum.Parse(typeof(UniqueKey), uniqueKey, false));
		}

		public EntityKey<SupplierCustomSearchViewEntity> GetUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new SupplierCustomSearchViewUniqueKey()
					{
						primaryCompanyID = (int?)primaryCompanyID
						, supplierName = (string)supplierName
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

		public EntityKey<SupplierCustomSearchViewEntity> GetBlankUniqueKey(UniqueKey uniqueKey)
		{
			switch (uniqueKey)
			{
				case UniqueKey.Default:
					return new SupplierCustomSearchViewUniqueKey();
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
				case Field.AddressID:
					return addressID;
				case Field.DefaultFreightForwarderID:
					return defaultFreightForwarderID;
				case Field.DefaultPurchaseOrderTypeID:
					return defaultPurchaseOrderTypeID;
				case Field.DefaultShippingModeIDForBackOrders:
					return defaultShippingModeIDForBackOrders;
				case Field.DefaultShippingModeIDForForecastOrders:
					return defaultShippingModeIDForForecastOrders;
				case Field.DefaultTradeTermID:
					return defaultTradeTermID;
				case Field.ShipToCode:
					return shipToCode;
				case Field.SupplierCode:
					return supplierCode;
				case Field.SupplierCurrencyID:
					return supplierCurrencyID;
				case Field.SupplierID:
					return supplierID;
				case Field.SupplierName:
					return supplierName;
				case Field.PrimaryCompanyID_PrimaryCompanyCode:
					return primaryCompanyID_PrimaryCompanyCode;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return primaryCompanyID_PrimaryCompanyName;
				case Field.CityID:
					return cityID;
				case Field.AddressID_ContactName:
					return addressID_ContactName;
				case Field.CountryID:
					return countryID;
				case Field.AddressID_Line1:
					return addressID_Line1;
				case Field.AddressID_Line2:
					return addressID_Line2;
				case Field.AddressID_OtherCityName:
					return addressID_OtherCityName;
				case Field.AddressID_OtherStateName:
					return addressID_OtherStateName;
				case Field.AddressID_PostalCode:
					return addressID_PostalCode;
				case Field.AddressID_PostBoxNumber:
					return addressID_PostBoxNumber;
				case Field.StateID:
					return stateID;
				case Field.AddressID_InternationalDialingCode:
					return addressID_InternationalDialingCode;
				case Field.AddressID_AreaDialingCode:
					return addressID_AreaDialingCode;
				case Field.AddressID_PhoneNumber:
					return addressID_PhoneNumber;
				case Field.AddressID_PhoneExtensionNumber:
					return addressID_PhoneExtensionNumber;
				case Field.AddressID_MobileNumber:
					return addressID_MobileNumber;
				case Field.AddressID_FaxNumber:
					return addressID_FaxNumber;
				case Field.AddressID_Email:
					return addressID_Email;
				case Field.SupplierCurrencyID_CurrencyCode:
					return supplierCurrencyID_CurrencyCode;
				case Field.SupplierCurrencyID_CurrencyName:
					return supplierCurrencyID_CurrencyName;
				case Field.SupplierCurrencyID_CurrencySymbol:
					return supplierCurrencyID_CurrencySymbol;
				case Field.DefaultFreightForwarderID_FreightForwarderCode:
					return defaultFreightForwarderID_FreightForwarderCode;
				case Field.DefaultFreightForwarderID_FreightForwarderName:
					return defaultFreightForwarderID_FreightForwarderName;
				case Field.DefaultPurchaseOrderTypeID_PurchaseOrderTypeCode:
					return defaultPurchaseOrderTypeID_PurchaseOrderTypeCode;
				case Field.DefaultPurchaseOrderTypeID_PurchaseOrderTypeName:
					return defaultPurchaseOrderTypeID_PurchaseOrderTypeName;
				case Field.DefaultShippingModeIDForBackOrders_ShippingModeCode:
					return defaultShippingModeIDForBackOrders_ShippingModeCode;
				case Field.DefaultShippingModeIDForBackOrders_ShippingModeName:
					return defaultShippingModeIDForBackOrders_ShippingModeName;
				case Field.DefaultShippingModeIDForForecastOrders_ShippingModeCode:
					return defaultShippingModeIDForForecastOrders_ShippingModeCode;
				case Field.DefaultShippingModeIDForForecastOrders_ShippingModeName:
					return defaultShippingModeIDForForecastOrders_ShippingModeName;
				case Field.DefaultTradeTermID_TradeTermCode:
					return defaultTradeTermID_TradeTermCode;
				case Field.DefaultTradeTermID_TradeTermName:
					return defaultTradeTermID_TradeTermName;
				case Field.CountryID_CountryCode:
					return countryID_CountryCode;
				case Field.CountryID_CountryName:
					return countryID_CountryName;
				case Field.StateID_StateCode:
					return stateID_StateCode;
				case Field.StateID_StateName:
					return stateID_StateName;
				case Field.CityID_CityCode:
					return cityID_CityCode;
				case Field.CityID_CityName:
					return cityID_CityName;
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
				case Field.AddressID:
					return typeof(int?);
				case Field.DefaultFreightForwarderID:
					return typeof(int?);
				case Field.DefaultPurchaseOrderTypeID:
					return typeof(int?);
				case Field.DefaultShippingModeIDForBackOrders:
					return typeof(int?);
				case Field.DefaultShippingModeIDForForecastOrders:
					return typeof(int?);
				case Field.DefaultTradeTermID:
					return typeof(int?);
				case Field.ShipToCode:
					return typeof(string);
				case Field.SupplierCode:
					return typeof(string);
				case Field.SupplierCurrencyID:
					return typeof(int?);
				case Field.SupplierID:
					return typeof(int?);
				case Field.SupplierName:
					return typeof(string);
				case Field.PrimaryCompanyID_PrimaryCompanyCode:
					return typeof(string);
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					return typeof(string);
				case Field.CityID:
					return typeof(int?);
				case Field.AddressID_ContactName:
					return typeof(string);
				case Field.CountryID:
					return typeof(int?);
				case Field.AddressID_Line1:
					return typeof(string);
				case Field.AddressID_Line2:
					return typeof(string);
				case Field.AddressID_OtherCityName:
					return typeof(string);
				case Field.AddressID_OtherStateName:
					return typeof(string);
				case Field.AddressID_PostalCode:
					return typeof(string);
				case Field.AddressID_PostBoxNumber:
					return typeof(string);
				case Field.StateID:
					return typeof(int?);
				case Field.AddressID_InternationalDialingCode:
					return typeof(string);
				case Field.AddressID_AreaDialingCode:
					return typeof(string);
				case Field.AddressID_PhoneNumber:
					return typeof(string);
				case Field.AddressID_PhoneExtensionNumber:
					return typeof(string);
				case Field.AddressID_MobileNumber:
					return typeof(string);
				case Field.AddressID_FaxNumber:
					return typeof(string);
				case Field.AddressID_Email:
					return typeof(string);
				case Field.SupplierCurrencyID_CurrencyCode:
					return typeof(string);
				case Field.SupplierCurrencyID_CurrencyName:
					return typeof(string);
				case Field.SupplierCurrencyID_CurrencySymbol:
					return typeof(string);
				case Field.DefaultFreightForwarderID_FreightForwarderCode:
					return typeof(string);
				case Field.DefaultFreightForwarderID_FreightForwarderName:
					return typeof(string);
				case Field.DefaultPurchaseOrderTypeID_PurchaseOrderTypeCode:
					return typeof(string);
				case Field.DefaultPurchaseOrderTypeID_PurchaseOrderTypeName:
					return typeof(string);
				case Field.DefaultShippingModeIDForBackOrders_ShippingModeCode:
					return typeof(string);
				case Field.DefaultShippingModeIDForBackOrders_ShippingModeName:
					return typeof(string);
				case Field.DefaultShippingModeIDForForecastOrders_ShippingModeCode:
					return typeof(string);
				case Field.DefaultShippingModeIDForForecastOrders_ShippingModeName:
					return typeof(string);
				case Field.DefaultTradeTermID_TradeTermCode:
					return typeof(string);
				case Field.DefaultTradeTermID_TradeTermName:
					return typeof(string);
				case Field.CountryID_CountryCode:
					return typeof(string);
				case Field.CountryID_CountryName:
					return typeof(string);
				case Field.StateID_StateCode:
					return typeof(string);
				case Field.StateID_StateName:
					return typeof(string);
				case Field.CityID_CityCode:
					return typeof(string);
				case Field.CityID_CityName:
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
				case Field.AddressID:
					addressID = value;
					break;
				case Field.DefaultFreightForwarderID:
					defaultFreightForwarderID = value;
					break;
				case Field.DefaultPurchaseOrderTypeID:
					defaultPurchaseOrderTypeID = value;
					break;
				case Field.DefaultShippingModeIDForBackOrders:
					defaultShippingModeIDForBackOrders = value;
					break;
				case Field.DefaultShippingModeIDForForecastOrders:
					defaultShippingModeIDForForecastOrders = value;
					break;
				case Field.DefaultTradeTermID:
					defaultTradeTermID = value;
					break;
				case Field.SupplierCurrencyID:
					supplierCurrencyID = value;
					break;
				case Field.SupplierID:
					supplierID = value;
					break;
				case Field.CityID:
					cityID = value;
					break;
				case Field.CountryID:
					countryID = value;
					break;
				case Field.StateID:
					stateID = value;
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
				case Field.ShipToCode:
					shipToCode = value;
					break;
				case Field.SupplierCode:
					supplierCode = value;
					break;
				case Field.SupplierName:
					supplierName = value;
					break;
				case Field.PrimaryCompanyID_PrimaryCompanyCode:
					primaryCompanyID_PrimaryCompanyCode = value;
					break;
				case Field.PrimaryCompanyID_PrimaryCompanyName:
					primaryCompanyID_PrimaryCompanyName = value;
					break;
				case Field.AddressID_ContactName:
					addressID_ContactName = value;
					break;
				case Field.AddressID_Line1:
					addressID_Line1 = value;
					break;
				case Field.AddressID_Line2:
					addressID_Line2 = value;
					break;
				case Field.AddressID_OtherCityName:
					addressID_OtherCityName = value;
					break;
				case Field.AddressID_OtherStateName:
					addressID_OtherStateName = value;
					break;
				case Field.AddressID_PostalCode:
					addressID_PostalCode = value;
					break;
				case Field.AddressID_PostBoxNumber:
					addressID_PostBoxNumber = value;
					break;
				case Field.AddressID_InternationalDialingCode:
					addressID_InternationalDialingCode = value;
					break;
				case Field.AddressID_AreaDialingCode:
					addressID_AreaDialingCode = value;
					break;
				case Field.AddressID_PhoneNumber:
					addressID_PhoneNumber = value;
					break;
				case Field.AddressID_PhoneExtensionNumber:
					addressID_PhoneExtensionNumber = value;
					break;
				case Field.AddressID_MobileNumber:
					addressID_MobileNumber = value;
					break;
				case Field.AddressID_FaxNumber:
					addressID_FaxNumber = value;
					break;
				case Field.AddressID_Email:
					addressID_Email = value;
					break;
				case Field.SupplierCurrencyID_CurrencyCode:
					supplierCurrencyID_CurrencyCode = value;
					break;
				case Field.SupplierCurrencyID_CurrencyName:
					supplierCurrencyID_CurrencyName = value;
					break;
				case Field.SupplierCurrencyID_CurrencySymbol:
					supplierCurrencyID_CurrencySymbol = value;
					break;
				case Field.DefaultFreightForwarderID_FreightForwarderCode:
					defaultFreightForwarderID_FreightForwarderCode = value;
					break;
				case Field.DefaultFreightForwarderID_FreightForwarderName:
					defaultFreightForwarderID_FreightForwarderName = value;
					break;
				case Field.DefaultPurchaseOrderTypeID_PurchaseOrderTypeCode:
					defaultPurchaseOrderTypeID_PurchaseOrderTypeCode = value;
					break;
				case Field.DefaultPurchaseOrderTypeID_PurchaseOrderTypeName:
					defaultPurchaseOrderTypeID_PurchaseOrderTypeName = value;
					break;
				case Field.DefaultShippingModeIDForBackOrders_ShippingModeCode:
					defaultShippingModeIDForBackOrders_ShippingModeCode = value;
					break;
				case Field.DefaultShippingModeIDForBackOrders_ShippingModeName:
					defaultShippingModeIDForBackOrders_ShippingModeName = value;
					break;
				case Field.DefaultShippingModeIDForForecastOrders_ShippingModeCode:
					defaultShippingModeIDForForecastOrders_ShippingModeCode = value;
					break;
				case Field.DefaultShippingModeIDForForecastOrders_ShippingModeName:
					defaultShippingModeIDForForecastOrders_ShippingModeName = value;
					break;
				case Field.DefaultTradeTermID_TradeTermCode:
					defaultTradeTermID_TradeTermCode = value;
					break;
				case Field.DefaultTradeTermID_TradeTermName:
					defaultTradeTermID_TradeTermName = value;
					break;
				case Field.CountryID_CountryCode:
					countryID_CountryCode = value;
					break;
				case Field.CountryID_CountryName:
					countryID_CountryName = value;
					break;
				case Field.StateID_StateCode:
					stateID_StateCode = value;
					break;
				case Field.StateID_StateName:
					stateID_StateName = value;
					break;
				case Field.CityID_CityCode:
					cityID_CityCode = value;
					break;
				case Field.CityID_CityName:
					cityID_CityName = value;
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
