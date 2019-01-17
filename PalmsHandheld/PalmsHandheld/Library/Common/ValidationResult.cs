#region Header Comment
/*------------------------------------------------------------------------------------ 
Author                          : Unknown User                             
Date                            : dd/MM/YYYY
Created At                      : Technoforte
Purpose (Template), in Detail   : class provides all the basic rules for validating the data.
Logic Structure                 : 
Modification History:                                                                  
Date         Modified By      Modified At      Revision Summary                                     
----------   ------------     -----------    ------------------------------------------         
-------------------------------------------------------------------------------------*/
#endregion Header Comment

using System;

namespace Technoforte.PALMS.Entities
{
    /// <summary>
    /// <see cref="Rules"/> class provides all the basic rules for validating the data.
    /// </summary>
    [Flags]
    public enum Rules : long
    {
        /// <summary>
        /// If it is NONE then, the field is not validated.
        /// </summary>
        NONE = 1,

        /// <summary>
        /// If it is REQUIRED then, the field is mandatory and cannot be null.
        /// </summary>
        REQUIRED = NONE * 2,

        /// <summary>
        /// If it is NO_SPACE then, the field will not allow space.
        /// </summary>
        NO_SPACE = REQUIRED * 2,

        /// <summary>
        /// If it is NO_SPECIAL_CHAR then, the field will not any allow special characters.
        /// </summary>
        NO_SPECIAL_CHAR = NO_SPACE * 2, //Numeral, Alphabet, Hyphen, Space Allowed

        /// <summary>
        /// If it is NO_HYPHEN then, the field will not allow hyphen .
        /// </summary>
        NO_HYPHEN = NO_SPECIAL_CHAR * 2,

        /// <summary>
        /// If it is NO_NUMERAL then, the field will not allow numerics
        /// </summary>
        NO_NUMERAL = NO_HYPHEN * 2,

        /// <summary>
        /// If it is NO_ALPHABET then, the field will not allow alphabets
        /// </summary>
        NO_ALPHABET = NO_NUMERAL * 2,

        /// <summary>
        /// If it is LENGTH then, the field will not allow alphabets
        /// </summary>
        LENGTH = NO_ALPHABET * 2,

        /// <summary>
        /// If it is RANGE then, the field will not allow alphabets
        /// </summary>
        RANGE = LENGTH * 2,

        /// <summary>
        /// If it is POSITIVE then, the field will allow only positive numbers
        /// </summary>
        POSITIVE = RANGE * 2,

        /// <summary>
        /// If it is EMAIL then, the field will be checked for email syntax.
        /// </summary>
        EMAIL = POSITIVE * 2,

        /// <summary>
        /// If it is PHONENO then, the field will be checked for given phone format
        /// </summary>
        PHONENO = EMAIL * 2,

        /// <summary>
        /// If it is WEB_ADDRESS then, the field will be checked for given web address format
        /// </summary>
        WEB_ADDRESS = PHONENO * 2,

        /// <summary>
        /// If it is PASSWORD then, the field will be checked for given password format
        /// </summary>
        PASSWORD = WEB_ADDRESS * 2,

        /// <summary>
        /// If it is ZIPCODE then, the field will not allow alphabets
        /// </summary>
        ZIPCODE = NO_SPACE | NO_SPECIAL_CHAR | NO_ALPHABET,

        #region Stock Component Error Codes

        /// <summary>
        /// Transaction Rate Exception
        /// </summary>
        TRANSACTION_RATE_EXCEPTION = PASSWORD * 2,

        /// <summary>
        /// Cost Buckets Exception
        /// </summary>
        COST_BUCKETS_EXCEPTION = TRANSACTION_RATE_EXCEPTION * 2,

        /// <summary>
        /// Bucket Quantity Exception
        /// </summary>
        BUCKET_QUANTITY_EXCEPTION = COST_BUCKETS_EXCEPTION * 2,

        /// <summary>
        /// Update Moving Average Exception
        /// </summary>
        UPDATE_MOVING_AVERAGE_EXCEPTION = BUCKET_QUANTITY_EXCEPTION * 2,

        /// <summary>
        /// Insert Into CostTransaction Table Exception
        /// </summary>
        INSERT_INTO_TRANSCOST_TABLE_EXCEPTION = UPDATE_MOVING_AVERAGE_EXCEPTION * 2,

        #endregion Stock Component Error Codes

        #region Customer Order Error Codes

        /// <summary>
        /// Ordered Quantity Not Sum of Allocated, BackOrder and Cancelled Quantity
        /// </summary>
        ORDERED_QTY_NOT_SUM_OF_ALLOCATED_BACKORDER_CANCEL = INSERT_INTO_TRANSCOST_TABLE_EXCEPTION * 2,

        #endregion Customer Order Error Codes

        #region Purchase Order Error Codes

        /// <summary>
        /// Ordered Quantity Not Sum of Received, Pending and Cancelled Quantity
        /// </summary>
        ORDERED_QTY_NOT_SUM_OF_RECEIVED_PENDING_CANCEL = ORDERED_QTY_NOT_SUM_OF_ALLOCATED_BACKORDER_CANCEL * 2,

