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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Technoforte.PALMS.Exceptions;
using System.Diagnostics;
using System.Collections;
using System.Data;

namespace Technoforte.PALMS.Entities
{
    /// <summary>
    ///		Base class for all the PALMS Entities
    /// </summary>
    [Serializable]
    public class Entity : ICustomTypeDescriptor, IComparable
    {
        #region Enums

        public enum Field
        {
            CreatedBy = -1,
            CreatedDate = -2,
            ModifiedBy = -3,
            ModifiedDate = -4,
            IsSelected = -5,
            IsDirty = -6
        }

        #endregion Enums

        #region Member Variables

        private const short magicAutoNumber = -5555;
        private static DateTime magicAutoDateTime = DateTime.Parse("1600 Jan 01");

        public Int32? createdBy;
        public DateTime? createdDate;
        public Int32? modifiedBy;
        public DateTime? modifiedDate;
        public bool? isSelected = false;
        public bool? isDirty;
        public List<SearchCriterion> searchCriteria;
        public bool isSearchDistinct = false;
        public bool isReadFromDatabase = false;
        public string uIAddionalSearchCriteria;
        public List<AggregateResult> aggregateResults = new List<AggregateResult>();

        #endregion Variables

        #region Public Static Methods

        /// <summary>
        ///     Gets an object of entity class using reflection
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public static Entity GetEntity(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Object o = assembly.CreateInstance("Technoforte.PALMS.Entities." + className);

            if (o is Entity)
            {
                return (Entity)o;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Clones a list of entities.
        /// </summary>
        /// <remarks>
        ///     Clones a list of entities by creating a new list and adding shallow memberwise copies of entities.
        /// </remarks>
        /// <typeparam name="T">Any derived class of Entiy.</typeparam>
        /// <param name="list">Entity list object of which clone is desired.</param>
        /// <returns></returns>
        public static List<T> Clone<T>(List<T> list) where T : Entity
        {
            List<T> output = new List<T>();

            foreach (T entity in list)
            {
                output.Add((T)(entity.MemberwiseClone()));
            }

            return output;
        }

        /// <summary>
        ///		Copy one entity to another.
        /// </summary>
        /// <remarks>
        ///		Copies the values of source entity to destination entity if FieldName is matched.
        /// </remarks>
        /// <typeparam name="T">Any derived class of Entity.</typeparam>
        /// <param name="item">Entity object of which copy is desired.</param>
        public void CopyTo<T>(T item) where T : Entity
        {
            if (item == null)
            {
                throw new ArgumentNullException("Parameter cannot be null.");
            }

            item.createdBy = createdBy;
            item.createdDate = createdDate;
            item.modifiedBy = modifiedBy;
            item.modifiedDate = modifiedDate;

            for (int itemFieldCount = 0; itemFieldCount < item.GetFieldCount(); itemFieldCount++)
            {
                for (int fieldCount = 0; fieldCount < GetFieldCount(); fieldCount++)
                {
                    string name1 = GetFieldName(fieldCount);
                    string name2 = item.GetFieldName(itemFieldCount);
                    int itemFieldlength = item.GetFieldName(itemFieldCount).Length - 1;
                    int fieldLength = GetFieldName(fieldCount).Length - 1;

                    string itemFieldName = "header_" + item.GetFieldName(itemFieldCount).Substring(0, 1).ToUpper() + item.GetFieldName(itemFieldCount).Substring(1, itemFieldlength);
                    string fieldName = "header_" + GetFieldName(fieldCount).Substring(0, 1).ToUpper() + GetFieldName(fieldCount).Substring(1, fieldLength); 

                    if (GetFieldName(fieldCount).Equals(item.GetFieldName(itemFieldCount))
                        || GetFieldName(fieldCount).Equals(fieldName)
                        || (fieldName).Equals(item.GetFieldName(itemFieldCount)) || GetFieldName(fieldCount).Equals(itemFieldName))
                    {
                        Type dataType = item.GetType(itemFieldCount);
                        object fieldData = GetValue(fieldCount);

                        try
                        {
                            if (dataType == typeof(string))
                            {
                                item.SetValue(itemFieldCount, (string)fieldData);
                            }
                            else if (dataType == typeof(byte?))
                            {
                                item.SetValue(itemFieldCount, (byte?)fieldData);
                            }
                            else if (dataType == typeof(Int32?))
                            {
                                item.SetValue(itemFieldCount, (Int32?)fieldData);
                            }
                            else if (dataType == typeof(Decimal?))
                            {
                                item.SetValue(itemFieldCount, (Decimal?)fieldData);
                            }
                            else if (dataType == typeof(Char?))
                            {
                                item.SetValue(itemFieldCount, (Char?)fieldData);
                            }
                            else if (dataType == typeof(float?))
                            {
                                item.SetValue(itemFieldCount, (float?)fieldData);
                            }
                            else if (dataType == typeof(Int16?))
                            {
                                item.SetValue(itemFieldCount, (Int16?)fieldData);
                            }
                            else if (dataType == typeof(DateTime?))
                            {
                                item.SetValue(itemFieldCount, (DateTime?)fieldData);
                            }
                            else if (dataType == typeof(bool?))
                            {
                                item.SetValue(itemFieldCount, (bool?)fieldData);
                            }
                            else if (dataType == typeof(Int64?))
                            {
                                item.SetValue(itemFieldCount, (Int64?)fieldData);
                            }
                            else if (dataType == typeof(Guid?))
                            {
                                item.SetValue(itemFieldCount, (Guid?)fieldData);
                            }
                        }
                        catch
                        {
                            //Debug.Print("Exception during copying field {0} of source to {1} of destination. Value:{2}.", fieldName, itemFieldName, fieldData);
                            throw;
                        }

                        break;
                    }
                }
            }
        }

        /// <summary>
        ///     Clones the entity.
        /// </summary>
        /// <remarks>
        ///     Clones the entity with shallow memberwise copying.
        /// </remarks>
        /// <typeparam name="T">Any derived class of Entiy.</typeparam>
        /// <param name="entity">Entity object of which clone is desired.</param>
        /// <returns></returns>
        public static T Clone<T>(T entity) where T : Entity
        {
            return (T)(entity.MemberwiseClone());
        }

        #endregion Public Static Methods

        #region Virtual Methods

        /// <summary>
        /// sets all the object fields to NULL. 
        /// </summary>
        public virtual void ClearFields()
        {
            createdBy = null;
            createdDate = null;
            modifiedBy = null;
            modifiedDate = null;
            isSelected = null;
            isDirty = null;
            searchCriteria = null;
            isSearchDistinct = false;
            isReadFromDatabase = false;
            uIAddionalSearchCriteria = null;
        }

        public virtual string GetDelimitedValue(int field)
        {
            return GetDelimitedValue(field, false);
        }

        public virtual string GetDelimitedValue(int field, bool useOleAutomationDate)
        {
            object fieldValue = null;
            string delimiter = "";
            string dateFormat = useOleAutomationDate ? "yyyy-MMM-dd HH:mm:ss" : "yyyy-MMM-dd HH:mm:ss.fff";

            if (field < 0)
            {
                switch ((Field)field)
                {
                    case Field.CreatedDate:
                        fieldValue = (createdDate == null ? null : createdDate.Value.ToLocalTime().ToString(dateFormat));
                        delimiter = "'";
                        break;
                    case Field.ModifiedDate:
                        fieldValue = (modifiedDate == null ? null : modifiedDate.Value.ToLocalTime().ToString(dateFormat));
                        delimiter = "'";
                        break;
                    case Field.CreatedBy:
                        fieldValue = createdBy;
                        delimiter = "";
                        break;
                    case Field.IsSelected:
                        fieldValue = isSelected;
                        delimiter = "";
                        break;
                    case Field.IsDirty:
                        fieldValue = isDirty;
                        delimiter = "";
                        break;
                    case Field.ModifiedBy:
                        fieldValue = modifiedBy;
                        delimiter = "";
                        break;
                    default:
                        throw (new InvalidOperationException("Error!"));
                }
            }
            else
            {
                fieldValue = GetValue(field);

                if (GetType(field) == typeof(string))
                {
                    delimiter = "'";
                }
                else if (GetType(field) == typeof(decimal?))
                {
                    delimiter = "";

                    if (fieldValue != null)
                    {
                        fieldValue = Decimal.Round((Decimal)fieldValue, 2);
                    }
                }
                else if (GetType(field) == typeof(bool?))
                {
                    delimiter = "";

                    if (fieldValue != null)
                    {
                        if ((bool)fieldValue)
                        {
                            fieldValue = 1;
                        }
                        else
                        {
                            fieldValue = 0;
                        }
                    }
                }
                else if (GetType(field) == typeof(Guid?))
                {
                    delimiter = "'";
                }
                else if (GetType(field) == typeof(Int64?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(Int32?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(Byte?[]))
                {
                    delimiter = "";

                }
                else if (GetType(field) == typeof(Byte?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(float?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(double?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(char?))
                {
                    delimiter = "'";
                }
                else if (GetType(field) == typeof(DateTime?))
                {
                    delimiter = "'";
                    fieldValue = (fieldValue == null ? null : ((DateTime?)fieldValue).Value.ToLocalTime().ToString(dateFormat));
                }
                else if (GetType(field) == typeof(BitArray))
                {
                    delimiter = "";
                    fieldValue = fieldValue == null ? null : "0x" + BitConverter.ToString(ConvertToByte(((BitArray)fieldValue))).Replace("-", "") + "";
                }
                else
                {
                    throw (new InvalidOperationException("Error!"));
                }
            }

            return (fieldValue == null ? "NULL" : delimiter + fieldValue.ToString().Replace("''", "'").Replace("'", "''") + delimiter);
        }

        public virtual string GetDelimitedValue(int field, object value)
        {
            return GetDelimitedValue(field, value, false);
        }

        public virtual string GetDelimitedValue(int field, object value, bool useOleAutomationDate)
        {
            object fieldValue = null;
            string delimiter = "";
            string dateFormat = useOleAutomationDate ? "yyyy-MMM-dd HH:mm:ss" : "yyyy-MMM-dd HH:mm:ss.fff";

            if (field < 0)
            {
                switch ((Field)field)
                {
                    case Field.CreatedDate:
                    case Field.ModifiedDate:
                        fieldValue = (value == null ? null : ((DateTime?)value).Value.ToLocalTime().ToString(dateFormat));
                        delimiter = "'";
                        break;
                    case Field.IsSelected:
                    case Field.IsDirty:
                        fieldValue = value;
                        delimiter = "";
                        break;
                    case Field.CreatedBy:
                    case Field.ModifiedBy:
                        fieldValue = value;
                        delimiter = "'";
                        break;
                    default:
                        throw (new InvalidOperationException("Error!"));
                }
            }
            else
            {
                fieldValue = value;

                if (GetType(field) == typeof(string))
                {
                    delimiter = "'";
                }
                else if (GetType(field) == typeof(decimal?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(bool?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(Guid?))
                {
                    delimiter = "'";
                }
                else if (GetType(field) == typeof(Int64?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(Int32?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(BitArray))
                {
                    delimiter = "";
                    fieldValue = fieldValue == null ? null : "0x" + BitConverter.ToString(ConvertToByte(((BitArray)fieldValue))).Replace("-", "") + "";
                }
                else if (GetType(field) == typeof(Byte?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(float?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(double?))
                {
                    delimiter = "";
                }
                else if (GetType(field) == typeof(char?))
                {
                    delimiter = "'";
                }
                else if (GetType(field) == typeof(DateTime?))
                {
                    delimiter = "'";
                    fieldValue = (fieldValue == null ? null : ((DateTime?)fieldValue).Value.ToLocalTime().ToString(dateFormat));
                }
                else
                {
                    throw (new InvalidOperationException("Error!"));
                }
            }

            return (fieldValue == null ? null : delimiter + fieldValue.ToString().Replace("''", "'").Replace("'", "''") + delimiter);
        }

        public virtual void AddSearchCriterion(SearchCriterion criterion)
        {
            if (searchCriteria == null)
            {
                searchCriteria = new List<SearchCriterion>();
            }

            searchCriteria.Add(criterion);
        }

        public virtual string GetSearchString()
        {
            if (!String.IsNullOrEmpty(uIAddionalSearchCriteria))
            {
                return uIAddionalSearchCriteria;
            }
            else
            {
                if (searchCriteria == null)
                {
                    return "1 = 1";
                }
                else
                {
                    string searchString = "";

                    foreach (SearchCriterion criterion in searchCriteria)
                    {
                        if (searchString == "")
                        {
                            searchString = criterion.GetSearchString(this);
                        }
                        else
                        {
                            searchString += (" " + criterion.GetSearchString(this));
                        }
                    }


                    return searchString;
                }
            }
        }

        public override string ToString()
        {
            string output = "";

            for (int field = 0; field < GetFieldCount(); field++)
            {
                if (GetValue(field) != null)
                {
                    output += (output == "" ? "" : ", ") + GetFieldName(field) + ": " + (GetValue(field) == null ? "NULL" : GetValue(field).ToString());
                }
            }

            output += uIAddionalSearchCriteria == null ? "" : (output == "" ? "" : ", ") + uIAddionalSearchCriteria;

            return output;
        }

        public virtual bool IsIdentity(Int32 field)
        {
            return false;
        }

        public virtual KeyValueRecord ToKeyValueRecord()
        {
            KeyValueRecord keyValueRecord = new KeyValueRecord();

            keyValueRecord.Add("CreatedBy", createdBy == null ? "NULL" : createdBy.ToString());
            keyValueRecord.Add("CreatedDate", createdDate == null ? "NULL" : createdDate.Value.ToLocalTime().ToString("yyyy-MMM-dd HH:mm:ss"));
            keyValueRecord.Add("ModifiedBy", modifiedBy == null ? "NULL" : modifiedBy.ToString());
            keyValueRecord.Add("ModifiedDate", modifiedDate == null ? "NULL" : modifiedDate.Value.ToLocalTime().ToString("yyyy-MMM-dd HH:mm:ss"));

            for (int i = 0; i < GetFieldCount(); i++)
            {
                Type dataType = GetType(i);

                try
                {
                    if (dataType == typeof(DateTime?))
                    {
                        keyValueRecord.Add(GetFieldName(i), GetValue(i) == null ? "NULL" : ((DateTime?)GetValue(i)).Value.ToString("yyyy-MMM-dd HH:mm:ss"));
                    }
                    else
                    {
                        keyValueRecord.Add(GetFieldName(i), GetValue(i) == null ? "NULL" : GetValue(i).ToString());
                    }
                }
                catch
                {
                    //Debug.Print("Error while populating KeyValueRecord from entity. DataType: " + dataType + ", Key: " + GetFieldName(i) + ", Value: " + GetValue(i));
                }
            }

            return keyValueRecord;
        }

        public virtual void FillFromKeyValueRecord(KeyValueRecord record)
        {
            try
            {
                createdBy = ParseInt32(record.GetValue("CreatedBy"));
            }
            catch (Exception e)
            {
                //Debug.Print("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: createdBy" + ", Value: " + record.GetValue("CreatedBy"));
                throw new Exception("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: createdBy" + ", Value: " + record.GetValue("CreatedBy") + " Original Exception: " + e.Message);
            }

            try
            {
                createdDate = ParseDateTime(record.GetValue("CreatedDate"));
            }
            catch (Exception e)
            {
               // Debug.Print("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: createdDate" + ", Value: " + record.GetValue("CreatedDate"));
                throw new Exception("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: createdDate" + ", Value: " + record.GetValue("CreatedDate") + " Original Exception: " + e.Message);
            }

            try
            {
                modifiedBy = ParseInt32(record.GetValue("ModifiedBy"));
            }
            catch (Exception e)
            {
                //Debug.Print("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: modifiedBy" + ", Value: " + record.GetValue("ModifiedBy"));
                throw new Exception("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: modifiedBy" + ", Value: " + record.GetValue("ModifiedBy") + " Original Exception: " + e.Message);
            }

            try
            {
                modifiedDate = ParseDateTime(record.GetValue("ModifiedDate"));
            }
            catch (Exception e)
            {
               // Debug.Print("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: modifiedDate" + ", Value: " + record.GetValue("ModifiedDate"));
                throw new Exception("Error while populating entity from KeyValueRecord. Expected DataType: " + "Int32" + ", Key: modifiedDate" + ", Value: " + record.GetValue("ModifiedDate") + " Original Exception: " + e.Message);
            }

            for (int i = 0; i < GetFieldCount(); i++)
            {
                Type dataType = GetType(i);
                string fieldName = GetFieldName(i);
                try
                {
                    if (dataType == typeof(string))
                    {
                        SetValue(i, ParseString(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(byte?))
                    {
                        SetValue(i, ParseByte(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(Int32?))
                    {
                        SetValue(i, ParseInt32(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(Decimal?))
                    {
                        SetValue(i, ParseDecimal(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(Char?))
                    {
                        SetValue(i, ParseChar(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(float?))
                    {
                        SetValue(i, ParseFloat(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(Int16?))
                    {
                        SetValue(i, ParseInt16(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(DateTime?))
                    {
                        SetValue(i, ParseDateTime(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(bool?))
                    {
                        SetValue(i, ParseBoolean(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(Int64?))
                    {
                        SetValue(i, ParseInt64(record.GetValue(GetFieldName(i))));
                    }
                    else if (dataType == typeof(Guid?))
                    {
                        SetValue(i, ParseGuid(record.GetValue(GetFieldName(i))));
                    }
                }
                catch (Exception e)
                {
                    //Debug.Print("Error while populating entity from KeyValueRecord. Expected DataType: " + dataType + ", Key: " + GetFieldName(i) + ", Value: " + record.GetValue(GetFieldName(i)));
                    throw new Exception("Error while populating entity from KeyValueRecord. Expected DataType: " + dataType + ", Key: " + GetFieldName(i) + ", Value: " + record.GetValue(GetFieldName(i)) + " Original Exception: " + e.Message);
                }
            }
        }

        public virtual void FillFromDataRow(DataRow record)
        {
            try
            {
                createdBy = !(record.Table.Columns.Contains("CreatedBy")) ? null : ParseInt32(record["CreatedBy"].ToString());
            }
            catch (Exception e)
            {
                //Debug.Print("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: createdBy" + ", Value: " + record["CreatedBy"].ToString());
                throw new Exception("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: createdBy" + ", Value: " + record["CreatedBy"].ToString() + " Original Exception: " + e.Message);
            }

            try
            {
                createdDate = !(record.Table.Columns.Contains("CreatedDate")) ? null : ParseDateTime(record["CreatedDate"].ToString());
            }
            catch (Exception e)
            {
                //Debug.Print("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: createdDate" + ", Value: " + record["CreatedDate"].ToString());
                throw new Exception("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: createdDate" + ", Value: " + record["CreatedDate"].ToString() + " Original Exception: " + e.Message);
            }

            try
            {
                modifiedBy = !(record.Table.Columns.Contains("ModifiedBy")) ? null : ParseInt32(record["ModifiedBy"].ToString());
            }
            catch (Exception e)
            {
                //Debug.Print("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: modifiedBy" + ", Value: " + record["ModifiedBy"].ToString());
                throw new Exception("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: modifiedBy" + ", Value: " + record["ModifiedBy"].ToString() + " Original Exception: " + e.Message);
            }

            try
            {
                modifiedDate = !(record.Table.Columns.Contains("ModifiedDate")) ? null : ParseDateTime(record["ModifiedDate"].ToString());
            }
            catch (Exception e)
            {
                //Debug.Print("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: modifiedDate" + ", Value: " + record["ModifiedDate"].ToString());
                throw new Exception("Error while populating entity from DataRow. Expected DataType: " + "Int32" + ", Key: modifiedDate" + ", Value: " + record["ModifiedDate"].ToString() + " Original Exception: " + e.Message);
            }

            for (int i = 0; i < GetFieldCount(); i++)
            {
                if (!(record.Table.Columns.Contains(GetFieldName(i))))
                {
                    continue;
                }

                Type dataType = GetType(i);

                try
                {
                    if (dataType == typeof(string))
                    {
                        SetValue(i, ParseString(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(byte?))
                    {
                        SetValue(i, ParseByte(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(Int32?))
                    {
                        SetValue(i, ParseInt32(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(Decimal?))
                    {
                        SetValue(i, ParseDecimal(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(Char?))
                    {
                        SetValue(i, ParseChar(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(float?))
                    {
                        SetValue(i, ParseFloat(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(Int16?))
                    {
                        SetValue(i, ParseInt16(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(DateTime?))
                    {
                        SetValue(i, ParseDateTime(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(bool?))
                    {
                        SetValue(i, ParseBoolean(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(Int64?))
                    {
                        SetValue(i, ParseInt64(record[GetFieldName(i)].ToString()));
                    }
                    else if (dataType == typeof(Guid?))
                    {
                        SetValue(i, ParseGuid(record[GetFieldName(i)].ToString()));
                    }
                }
                catch (Exception e)
                {
                    //Debug.Print("Error while populating entity from DataRow. Expected DataType: " + dataType + ", Key: " + GetFieldName(i) + ", Value: " + record[GetFieldName(i)].ToString());
                    throw new Exception("Error while populating entity from DataRow. Expected DataType: " + dataType + ", Key: " + GetFieldName(i) + ", Value: " + record[GetFieldName(i)].ToString() + " Original Exception: " + e.Message);
                }
            }
        }

        public virtual String ParseString(string input)
        {
            if (input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return input;
            }
        }

        public virtual Byte? ParseByte(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return Byte.Parse(input);
            }
        }

        public virtual Int16? ParseInt16(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else if (input.Trim() == "AUTO")
            {
                return magicAutoNumber;
            }
            else
            {
                return Int16.Parse(input);
            }
        }

        public virtual Int32? ParseInt32(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else if (input.Trim() == "AUTO")
            {
                return magicAutoNumber;
            }
            else
            {
                return Int32.Parse(input);
            }
        }

        public virtual Int64? ParseInt64(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else if (input.Trim() == "AUTO")
            {
                return magicAutoNumber;
            }
            else
            {
                return Int64.Parse(input);
            }
        }

        public virtual bool? ParseBoolean(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return bool.Parse(input);
            }
        }

        public virtual float? ParseFloat(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return float.Parse(input);
            }
        }

        public virtual double? ParseDouble(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return double.Parse(input);
            }
        }

        public virtual Decimal? ParseDecimal(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return Decimal.Parse(input);
            }
        }

        public virtual Char? ParseChar(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return Convert.ToChar(input);
            }
        }

        public virtual DateTime? ParseDateTime(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else if (input.Trim() == "AUTO")
            {
                return magicAutoDateTime;
            }
            else
            {
                return DateTime.Parse(input);
            }
        }

        public virtual Guid? ParseGuid(string input)
        {
            if (input.Trim() == "" || input.Trim() == "NULL")
            {
                return null;
            }
            else
            {
                return new Guid(input);
            }
        }

        #endregion Virtual Methods

        #region Abstract Methods

        /// <summary>
        ///     Gets the primary key of the Entity.
        /// </summary>
        /// <returns>EntityKey object matching this entity object.</returns>
        public virtual IEntityKey<Entity> GetPrimaryKey()
        {
            return null;
        }

        /// <summary>
        ///     Gets blank primary key of the Entity.
        /// </summary>
        /// <returns>EntityKey object matching this entity object.</returns>
        public virtual IEntityKey<Entity> GetBlankPrimaryKey()
        {
            return null;
        }

        /// <summary>
        ///     Gets the primary key of the Entity.
        /// </summary>
        /// <returns>EntityKey object matching this entity object.</returns>
        public virtual IEntityKey<Entity> GetUniqueKey()
        {
            return null;
        }

         /// <summary>
        ///     Gets the primary key of the Entity.
        /// </summary>
        /// <returns>EntityKey object matching this entity object.</returns>
        public virtual IEntityKey<Entity> GetUniqueKey(string uniqueKey)
        {
            return null;
        }

        /// <summary>
        ///     Gets blank primary key of the Entity.
        /// </summary>
        /// <returns>EntityKey object matching this entity object.</returns>
        public virtual IEntityKey<Entity> GetBlankUniqueKey()
        {
            return null;
        }

            /// <summary>
        ///     Gets blank primary key of the Entity.
        /// </summary>
        /// <returns>EntityKey object matching this entity object.</returns>
        public virtual IEntityKey<Entity> GetBlankUniqueKey(string uniqueKey)
        {
            return null;
        }

        /// <summary>
        ///		Gets the field count.
        /// </summary>
        /// <returns></returns>
        public virtual Int32 GetFieldCount()
        {
            return 0;
        }

        /// <summary>
        ///		Gets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <returns></returns>
        public virtual Object GetValue(Int32 field)
        {
            return null;
        }

        /// <summary>
        ///		Gets the value.
        /// </summary>
        /// <param name="fieldName">Name of field in the entity.</param>
        /// <returns></returns>
        public virtual Object GetValue(string fieldName)
        {
            PropertyDescriptor descriptor = GetProperties().Find(fieldName, true);

            if (descriptor != null)
            {
                return GetProperties().Find(fieldName, true).GetValue(this);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///		Gets the name of the field.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <returns></returns>
        public virtual string GetFieldName(Int32 field)
        {
            return null;
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">bool value.</param>
        public virtual void SetValue(Int32 field, bool? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">Int64 value.</param>
        public virtual void SetValue(Int32 field, Int64? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">Int32 value.</param>
        public virtual void SetValue(Int32 field, Int32? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">Int16 value.</param>
        public virtual void SetValue(Int32 field, Int16? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">byte value.</param>
        public virtual void SetValue(Int32 field, byte? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">float value.</param>
        public virtual void SetValue(Int32 field, float? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">double value.</param>
        public virtual void SetValue(Int32 field, double? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">decimal value.</param>
        public virtual void SetValue(Int32 field, decimal? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">char value.</param>
        public virtual void SetValue(Int32 field, char? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">string value.</param>
        public virtual void SetValue(Int32 field, string value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">DateTime value.</param>
        public virtual void SetValue(Int32 field, DateTime? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">Guid value.</param>
        public virtual void SetValue(Int32 field, Guid? value)
        {
        }

        /// <summary>
        ///		Sets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <param name="value">Byte[] value.</param>

        public virtual void SetValue(Int32 field, BitArray value)
        {
        }       
     
        /// <summary>
        ///		Gets the type.
        /// </summary>
        /// <param name="field">The integer for the field in the entity.</param>
        /// <returns></returns>
        public virtual Type GetType(Int32 field)
        {
            return null;
        }

        #endregion Abstract Methods

        #region ICustomTypeDescriptor Members

        /// <summary>
        ///		Returns a collection of custom attributes for this instance of a component.
        /// </summary>
        /// <returns>
        ///		An <see cref="T:System.ComponentModel.AttributeCollection"/> containing the attributes for this object.
        /// </returns>
        public AttributeCollection GetAttributes()
        {
            //return TypeDescriptor.GetAttributes(this, true);
            return null;
        }

        /// <summary>
        ///		Returns the class name of this instance of a component.
        /// </summary>
        /// <returns>
        ///		The class name of the object, or null if the class does not have a name.
        /// </returns>
        public string GetClassName()
        {
            //return TypeDescriptor.GetClassName(this, true);
            return null;
        }

        /// <summary>
        ///		Returns the name of this instance of a component.
        /// </summary>
        /// <returns>
        ///		The name of the object, or null if the object does not have a name.
        /// </returns>
        public string GetComponentName()
        {
            //return TypeDescriptor.GetComponentName(this, true);
            return null;
        }

        /// <summary>
        ///		Returns a type converter for this instance of a component.
        /// </summary>
        /// <returns>
        ///		A <see cref="T:System.ComponentModel.TypeConverter"/> that is the converter for this object, or null if there is no <see cref="T:System.ComponentModel.TypeConverter"/> for this object.
        /// </returns>
        public TypeConverter GetConverter()
        {
            //return TypeDescriptor.GetConverter(this, true);
            return null;
        }

        /// <summary>
        /// Returns the default event for this instance of a component.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.ComponentModel.EventDescriptor"/> that represents the default event for this object, or null if this object does not have events.
        /// </returns>
        public EventDescriptor GetDefaultEvent()
        {
            //return TypeDescriptor.GetDefaultEvent(this, true);
            return null;
        }

        /// <summary>
        ///		Returns the default property for this instance of a component.
        /// </summary>
        /// <returns>
        ///		A <see cref="T:System.ComponentModel.PropertyDescriptor"/> that represents the default property for this object, or null if this object does not have properties.
        /// </returns>
        public PropertyDescriptor GetDefaultProperty()
        {
            //return TypeDescriptor.GetDefaultProperty(this, true);
            return null;
        }

        /// <summary>
        ///		Returns an editor of the specified type for this instance of a component.
        /// </summary>
        /// <param name="editorBaseType">A <see cref="T:System.Type"/> that represents the editor for this object.</param>
        /// <returns>
        ///		An <see cref="T:System.Object"/> of the specified type that is the editor for this object, or null if the editor cannot be found.
        /// </returns>
        public object GetEditor(Type editorBaseType)
        {
            //return TypeDescriptor.GetEditor(this, editorBaseType, true);
            return null;
        }

        /// <summary>
        ///		Returns the events for this instance of a component using the specified attribute array as a filter.
        /// </summary>
        /// <param name="attributes">An array of type <see cref="T:System.Attribute"/> that is used as a filter.</param>
        /// <returns>
        ///		An <see cref="T:System.ComponentModel.EventDescriptorCollection"/> that represents the filtered events for this component instance.
        /// </returns>
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }

        /// <summary>
        ///		Returns the events for this instance of a component.
        /// </summary>
        /// <returns>
        ///		An <see cref="T:System.ComponentModel.EventDescriptorCollection"/> that represents the events for this component instance.
        /// </returns>
        public EventDescriptorCollection GetEvents()
        {
            return TypeDescriptor.GetEvents(this, true);
        }

        /// <summary>
        ///		Returns the properties for this instance of a component using the attribute array as a filter.
        /// </summary>
        /// <param name="attributes">An array of type <see cref="T:System.Attribute"/> that is used as a filter.</param>
        /// <returns>
        ///		A <see cref="T:System.ComponentModel.PropertyDescriptorCollection"/> that represents the filtered properties for this component instance.
        /// </returns>
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }

        /// <summary>
        ///		Returns the properties for this instance of a component.
        /// </summary>
        /// <returns>
        ///		A <see cref="T:System.ComponentModel.PropertyDescriptorCollection"/> that represents the properties for this component instance.
        /// </returns>
        public PropertyDescriptorCollection GetProperties()
        {
            int noOfFields = GetFieldCount();
            int noOfBaseFields = 7;

            PropertyDescriptor[] descriptors = new PropertyDescriptor[noOfBaseFields + noOfFields];

            descriptors[0] = new CustomPropertyDescriptor("CreatedBy", typeof(string), -1);
            descriptors[1] = new CustomPropertyDescriptor("CreatedDate", typeof(DateTime?), -2);
            descriptors[2] = new CustomPropertyDescriptor("ModifiedBy", typeof(string), -3);
            descriptors[3] = new CustomPropertyDescriptor("ModifiedDate", typeof(DateTime?), -4);
            descriptors[4] = new CustomPropertyDescriptor("isSelected", typeof(bool), -5);
            descriptors[5] = new CustomPropertyDescriptor("isDirty", typeof(bool), -6);
            descriptors[6] = new CustomPropertyDescriptor("uIAddionalSearchCriteria", typeof(string), -7);

            for (Int16 i = 0; i < noOfFields; i++)
            {
                descriptors[noOfBaseFields + i] = new CustomPropertyDescriptor(GetFieldName(i), GetType(i), i);
            }

            return new PropertyDescriptorCollection(descriptors);
        }

        /// <summary>
        ///		Gets the property owner of propertyDescriptor.
        /// </summary>
        /// <param name="propertyDescriptor">The property descriptor.</param>
        /// <returns>Returns object propertyDescriptor.</returns>
        public object GetPropertyOwner(PropertyDescriptor propertyDescriptor)
        {
            return this;
        }

        #endregion ICustomTypeDescriptor Members

        #region IComparable Members

        public virtual int CompareTo(object o)
        {
            if (o == null)
            {
                //Debug.Print("Comparison failed. Object2 is null");
                return 1;
            }

            if (!this.GetType().Equals(o.GetType()))
            {
                //Debug.Print("Comparison failed. Object2 is of type ({0}) different that Object1 ({1}).", this.GetType().ToString(), o.GetType().ToString());
                return -1;
            }

            Entity e = (Entity)o;

            if (createdBy != null || e.createdBy != null)
            {
                if (createdBy == null)
                {
                    DebugPrintCompareFailed("CreatedBy", createdBy, e.createdBy);
                    return -1;
                }

                if (e.createdBy == null)
                {
                    DebugPrintCompareFailed("CreatedBy", createdBy, e.createdBy);
                    return 1;
                }

                int compare = createdBy.Value.CompareTo(e.createdBy);

                if (compare != 0)
                {
                    DebugPrintCompareFailed("CreatedBy", createdBy, e.createdBy);
                    return compare;
                }
            }

            if (createdDate != null || e.createdDate != null)
            {
                if (createdDate == null)
                {
                    DebugPrintCompareFailed("CreatedDate", createdDate, e.createdDate);
                    return -1;
                }

                if (e.createdDate == null)
                {
                    DebugPrintCompareFailed("CreatedDate", createdDate, e.createdDate);
                    return 1;
                }

                int compare = ((DateTime)createdDate).ToString("yyyy-MMM-dd HH:mm:ss").CompareTo(((DateTime)e.createdDate).ToString("yyyy-MMM-dd HH:mm:ss"));

                if (compare != 0)
                {
                    if ((DateTime)createdDate == magicAutoDateTime)
                    {
                        //Do nothing as this is auto generated number and no check is required
                        compare = 0;
                    }
                    else
                    {
                        DebugPrintCompareFailed("CreatedDate", createdDate, e.createdDate);
                        return compare;
                    }
                }
            }

            if (modifiedBy != null || e.modifiedBy != null)
            {
                if (modifiedBy == null)
                {
                    DebugPrintCompareFailed("ModifiedBy", modifiedBy, e.modifiedBy);
                    return -1;
                }

                if (e.modifiedBy == null)
                {
                    DebugPrintCompareFailed("ModifiedBy", modifiedBy, e.modifiedBy);
                    return 1;
                }

                int compare = modifiedBy.Value.CompareTo(e.modifiedBy);

                if (compare != 0)
                {
                    DebugPrintCompareFailed("ModifiedBy", modifiedBy, e.modifiedBy);
                    return compare;
                }
            }

            if (modifiedDate != null || e.modifiedDate != null)
            {
                if (modifiedDate == null)
                {
                    DebugPrintCompareFailed("ModifiedDate", modifiedDate, e.modifiedDate);
                    return -1;
                }

                if (e.modifiedDate == null)
                {
                    DebugPrintCompareFailed("ModifiedDate", modifiedDate, e.modifiedDate);
                    return 1;
                }

                int compare = ((DateTime)modifiedDate).ToString("yyyy-MMM-dd HH:mm:ss").CompareTo(((DateTime)e.modifiedDate).ToString("yyyy-MMM-dd HH:mm:ss"));

                if (compare != 0)
                {
                    if ((DateTime)modifiedDate == magicAutoDateTime)
                    {
                        //Do nothing as this is auto generated number and no check is required
                        compare = 0;
                    }
                    else
                    {
                        DebugPrintCompareFailed("ModifiedDate", modifiedDate, e.modifiedDate);
                        return compare;
                    }
                }
            }

            for (int i = 0; i < GetFieldCount(); i++)
            {
                string fieldName = GetFieldName(i);
                object thisValue = GetValue(i);
                object otherValue = e.GetValue(i);

                if (IsIdentity(i) == false && (thisValue != null || otherValue != null))
                {
                    if (thisValue == null)
                    {
                        DebugPrintCompareFailed(fieldName, thisValue, otherValue);
                        return -1;
                    }

                    if (otherValue == null)
                    {
                        DebugPrintCompareFailed(fieldName, thisValue, otherValue);
                        return 1;
                    }

                    int compare = 0;

                    if (thisValue is DateTime?)
                    {
                        compare = ((DateTime)thisValue).ToString("yyyy-MMM-dd HH:mm:ss").CompareTo(((DateTime)otherValue).ToString("yyyy-MMM-dd HH:mm:ss"));
                    }
                    else if (thisValue is decimal?) //Added By Shibu
                    {
                        compare = decimal.Compare(decimal.Parse(GetValue(i).ToString()), decimal.Parse(e.GetValue(i).ToString()));
                    }
                    else if (thisValue is int?) 
                    {
                        compare = int.Parse(GetValue(i).ToString()) - int.Parse(e.GetValue(i).ToString());
                    }
                    else
                    {
                        compare = GetValue(i).ToString().CompareTo(e.GetValue(i).ToString());
                    }

                    if (compare != 0)
                    {
                        if ((thisValue is Int16?) && ((Int16)thisValue == magicAutoNumber))
                        {
                            //Do nothing as this is auto generated number and no check is required
                            compare = 0;
                        }
                        else if ((thisValue is Int32?) && ((Int32)thisValue == magicAutoNumber))
                        {
                            //Do nothing as this is auto generated number and no check is required
                            compare = 0;
                        }
                        else if ((thisValue is Int64?) && ((Int64)thisValue == magicAutoNumber))
                        {
                            //Do nothing as this is auto generated number and no check is required
                            compare = 0;
                        }
                        else if ((thisValue is string) && ((string)thisValue == "AUTO"))
                        {
                            //Do nothing as this is auto generated number and no check is required
                            compare = 0;
                        }
                        else if ((thisValue is DateTime?) && ((DateTime)thisValue == magicAutoDateTime))
                        {
                            //Do nothing as this is auto generated number and no check is required
                            compare = 0;
                        }
                        else
                        {
                            DebugPrintCompareFailed(fieldName, thisValue, otherValue);
                            return compare;
                        }
                    }
                }
            }

            return 0;
        }

        private void DebugPrintCompareFailed(string fieldName, Object value1, Object value2)
        {
            if (value1 == null)
            {
                //Debug.Print("Comparison failed for field: {0}. Value1 is null", fieldName);
            }
            else if (value2 == null)
            {
                //Debug.Print("Comparison failed for field: {0}. Value2 is null", fieldName);
            }
            else
            {
                //Debug.Print("Comparison failed for field: {0}. Value1: {1}, Value2 {2}", fieldName, value1.ToString(), value2.ToString());
            }
        }

        /// <summary>
        /// ConvertToByte converts BitArray to byte[]
        /// </summary>
        /// <param name="bits">BitArray</param>
        /// <returns>byte[]</returns>
        byte[] ConvertToByte(BitArray bits)
        {
            BitArray _bits;
            int bitSize = bits.Count % 8 == 0 ? bits.Count : bits.Count + 8 - (bits.Count % 8);
            _bits = new BitArray(bitSize);

            if (_bits.Count != bits.Count)
            {
                for (int i = bits.Count - 1; i < _bits.Count; i++)
                {
                    _bits[i] = false;
                }
            }
            
            byte[] bytes = new byte[_bits.Count / 8];
            bits.CopyTo(bytes, 0);
            return bytes;
        }

        #endregion

        #region Object Members

        public override bool Equals(object other)
        {
            return ToString().Equals(other.ToString());
        }
        /// <summary>
        ///     Get the hash code of this object.
        /// </summary>
        /// <returns>Loops over all the fields and XORs their hash codes to get one.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        #endregion
    }
}

