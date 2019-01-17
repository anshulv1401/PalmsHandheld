using System;
using System.Diagnostics;

namespace Technoforte.PALMS.Entities
{
    [Serializable]
    public class EntityKey<E> : IEntityKey<E> where E : Entity
    {
        #region Abstract Methods

        /// <summary>
        ///		Gets the field count.
        /// </summary>
        /// <returns></returns>
        public virtual int GetFieldCount()
        {
            return 0;
        }

        /// <summary>
        ///		Gets the value.
        /// </summary>
        /// <param name="field">The integer for the field in the Entity Key.</param>
        /// <returns></returns>
        public virtual Object GetValue(int field)
        {
            return null;
        }

        /// <summary>
        ///		Gets the name of the field.
        /// </summary>
        /// <param name="field">The integer for the field in the Entity Key.</param>
        /// <returns></returns>
        public virtual string GetFieldName(int field)
        {
            return null;
        }

        /// <summary>
        ///		Gets the type.
        /// </summary>
        /// <param name="field">The integer for the field in the Entity Key.</param>
        /// <returns></returns>
        public virtual Type GetType(int field)
        {
            return null;
        }

        /// <summary>
        ///     Gets and Entity Object filled with the key.
        /// </summary>
        /// <returns></returns>
        public virtual E GetBlankEntityWithKey()
        {
            return null;
        }

        /// <summary>
        ///     Gets the Class Name of the actual object.
        /// </summary>
        /// <returns></returns>
        public virtual string GetClassName()
        {
            return null;
        }

        #endregion Abstract Methods

        #region Virtual Methods

        /// <summary>
        ///     Creates a human readable string.
        /// </summary>
        /// <returns>Loops over all the fields and creates one tab-separated human readbale string.</returns>
        public override string ToString()
        {
            string output = "Class: " + GetClassName();

            for (int field = 0; field < GetFieldCount(); field++)
            {
                output += "\t " + GetFieldName(field) + ": " + (GetValue(field) == null ? "NULL" : GetValue(field).ToString());
            }

            return output;
        }

        #endregion Virtual Methods

        #region Object Members

        public override bool Equals(object other)
        {
            return ToString().Equals(other.ToString());
        }
        /// <summary>
        ///     Get the hash code of this object.
        /// </summary>
        /// <returns>Loops over all the fields and XORs their hashcodes to get one.</returns>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        #endregion
    }
}
