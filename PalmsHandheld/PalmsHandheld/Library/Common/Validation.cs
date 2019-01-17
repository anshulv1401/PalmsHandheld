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
using Technoforte.PALMS.Exceptions;

namespace Technoforte.PALMS.Entities
{
    /// <summary>
    /// <see cref="ValidationException"/> class is inherited class of <see cref="System.Exception"/>
    /// which is used for validating exceptions
    /// </summary>

    [Serializable]
    public class ValidationException : PalmsException
    {
        public List<ValidationResult> validationResults = null;

        public ValidationException(List<ValidationResult> validationResults)
            : base(validationResults.GetString())
        {
            this.validationResults = validationResults;
        }
    }

    /// <summary>
    /// <see cref="Validation"/> class provides all the basic validation rules.
    /// </summary>
    public class Validation
    {
        protected Int32 field;

        /// <summary>
        /// Initializes a new instance of the <see cref="Validation"/> class.
        /// </summary>
        /// <param name="field">Integer for the field in the entity.</param>
        public Validation(Int32 field)
        {
            this.field = field;
        }

        /// <summary>
        /// Validates the specified entity.
        /// </summary>
        /// <param name="entity">Object of Entity Class.</param>
        /// <returns>Object of <see cref="ValidationResult"/> class.</returns>
        public virtual ValidationResult Validate(Entity entity)
        {
            return new ValidationResult(0, field, entity.GetFieldName(field), null, null);
        }

        /// <summary>
        /// Gets the validators.
        /// </summary>
        /// <param name="field">Integer for the field in the entity.</param>
        /// <param name="rules">The rules.</param>
        /// <returns>List object of <see cref="Validation"/> class.</returns>
        public static List<Validation> GetValidations(Int32 field, Rules rules)
        {
            return GetValidations(field, rules, null, null);
        }

        /// <summary>
        /// Gets the validators.
        /// </summary>
        /// <param name="field">Integer for the field in the entity.</param>
        /// <param name="rules">Object of <see cref="Rules"/> Enumerator.</param>
        /// <param name="minimum">minimum size of the integer field.</param>
        /// <param name="maximum">maximum size of the integer field.</param>
        /// <returns></returns>
        public static List<Validation> GetValidations(Int32 field, Rules rules, double? minimum, double? maximum)
        {
            List<Validation> list = new List<Validation>();                     

            return list;
        }
    }
}