        #endregion Customer Order Error Codes

        #region Quantity Count Component Error Codes

        /// <summary>
        /// Both LocationID and PackID Cannot Be NULL
        /// </summary>
        BOTH_LOCATION_ID_AND_PACK_ID_CANNOT_BE_NULL = ORDERED_QTY_NOT_SUM_OF_RECEIVED_PENDING_CANCEL * 2,

        #endregion Quantity Count Component Error Codes

        #region GRN Creation Component Error Codes

        /// <summary>
        /// Both ActualFreightChargesInSupplierCurrency and EstimatedFreightChargesInSupplierCurrency Cannot Be NULL
        /// </summary>
        BOTH_ACTUAL_FREIGHT_CHARGES_IN_SUPPLIER_CURRENCY_AND_ESTIMATED_FREIGHT_CHARGES_IN_SUPPLIER_CURRENCY_CANNOT_BE_NULL = BOTH_LOCATION_ID_AND_PACK_ID_CANNOT_BE_NULL * 2,

        #endregion GRN Creation Component Error Codes

        #region Customer Master Creation And Updation Component Error Codes

        /// <summary>
        /// Both City and State/Province cannot be null
        /// </summary>
        BOTH_CITY_AND_STATE_OR_PROVINCE_CANNOT_BE_NULL = BOTH_ACTUAL_FREIGHT_CHARGES_IN_SUPPLIER_CURRENCY_AND_ESTIMATED_FREIGHT_CHARGES_IN_SUPPLIER_CURRENCY_CANNOT_BE_NULL * 2,

        #endregion Customer Master Creation And Updation Component Error Codes

        /// <summary>
        /// If it is NO_NEGATIVE then, the field will allow only non-negative numbers
        /// </summary>
        NO_NEGATIVE = BOTH_CITY_AND_STATE_OR_PROVINCE_CANNOT_BE_NULL * 2,

        /// <summary>
        /// In Stock Change Instruction Creation Input both PartCostID and PackID cannot be null
        /// </summary>
        STOCK_CHANGE_BOTH_PART_COST_AND_PACK_CANNOT_BE_NULL = NO_NEGATIVE * 2,

        /// <summary>
        /// In Stock Change Instruction Creation Input both PartCostID and PackID cannot be not null
        /// </summary>
        STOCK_CHANGE_BOTH_PART_COST_AND_PACK_CANNOT_BE_NOT_NULL = STOCK_CHANGE_BOTH_PART_COST_AND_PACK_CANNOT_BE_NULL * 2,

        /// <summary>
        /// In Sales Order Creation Input SalesOrderDate cannot be greater than current date
        /// </summary>
        SALES_ORDER_DATE_CANNOT_BE_GREATER_THAN_CURRENT_DATE = STOCK_CHANGE_BOTH_PART_COST_AND_PACK_CANNOT_BE_NOT_NULL * 2,

        /// <summary>
        /// In Sales Order Creation Input if IsRestrictedToPreferredWarehouse is true then PreferredWarehouseID cannot be null
        /// </summary>
        SALES_ORDER_IF_ISRESTRICTEDTOPREFERREDWAREHOUSE_IS_TRUE_THEN_PREFERREDWAREHOUSEID_CANNOT_BE_NULL = SALES_ORDER_DATE_CANNOT_BE_GREATER_THAN_CURRENT_DATE * 2,
        
        /// <summary>
        /// In Sales Order Creation Input if IsRestrictedToPreferredWarehouse is false then PreferredWarehouseID cannot be not null
        /// </summary>
        SALES_ORDER_IF_ISRESTRICTEDTOPREFERREDWAREHOUSE_IS_FALSE_THEN_PREFERREDWAREHOUSEID_CANNOT_BE_NOT_NULL = SALES_ORDER_IF_ISRESTRICTEDTOPREFERREDWAREHOUSE_IS_TRUE_THEN_PREFERREDWAREHOUSEID_CANNOT_BE_NULL * 2
    }

    /// <summary>
    /// <see cref="ValidationResult"/> class provides details for validations
    /// </summary>
    public class ValidationResult
    {
        private static readonly string FieldTag = "<FieldName>";
        private static readonly string Value1Tag = "<Value1>";
        private static readonly string Value2Tag = "<Value2>";

