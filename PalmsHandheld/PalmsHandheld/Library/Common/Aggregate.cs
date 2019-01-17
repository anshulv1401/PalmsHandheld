using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Technoforte.PALMS.Entities
{
    [Serializable]
    public enum AggregateType
    {
        Default,
        None,
        GroupBy,
        Sum,
        Average,
        Minimum,
        Maximum
    }

    [Serializable]
    public class Aggregate
    {
        public string fieldName;
        public AggregateType aggregateType;

        private object t = null;

        public Aggregate()
        {
            //Do nothing
        }

        public Aggregate(string fieldName, AggregateType aggregateType)
        {
            this.aggregateType = aggregateType;
            this.fieldName = fieldName;
        }

        public void Validate<T>()
        {
            t = default(T);

            if (t is Int16? || t is Int32? || t is Int64? || t is Decimal? || t is float?)
            {
                //Do nothing
            }
            else if (t is DateTime)
            {
                if (aggregateType == AggregateType.Sum)
                {
                    throw new ArgumentException("Type argument T is 'DateTime'. Aggregate 'Sum' is not possible.");
                }
            }
            else if (t is string || t is Char?)
            {
                if (aggregateType == AggregateType.Sum || aggregateType == AggregateType.Average)
                {
                    throw new ArgumentException("Type argument T is 'string' / 'Char?'. Aggregate 'Sum' / 'Average' is not possible.");
                }
            }
            else
            {
                if (aggregateType != AggregateType.Default && aggregateType != AggregateType.GroupBy)
                {
                    throw new ArgumentException("Type argument T is '" + t.GetType() + "'. Aggregate '" + aggregateType.ToString() + "' is not possible.");
                }
            }
        }

        public virtual AggregateType GetApplicableAggregateType()
        {
            if (this.aggregateType == AggregateType.Default)
            {
                if (t is Int16? || t is Int32? || t is Int64? || t is Decimal? || t is float?)
                {
                    return AggregateType.Sum;
                }
                else if (t is DateTime)
                {
                    return AggregateType.Maximum;
                }
                else if (t is string || t is Char?)
                {
                    return AggregateType.Maximum;
                }
                else
                {
                    return AggregateType.None;
                }
            }
            else
            {
                return aggregateType;
            }
        }
    }

    [Serializable]
    public class AggregateResult
    {
        public Aggregate aggregate;
        public object result;
        
        public virtual object GetResult()
        {
            return null;
        }

        public virtual void SetResult(object result)
        {
            // Do Nothing
        }
    }

    [Serializable]
    public class AggregateResult<T> : AggregateResult
    {        
        public override object GetResult()
        {
            return result;
        }

        public override void SetResult(object result)
        {
            this.result = (T)result;
        }
    }
}
