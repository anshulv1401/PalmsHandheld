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
using System.ComponentModel;
using Technoforte.PALMS.Exceptions;

namespace Technoforte.PALMS.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomPropertyDescriptor : PropertyDescriptor
    {
        public string name = "";
        public Int32 field;
        public Type type;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomPropertyDescriptor"/> class.
        /// </summary>
        /// <param name="name">name of PropertyDescriptor.</param>
        /// <param name="type">type of PropertyDescriptor.</param>
        /// <param name="field">field of PropertyDescriptor.</param>
        public CustomPropertyDescriptor(string name, Type type, Int32 field)
            : base(name, null)
        {
            this.name = name;
            this.type = type;
            this.field = field;
        }

        /// <summary>
        /// When overridden in a derived class, returns whether resetting an object changes its value.
        /// </summary>
        /// <param name="component">The component to test for reset capability.</param>
        /// <returns>
        /// true if resetting the component changes its value; otherwise, false.
        /// </returns>
        public override bool CanResetValue(object component)
        {
            return true;
        }

        /// <summary>
        /// When overridden in a derived class, gets the type of the component this property is bound to.
        /// </summary>
        /// <returns>A <see cref="T:System.Type"/> that represents the type of component this property is bound to. When the <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)"/> or <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)"/> methods are invoked, the object specified might be an instance of this type.</returns>
        public override Type ComponentType
        {
            get { return typeof(Entity); }
        }

        /// <summary>
        /// When overridden in a derived class, gets the current value of the property on a component.
        /// </summary>
        /// <param name="component">The component with the property for which to retrieve the value.</param>
        /// <returns>
        /// The value of a property for a given component.
        /// </returns>
        public override object GetValue(object component)
        {
            if (field >= 0)
            {
                return ((Entity)component).GetValue(field);
            }
            else
            {
                switch (field)
                {
                    case -1:
                        return ((Entity)component).createdBy;
                    case -2:
                        return ((Entity)component).createdDate;
                    case -3:
                        return ((Entity)component).modifiedBy;
                    case -4:
                        return ((Entity)component).modifiedDate;
                    case -5:
                        return ((Entity)component).isSelected;
                    case -6:
                        return ((Entity)component).isDirty;
                    case -7:
                        return ((Entity)component).uIAddionalSearchCriteria;
                    default:
                        return null;
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether this property is read-only.
        /// </summary>
        /// <value></value>
        /// <returns>true if the property is read-only; otherwise, false.</returns>
        public override bool IsReadOnly
        {
            get { return false; }
        }

        /// <summary>
        /// When overridden in a derived class, gets the type of the property.
        /// </summary>
        /// <value></value>
        /// <returns>A <see cref="T:System.Type"/> that represents the type of the property.</returns>
        public override Type PropertyType
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// When overridden in a derived class, resets the value for this property of the component to the default value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be reset to the default value.</param>
        public override void ResetValue(object component)
        {
            if (field > -1)
            {
                if (((Entity)component).GetType(field) == typeof(string))
                    ((Entity)component).SetValue(field, (string)null);
                else if (((Entity)component).GetType(field) == typeof(decimal?))
                    ((Entity)component).SetValue(field, (decimal?)null);
                else if (((Entity)component).GetType(field) == typeof(bool?))
                    ((Entity)component).SetValue(field, (bool?)null);
                else if (((Entity)component).GetType(field) == typeof(Guid?))
                    ((Entity)component).SetValue(field, (Guid?)null);
                else if (((Entity)component).GetType(field) == typeof(Int64?))
                    ((Entity)component).SetValue(field, (Int64?)null);
                else if (((Entity)component).GetType(field) == typeof(Int32?))
                    ((Entity)component).SetValue(field, (Int32?)null);
                else if (((Entity)component).GetType(field) == typeof(Byte?))
                    ((Entity)component).SetValue(field, (Byte?)null);
                else if (((Entity)component).GetType(field) == typeof(float?))
                    ((Entity)component).SetValue(field, (float?)null);
                else if (((Entity)component).GetType(field) == typeof(double?))
                    ((Entity)component).SetValue(field, (double?)null);
                else if (((Entity)component).GetType(field) == typeof(char?))
                    ((Entity)component).SetValue(field, (char?)null);
                else if (((Entity)component).GetType(field) == typeof(DateTime?))
                    ((Entity)component).SetValue(field, (DateTime?)null);
                else
                    throw (new InvalidOperationException("Error!"));
            }
            else
            {
                switch (field)
                {
                    case -1:
                        ((Entity)component).createdBy = null;
                        break;
                    case -2:
                        ((Entity)component).createdDate = null;
                        break;
                    case -3:
                        ((Entity)component).modifiedBy = null;
                        break;
                    case -4:
                        ((Entity)component).modifiedDate = null;
                        break;
                    case -5:
                        ((Entity)component).isSelected = null;
                        break;
                    case -6:
                        ((Entity)component).isDirty = null;
                        break;
                    case -7:
                        ((Entity)component).uIAddionalSearchCriteria = null;
                        break;
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, sets the value of the component to a different value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be set.</param>
        /// <param name="value">The new value.</param>
        public override void SetValue(object component, object value)
        {
            if (field > -1)
            {
                if (((Entity)component).GetType(field) == typeof(string))
                    ((Entity)component).SetValue(field, Convert.ToString(value));
                else if (((Entity)component).GetType(field) == typeof(decimal?))
                    ((Entity)component).SetValue(field, Convert.ToDecimal(value));
                else if (((Entity)component).GetType(field) == typeof(bool?))
                    ((Entity)component).SetValue(field, Convert.ToBoolean(value));
                else if (((Entity)component).GetType(field) == typeof(Guid?))
                    ((Entity)component).SetValue(field, (Guid?)value);
                else if (((Entity)component).GetType(field) == typeof(Int64?))
                    ((Entity)component).SetValue(field, Convert.ToInt64(value));
                else if (((Entity)component).GetType(field) == typeof(Int32?))
                    ((Entity)component).SetValue(field, Convert.ToInt32(value));
                else if (((Entity)component).GetType(field) == typeof(Byte?))
                    ((Entity)component).SetValue(field, Convert.ToByte(value));
                else if (((Entity)component).GetType(field) == typeof(float?))
                    ((Entity)component).SetValue(field, float.Parse(Convert.ToString(value)));
                else if (((Entity)component).GetType(field) == typeof(double?))
                    ((Entity)component).SetValue(field, Convert.ToDouble(value));
                else if (((Entity)component).GetType(field) == typeof(char?))
                    ((Entity)component).SetValue(field, Convert.ToChar(value));
                else if (((Entity)component).GetType(field) == typeof(DateTime?))
                    ((Entity)component).SetValue(field, Convert.ToDateTime(value));
                else
                    throw (new InvalidOperationException("Error!"));
            }
            else
            {
                switch (field)
                {
                    case -1:
                        ((Entity)component).createdBy = (int?)(value);
                        break;
                    case -2:
                        ((Entity)component).createdDate = (DateTime?)(value);
                        break;
                    case -3:
                        ((Entity)component).modifiedBy = (int?)(value);
                        break;
                    case -4:
                        ((Entity)component).modifiedDate = (DateTime?)(value);
                        break;
                    case -5:
                        ((Entity)component).isSelected = (Boolean?)(value);
                        break;
                    case -6:
                        ((Entity)component).isDirty = (Boolean?)(value);
                        break;
                    case -7:
                        ((Entity)component).uIAddionalSearchCriteria = (string)(value);
                        break;
                }
            }
        }

        /// <summary>
        /// When overridden in a derived class, determines a value indicating whether the value of this property needs to be persisted.
        /// </summary>
        /// <param name="component">The component with the property to be examined for persistence.</param>
        /// <returns>
        /// true if the property should be persisted; otherwise, false.
        /// </returns>
        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }
    }
}