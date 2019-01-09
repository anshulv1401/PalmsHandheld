//// Warning: Do not modify!
//// This file (PartUOMMappingPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on 'Wednesday, September 23, 2015' at '4:55:22 PM'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.PrimaryKeys
{
	[Serializable]
	public partial class PartUOMMappingPrimaryKey : EntityKey<PartUOMMappingEntity>
	{
		#region Enums

		public enum Field
		{
			PartID
			, PrimaryCompanyID
			, UOMID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? partID;
		public int? primaryCompanyID;
		public int? uOMID;

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
				case Field.PartID:
					return partID;
				case Field.PrimaryCompanyID:
					return primaryCompanyID;
				case Field.UOMID:
					return uOMID;
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
				case Field.PartID:
					return typeof(int?);
				case Field.PrimaryCompanyID:
					return typeof(int?);
				case Field.UOMID:
					return typeof(int?);
			}

			return null;
		}

		public override PartUOMMappingEntity GetBlankEntityWithKey()
		{
			return new PartUOMMappingEntity()
			{
				partID = partID
				, primaryCompanyID = primaryCompanyID
				, uOMID = uOMID
			};
		}

		public override string GetClassName()
		{
			return "PartUOMMappingPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}
