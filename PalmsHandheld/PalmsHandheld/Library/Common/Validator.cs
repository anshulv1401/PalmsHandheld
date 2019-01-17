#region Header Comment
/*------------------------------------------------------------------------------------ 
Author                          : Unknown User                             
Date                            : 10-03-2009
Created At                      : Technoforte
Purpose (Template), in Detail   : class defines the basic rules.
Logic Structure                 : 
Modification History:                                                                  
Date         Modified By      Modified At      Revision Summary                                     
----------   ------------     -----------    ------------------------------------------         
-------------------------------------------------------------------------------------*/
#endregion Header Comment

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Technoforte.PALMS.Exceptions;
using System.Reflection;

namespace Technoforte.PALMS.Entities
{
    /// <summary>
    ///     Base class for all the validation entities
    /// </summary>
    public abstract class Validator
    {
        /// <summary>
        ///     Object of <see cref="Validation"/> class which has all the basic rules defined.
        /// </summary>
        List<List<Validation>> validations;

        public static Validator GetValidator(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Object o = null;

            o = assembly.CreateInstance(className);

            if (o == null)
            {
                o = assembly.CreateInstance(className + "Base");
            }

            return (Validator)o;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Validator"/> class.
        /// </summary>
        /// <param name="noOfFields">The integer for the number of field's in the entity.</param>
        public Validator(Int32 noOfFields)
        {
            validations = new List<List<Validation>>();

            for (Int32 i = 0; i < noOfFields; i++)
            {
                try
                {
                    validations.Add(GetValidations(i));
                }
                catch
                {
                    //Do nothing. This is temporary arrangement.
                }
            }
        }

        /// <summary>
        ///     Gets the validations.
        /// </summary>
        /// <param name="field">Integer for the field in the entity.</param>
        /// <returns></returns>
        public abstract List<Validation> GetValidations(Int32 field);

        /// <summary>
        ///     Validates the specified entity.
        /// </summary>
        /// <param name="entity">Object of Entity Class.</param>
        /// <returns></returns>
        public virtual List<ValidationResult> Validate(Entity entity)
        {
            List<ValidationResult> list = new List<ValidationResult>();

            for (Int32 i = 0; i < validations.Count; i++)
            {
                list.AddRange(Validate(entity, i));
            }

            return list;
        }

        /// <summary>
        ///     Validates the specified entity.
        /// </summary>
        /// <param name="entity">Object of Entity Class.</param>
        /// <param name="field">Integer for the field in the entity.</param>
        /// <returns></returns>
        public virtual List<ValidationResult> Validate(Entity entity, Int32 field)
        {
            List<ValidationResult> list = new List<ValidationResult>();

            foreach (Validation validation in validations[field])
            {
                ValidationResult result = validation.Validate(entity);

                if (result.ErrorCode != 0)
                {
                    list.Add(result);
                }
            }

            return list;
        }
    }
}
