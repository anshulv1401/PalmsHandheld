using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data;

namespace Technoforte.PALMS.Entities
{
    public static class ListExtension
    {
        public static List<T2> CreateCopy<T1, T2>(this List<T1> list)
            where T1 : Entity
            where T2 : Entity, new()
        {
            List<T2> outputList = new List<T2>();

            foreach (T1 input in list)
            {
                T2 output = new T2();
                
                input.CopyTo(output);
                outputList.Add(output);
            }

            return outputList;
        }

        public static string GetString<T>(this List<T> list)
        {
            string returnString = "";

            if (list == null || list.Count == 0)
            {
                returnString += "Null or empty list.";
            }
            else
            {
                foreach (T obj in list)
                {
                    returnString += "\r\n" + obj.ToString();
                }
            }

            return returnString;
        }      

        public static int CompareTo<T>(this List<T> thisList, List<T> otherList) where T : Entity
        {
            if (otherList == null)
            {
                throw new ArgumentNullException("otherList");
            }

            if (thisList.Count != otherList.Count)
            {               
                throw new ArgumentOutOfRangeException("otherList", "Number of items in otherList do not match with that of this list. Can not compare!");
            }

            for (int i = 0; i < thisList.Count; i++)
            {
                if (thisList[i] == null)
                {
                    return -1;
                }

                int compare = thisList[i].CompareTo(otherList[i]);

                if (compare != 0)
                {                   
                    return compare;
                }
            }

            return 0;
        }

        public static void FillFromKeyValueRecordList<T>(this List<T> list, List<KeyValueRecord> keyValueRecordList) where T : Entity, new()
        {
            if (keyValueRecordList == null)
            {
                throw new ArgumentNullException("otherList");
            }

            int i = 0;

            foreach (KeyValueRecord keyValueRecord in keyValueRecordList)
            {
                T entity = new T();

                try
                {
                    entity.FillFromKeyValueRecord(keyValueRecord);
                }
                catch (Exception e)
                {
                    throw new Exception("Error while filling record no " + i + " from keyValueRecordList. " + e.Message);
                }

                list.Add(entity);
                i++;
            }
        }

        public static void FillFromDataTable<T>(this List<T> list, DataTable dataTable) where T : Entity, new()
        {
            if (dataTable == null)
            {
                throw new ArgumentNullException("otherList");
            }

            int i = 0;

            foreach (DataRow record in dataTable.Rows)
            {
                T entity = new T();

                try
                {
                    entity.FillFromDataRow(record);
                }
                catch (Exception e)
                {
                    throw new Exception("Error while filling record no " + i + " from DataTable. " + e.Message);
                }

                list.Add(entity);
                i++;
            }
        }

        public static List<T> Sort<T>(this List<T> list, int field) where T : Entity
        {
            list.Sort((new EntityComparer<T>(field)).Compare);
            return list;
        }

        public static List<KeyValueRecord> ToKeyValueRecordList<T>(this List<T> list) where T : Entity
        {
            List<KeyValueRecord> keyValueRecords = new List<KeyValueRecord>();

            foreach (T entity in list)
            {
                keyValueRecords.Add(entity.ToKeyValueRecord());
            }

            return keyValueRecords;
        }
    }

    public class EntityComparer<T> where T : Entity
    {
        private int field;

        public EntityComparer(int field)
        {
            this.field = field;
        }

        public int Compare(T e1, T e2)
        {
            Object value1 = e1.GetValue(field);
            Object value2 = e2.GetValue(field);

            if (value1 == null)
            {
                if (value2 == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (value2 == null)
                {
                    return 1;
                }
                else
                {
                    return value1.ToString().CompareTo(value2.ToString());
                }
            }
        }
    }
}
