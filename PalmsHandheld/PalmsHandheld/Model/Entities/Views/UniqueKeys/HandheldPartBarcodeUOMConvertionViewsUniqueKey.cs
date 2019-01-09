//// Warning: Do not modify!
//// This file (HandheldPartBarcodeUOMConvertionViewsUniqueKey.cs) has been auto-generated by PALMS Entity Generation Tool on 'Monday, September 28, 2015' at '10:11:43 AM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class HandheldPartBarcodeUOMConvertionViewsUniqueKey : EntityKey<HandheldPartBarcodeUOMConvertionViewsEntity>
	{
		#region Enums

		public enum Field
		{
			PrimaryCompanyID
			, PartID
			, ScannedBarcode
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? primaryCompanyID;
		public int? partID;
		public string scannedBarcode;

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
				case Field.PartID:
					return partID;
				case Field.ScannedBarcode:
					return scannedBarcode;
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
				case Field.PartID:
					return typeof(int?);
				case Field.ScannedBarcode:
					return typeof(string);
			}

			return null;
		}

		public override HandheldPartBarcodeUOMConvertionViewsEntity GetBlankEntityWithKey()
		{
			return new HandheldPartBarcodeUOMConvertionViewsEntity()
			{
				primaryCompanyID = primaryCompanyID
				, partID = partID
				, scannedBarcode = scannedBarcode
			};
		}

		public override string GetClassName()
		{
			return "HandheldPartBarcodeUOMConvertionViewsUniqueKey";
		}

		#endregion Overriding / Public Members
	}
}