        private Rules errorCode = 0;
        private Int32 field = 0;
        private string fieldName = "";
        private object value1 = null;
        private object value2 = null;
        private Int32 rowNo = -1;


        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>The error code.</value>
        public Rules ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>The field.</value>
        public Int32 Field
        {
            get { return field; }
            set { field = value; }
        }
        /// <summary>
        /// Gets or sets the name of the field.
        /// </summary>
        /// <value>The name of the field.</value>
        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }
        /// <summary>
        /// Gets or sets the value1.
        /// </summary>
        /// <value>The value1.</value>
        public object Value1
        {
            get { return value1; }
            set { value1 = value; }
        }
        /// <summary>
        /// Gets or sets the value2.
        /// </summary>
        /// <value>The value2.</value>
        public object Value2
        {
            get { return value2; }
            set { value2 = value; }
        }
        /// <summary>
        /// Gets or sets the row no.
        /// </summary>
        /// <value>The row no.</value>
        public Int32 RowNo
        {
            get { return rowNo; }
            set { rowNo = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="field">The field.</param>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="value1">The value1.</param>
        /// <param name="value2">The value2.</param>
        public ValidationResult(Rules errorCode, Int32 field, string fieldName, object value1, object value2)
        {
            this.errorCode = errorCode;
            this.field = field;
            this.fieldName = fieldName;
            this.value1 = value1;
            this.value2 = value2;
        }

        /// <summary>
        /// Gets the error message.
        /// </summary>
        /// <param name="errorTemplate">The error template.</param>
        /// <returns></returns>
        public string GetErrorMessage(string errorTemplate)
        {
            string returnString = errorTemplate;

            returnString.Replace(FieldTag, fieldName);

            if (value1 != null)
                returnString.Replace(Value1Tag, value1.ToString());

            if (value2 != null)
                returnString.Replace(Value2Tag, value2.ToString());

            return returnString;
        }

        /// <summary>
        ///     Converts ValidationResult to String
        /// </summary>
        /// <returns>Converted string from ValidationResult</returns>
        public override string ToString()
        {
            string error = "Invalid " + FieldName + ": ";

            switch (errorCode)
            {
                case Rules.BOTH_ACTUAL_FREIGHT_CHARGES_IN_SUPPLIER_CURRENCY_AND_ESTIMATED_FREIGHT_CHARGES_IN_SUPPLIER_CURRENCY_CANNOT_BE_NULL:
                    error += "Both 'Actual Freight Charges' and 'Estimated Freight Charges' cannot be empty.";
                    break;
                case Rules.BOTH_CITY_AND_STATE_OR_PROVINCE_CANNOT_BE_NULL:
                    error += "Both 'City' and 'State or Province' cannot be empty.";
                    break;
                case Rules.BOTH_LOCATION_ID_AND_PACK_ID_CANNOT_BE_NULL:
                    error += "Both 'Location' and 'Pack' cannot be empty.";
                    break;
                case Rules.BUCKET_QUANTITY_EXCEPTION:
                    error += "Not enough available quantity in stock bucket.";
                    break;
                case Rules.COST_BUCKETS_EXCEPTION:
                    error += "For a stock dbTransaction either of 'From Cost Bucket' and 'To Cost Bucket' should be null";
                    break;
                case Rules.EMAIL:
                    error += "Incorrect Email format.";
                    break;
                case Rules.INSERT_INTO_TRANSCOST_TABLE_EXCEPTION:
                    error += "Could not insert record in CostTransaction table.";
                    break;
                case Rules.LENGTH:
                    error += "Length of value should be in between '" + value1.ToString() + "' and '" + value2.ToString() + "'.";
                    break;
                case Rules.NO_ALPHABET:
                    error += "Value should not contain any alphabet.";
                    break;
                case Rules.NO_HYPHEN:
                    error += "Value should not contain any hyphen.";
                    break;
                case Rules.NO_NUMERAL:
                    error += "Value should not contain any numeral.";
                    break;
                case Rules.NO_SPACE:
                    error += "Value should not contain any space.";
                    break;
                case Rules.NO_SPECIAL_CHAR:
                    error += "Value should not contain any special character.";
                    break;
                case Rules.ORDERED_QTY_NOT_SUM_OF_ALLOCATED_BACKORDER_CANCEL:
                    error += "Ordered Quantity '" + value1.ToString() + "' is not equal to Allocated Quantity + Backorder Quantity + Cancelled Quantity '" + value2.ToString() + "'.";
                    break;
                case Rules.ORDERED_QTY_NOT_SUM_OF_RECEIVED_PENDING_CANCEL:
                    error += "Ordered Quantity '" + value1.ToString() + "' is not equal to Received Quantity + Pending Quantity + Cancelled Quantity '" + value2.ToString() + "'.";
                    break;
                case Rules.PASSWORD:
                    error += "Incorrect Password format.";
                    break;
                case Rules.PHONENO:
                    error += "Incorrect Phone Number format.";
                    break;
                case Rules.POSITIVE:
                    error += "Value should be positive.";
                    break;
                case Rules.NO_NEGATIVE:
                    error += "Value should not be negative.";
                    break;
                case Rules.RANGE:
                    error += "Value should be in between '" + value1.ToString() + "' and '" + value2.ToString() + "'";
                    break;
                case Rules.REQUIRED:
                    error += "Value cannot be empty.";
                    break;
                case Rules.TRANSACTION_RATE_EXCEPTION:
                    error += "For a cost transaction Transaction Rate cannot be empty.";
                    break;
                case Rules.UPDATE_MOVING_AVERAGE_EXCEPTION:
                    error += "Could not update moving average.";
                    break;
                case Rules.WEB_ADDRESS:
                    error += "Incorrect Web Address format.";
                    break;
                case Rules.ZIPCODE:
                    error += "Incorrect Zip code format.";
                    break;
                default:
                    break;
            }

            if (RowNo > 0)
            {
                error += " In Record(" + Convert.ToString(RowNo + 1) + ").";
            }

            return error;
        }
    }
}
