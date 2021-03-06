//// Warning: Do not modify!
//// This file (PartUOMMappingUniqueKey_Barcode.cs) has been auto-generated by PALMS Entity Generation Tool on 'Wednesday, September 23, 2015' at '4:55:22 PM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class PartUOMMappingUniqueKey_Barcode : EntityKey<PartUOMMappingEntity>
	{
		#region Enums

		public enum Field
		{
			Barcode
			, PrimaryCompanyID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string barcode;
		public int? primaryCompanyID;

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
				case Field.Barcode:
					return barcode;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
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
				case Field.Barcode:
					return typeof(string);
				case Field.PrimaryCompanyID:
					return typeof(int?);
			}

			return null;
		}

		public override PartUOMMappingEntity GetBlankEntityWithKey()
		{
			return new PartUOMMappingEntity()
			{
				barcode = barcode
				, primaryCompanyID = primaryCompanyID
			};
		}

		public override string GetClassName()
		{
			return "PartUOMMappingUniqueKey_Barcode";
		}

		#endregion Overriding / Public Members
	}
}
