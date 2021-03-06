//// Warning: Do not modify!
//// This file (PalmsUserPrimaryCompanyMappingPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on '12 January 2012' at '16:41:12'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.PrimaryKeys
{
	[Serializable]
	public partial class PalmsUserPrimaryCompanyMappingPrimaryKey : EntityKey<PalmsUserPrimaryCompanyMappingEntity>
	{
		#region Enums

		public enum Field
		{
			PalmsUserID
			, PrimaryCompanyID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? palmsUserID;
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
				case Field.PalmsUserID:
					return palmsUserID;
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
				case Field.PalmsUserID:
					return typeof(int?);
				case Field.PrimaryCompanyID:
					return typeof(int?);
			}

			return null;
		}

		public override PalmsUserPrimaryCompanyMappingEntity GetBlankEntityWithKey()
		{
			return new PalmsUserPrimaryCompanyMappingEntity()
			{
				palmsUserID = palmsUserID
				, primaryCompanyID = primaryCompanyID
			};
		}

		public override string GetClassName()
		{
			return "PalmsUserPrimaryCompanyMappingPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}
