//// Warning: Do not modify!
//// This file (PartUniqueKey_Code.cs) has been auto-generated by PALMS Entity Generation Tool on '22 July 2014' at '15:30:51'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.UniqueKeys
{
	[Serializable]
	public partial class PartUniqueKey_Code : EntityKey<PartEntity>
	{
		#region Enums

		public enum Field
		{
			PartCode
			, PrimaryCompanyID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public string partCode;
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
				case Field.PartCode:
					return partCode;
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
				case Field.PartCode:
					return typeof(string);
				case Field.PrimaryCompanyID:
					return typeof(int?);
			}

			return null;
		}

		public override PartEntity GetBlankEntityWithKey()
		{
			return new PartEntity()
			{
				partCode = partCode
				, primaryCompanyID = primaryCompanyID
			};
		}

		public override string GetClassName()
		{
			return "PartUniqueKey_Code";
		}

		#endregion Overriding / Public Members
	}
}
