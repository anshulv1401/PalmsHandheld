#region Header Comment
/*------------------------------------------------------------------------------------ 
Author                          : Unknown User                             
Date                            : dd/MM/YYYY
Created At                      : Technoforte
Purpose (Template), in Detail   : Unknown Purpose
Logic Structure                 : 
Modification History:                                                                  
Date         Modified By      Modified At      Revision Summary                                     
----------   ------------     -----------    ------------------------------------------         
-------------------------------------------------------------------------------------*/
#endregion Header Comment


namespace Technoforte.PALMS.Entities
{
	public enum OperatorType
	{
		None = 0,
		OperatorAnd = 1,
		OperatorOr = 2,
		OperatorNot = 3,
		OperatorAndNot = 4,
		OperatorOrNot = 5,
	}

	public abstract class SearchCriterion
	{
		public OperatorType operatorType;
		public int? field;

		protected SearchCriterion(int? field, OperatorType operatorType)
		{
			this.field = field;
			this.operatorType = operatorType;
		}

		protected string GetOperatorString()
		{
			switch (operatorType)
			{
				case OperatorType.None:
					return "";
				case OperatorType.OperatorAnd:
					return "AND";
				case OperatorType.OperatorOr:
					return "OR";
				case OperatorType.OperatorNot:
					return "NOT";
				case OperatorType.OperatorAndNot:
					return "AND NOT";
				case OperatorType.OperatorOrNot:
					return "OR NOT";
				default:
					return "";
			}
		}

		public abstract string GetSearchString(Entity entity);
	}

	public class CustomCriterion : SearchCriterion
	{
		string value;

		public CustomCriterion(string value)
			: this(value, OperatorType.None)
		{
		}

		public CustomCriterion(string value, OperatorType operatorType)
			: base(null, operatorType)
		{
			this.value = value;
		}

		public override string GetSearchString(Entity entity)
		{
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ value;
		}
	}

	public class LeftBracket : SearchCriterion
	{
		public LeftBracket()
			: this(OperatorType.None)
		{
		}

		public LeftBracket(OperatorType operatorType)
			: base(null, operatorType)
		{
		}

		public override string GetSearchString(Entity entity)
		{
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ "(";
		}
	}

	public class RightBracket : SearchCriterion
	{
		public RightBracket()
			: base(null, OperatorType.None)
		{
		}

		public override string GetSearchString(Entity entity)
		{
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ ")";
		}
	}

	public abstract class SingleValue : SearchCriterion
	{
		public object value;
		public string criterionOperator;
		public string criterionNullOperator;

		protected SingleValue(int field, object value, OperatorType operatorType, string criterionOperator, string criterionNullOperator)
			: base(field, operatorType)
		{
			this.value = value;
			this.criterionOperator = criterionOperator;
			this.criterionNullOperator = criterionNullOperator;
		}

		public override string GetSearchString(Entity entity)
		{
			string fieldName = (field < 0 ? ((Entity.Field)field).ToString() : entity.GetFieldName(field.Value));
			string value = entity.GetDelimitedValue(field.Value, this.value);
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ fieldName
				+ " " + (value == null ? criterionNullOperator : criterionOperator) + " "
				+ (value == null ? " NULL" : value);
		}
	}

	public abstract class SingleField : SearchCriterion
	{
		public int compareWithField;
		public string criterionOperator;

		protected SingleField(int field, int compareWithField, OperatorType operatorType, string criterionOperator)
			: base(field, operatorType)
		{
			this.compareWithField = compareWithField;
			this.criterionOperator = criterionOperator;
		}

		public override string GetSearchString(Entity entity)
		{
			string fieldName = (field < 0 ? ((Entity.Field)field).ToString() : entity.GetFieldName(field.Value));
			string field2Name = (compareWithField < 0 ? ((Entity.Field)compareWithField).ToString() : entity.GetFieldName(compareWithField));
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ fieldName
				+ " " + criterionOperator + " "
				+ field2Name;
		}
	}

