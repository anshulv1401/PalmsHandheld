//// Warning: Do not modify!
//// This file (CostBucketPrimaryKey.cs) has been auto-generated by PALMS Entity Generation Tool on '12 January 2012' at '16:39:34'
//// If modification is required, consider 'partial class'.

using System;

#pragma warning disable 1591

namespace Technoforte.PALMS.Entities.Views.PrimaryKeys
{
	[Serializable]
	public partial class CostBucketPrimaryKey : EntityKey<CostBucketEntity>
	{
		#region Enums

		public enum Field
		{
			CostBucketID
			
			, _FieldCount
		}

		#endregion Enums

		#region Members

		public int? costBucketID;

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
				case Field.CostBucketID:
					return costBucketID;
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
				case Field.CostBucketID:
					return typeof(int?);
			}

			return null;
		}

		public override CostBucketEntity GetBlankEntityWithKey()
		{
			return new CostBucketEntity()
			{
				costBucketID = costBucketID
			};
		}

		public override string GetClassName()
		{
			return "CostBucketPrimaryKey";
		}

		#endregion Overriding / Public Members
	}
}