	public class GreaterThanValue : SingleValue
	{
		public GreaterThanValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public GreaterThanValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, ">", ">")
		{
		}
	}

	public class GreaterThanOrEqualToValue : SingleValue
	{
		public GreaterThanOrEqualToValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public GreaterThanOrEqualToValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, ">=", ">=")
		{
		}
	}

	public class LessThanValue : SingleValue
	{
		public LessThanValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public LessThanValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, "<", "<")
		{
		}
	}

	public class LessThanOrEqualToValue : SingleValue
	{
		public LessThanOrEqualToValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public LessThanOrEqualToValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, "<=", "<=")
		{
		}
	}

	public class EqualToValue : SingleValue
	{
		public EqualToValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public EqualToValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, "=", "IS")
		{
		}
	}

	public class NotEqualToValue : SingleValue
	{
		public NotEqualToValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public NotEqualToValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, "!=", "IS NOT")
		{
		}
	}

	public class LikeValue : SingleValue
	{
		public LikeValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public LikeValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, "LIKE", "LIKE")
		{
		}
	}

	public class NotLikeValue : SingleValue
	{
		public NotLikeValue(int field, object value)
			: this(field, value, OperatorType.None)
		{
		}

		public NotLikeValue(int field, object value, OperatorType operatorType)
			: base(field, value, operatorType, "NOT LIKE", "NOT LIKE")
		{
		}
	}

	public class GreaterThanField : SingleField
	{
		public GreaterThanField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public GreaterThanField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, ">")
		{
		}
	}

	public class GreaterThanOrEqualToField : SingleField
	{
		public GreaterThanOrEqualToField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public GreaterThanOrEqualToField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, ">=")
		{
		}
	}

	public class LessThanField : SingleField
	{
		public LessThanField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public LessThanField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, "<")
		{
		}
	}

	public class LessThanOrEqualToField : SingleField
	{
		public LessThanOrEqualToField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public LessThanOrEqualToField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, "<=")
		{
		}
	}

	public class EqualToField : SingleField
	{
		public EqualToField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public EqualToField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, "=")
		{
		}
	}

	public class NotEqualToField : SingleField
	{
		public NotEqualToField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public NotEqualToField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, "!=")
		{
		}
	}

	public class LikeField : SingleField
	{
		public LikeField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public LikeField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, "LIKE")
		{
		}
	}

	public class NotLikeField : SingleField
	{
		public NotLikeField(int field, int compareWithField)
			: this(field, compareWithField, OperatorType.None)
		{
		}

		public NotLikeField(int field, int compareWithField, OperatorType operatorType)
			: base(field, compareWithField, operatorType, "NOT LIKE")
		{
		}
	}

	public class InBetweenValues : SearchCriterion
	{
		public object value1;
		public object value2;

		public InBetweenValues(int field, object value1, object value2)
			: this(field, value1, value2, OperatorType.None)
		{
		}

		public InBetweenValues(int field, object value1, object value2, OperatorType operatorType)
			: base(field, operatorType)
		{
			this.value1 = value1;
			this.value2 = value2;
		}

		public override string GetSearchString(Entity entity)
		{
			if (this.value1 != null && this.value2 != null)
			{
				string fieldName = (field < 0 ? ((Entity.Field)field).ToString() : entity.GetFieldName(field.Value));
				string value1 = entity.GetDelimitedValue(field.Value, this.value1);
				string value2 = entity.GetDelimitedValue(field.Value, this.value2);
				string operatorString = GetOperatorString();

				return (operatorString == "" ? "" : operatorString + " ")
					+ fieldName
					+ " BETWEEN "
					+ (value1 == null ? " NULL" : value1)
					+ " AND "
					+ (value2 == null ? " NULL" : value2);
			}
			else if (this.value1 != null)
			{
				return (new GreaterThanOrEqualToValue(field.Value, this.value1)).GetSearchString(entity);
			}
			else if (this.value2 != null)
			{
				return (new LessThanOrEqualToValue(field.Value, this.value2)).GetSearchString(entity);
			}
			else
			{
				return "";
			}
		}
	}

	public class NotInBetweenValues : SearchCriterion
	{
		public object value1;
		public object value2;

		public NotInBetweenValues(int field, object value1, object value2)
			: this(field, value1, value2, OperatorType.None)
		{
		}

		public NotInBetweenValues(int field, object value1, object value2, OperatorType operatorType)
			: base(field, operatorType)
		{
			this.value1 = value1;
			this.value2 = value2;
		}

		public override string GetSearchString(Entity entity)
		{
			string fieldName = (field < 0 ? ((Entity.Field)field).ToString() : entity.GetFieldName(field.Value));
			string value1 = entity.GetDelimitedValue(field.Value, this.value1);
			string value2 = entity.GetDelimitedValue(field.Value, this.value2);
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ fieldName
				+ " NOT BETWEEN "
				+ (value1 == null ? " NULL" : value1)
				+ " AND "
				+ (value2 == null ? " NULL" : value2);
		}
	}

	public class InBetweenFields : SearchCriterion
	{
		public int field1;
		public int field2;

		public InBetweenFields(int field, int compareWithField1, int compareWithField2)
			: this(field, compareWithField1, compareWithField2, OperatorType.None)
		{
		}

		public InBetweenFields(int field, int compareWithField1, int compareWithField2, OperatorType operatorType)
			: base(field, operatorType)
		{
			this.field1 = compareWithField1;
			this.field2 = compareWithField2;
		}

		public override string GetSearchString(Entity entity)
		{
			string fieldName = (field < 0 ? ((Entity.Field)field).ToString() : entity.GetFieldName(field.Value));
			string field1Name = (field1 < 0 ? ((Entity.Field)field1).ToString() : entity.GetFieldName(field1));
			string field2Name = (field2 < 0 ? ((Entity.Field)field2).ToString() : entity.GetFieldName(field2));
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ fieldName
				+ " BETWEEN "
				+ field1Name
				+ " AND "
				+ field2Name;
		}
	}

	public class NotInBetweenFields : SearchCriterion
	{
		public int field1;
		public int field2;

		public NotInBetweenFields(int field, int compareWithField1, int compareWithField2)
			: this(field, compareWithField1, compareWithField2, OperatorType.None)
		{
		}

		public NotInBetweenFields(int field, int compareWithField1, int compareWithField2, OperatorType operatorType)
			: base(field, operatorType)
		{
			this.field1 = compareWithField1;
			this.field2 = compareWithField2;
		}

		public override string GetSearchString(Entity entity)
		{
			string fieldName = (field < 0 ? ((Entity.Field)field).ToString() : entity.GetFieldName(field.Value));
			string field1Name = (field1 < 0 ? ((Entity.Field)field1).ToString() : entity.GetFieldName(field1));
			string field2Name = (field2 < 0 ? ((Entity.Field)field2).ToString() : entity.GetFieldName(field2));
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ fieldName
				+ " NOT BETWEEN "
				+ field1Name
				+ " AND "
				+ field2Name;
		}
	}

	public class ValueInBetweenFields : SearchCriterion
	{
		public int field1;
		public int field2;
		public object value;

		public ValueInBetweenFields(object value, int compareWithField1, int compareWithField2)
			: this(value, compareWithField1, compareWithField2, OperatorType.None)
		{
		}

		public ValueInBetweenFields(object value, int compareWithField1, int compareWithField2, OperatorType operatorType)
			: base(null, operatorType)
		{
			this.field1 = compareWithField1;
			this.field2 = compareWithField2;
			this.value = value;
		}

		public override string GetSearchString(Entity entity)
		{
			string field1Name = (field1 < 0 ? ((Entity.Field)field1).ToString() : entity.GetFieldName(field1));
			string field2Name = (field2 < 0 ? ((Entity.Field)field2).ToString() : entity.GetFieldName(field2));
			string value = entity.GetDelimitedValue(field1, this.value);
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ value
				+ " BETWEEN "
				+ field1Name
				+ " AND "
				+ field2Name;
		}
	}

	public class ValueNotInBetweenFields : SearchCriterion
	{
		public int field1;
		public int field2;
		public object value;

		public ValueNotInBetweenFields(object value, int compareWithField1, int compareWithField2)
			: this(value, compareWithField1, compareWithField2, OperatorType.None)
		{
		}

		public ValueNotInBetweenFields(object value, int compareWithField1, int compareWithField2, OperatorType operatorType)
			: base(null, operatorType)
		{
			this.field1 = compareWithField1;
			this.field2 = compareWithField2;
			this.value = value;
		}

		public override string GetSearchString(Entity entity)
		{
			string field1Name = (field1 < 0 ? ((Entity.Field)field1).ToString() : entity.GetFieldName(field1));
			string field2Name = (field2 < 0 ? ((Entity.Field)field2).ToString() : entity.GetFieldName(field2));
			string value = entity.GetDelimitedValue(field1, this.value);
			string operatorString = GetOperatorString();

			return (operatorString == "" ? "" : operatorString + " ")
				+ value
				+ " NOT BETWEEN "
				+ field1Name
				+ " AND "
				+ field2Name;
		}
	}
}