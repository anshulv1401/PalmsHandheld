using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Palms.Handheld.Library.Common
{
    public static class UOMConverter
    {
        public static decimal ConvertUOM(int fromUOMID, int toUOMID, decimal fromUOMQuantity, decimal fromUOMMultiplicationFactorToConvertToStorageUOM, decimal ToUOMMultiplicationFactorToConvertToStorageUOM
            ,int fromUOMCategoryID, int toUOMCategoryID)
        {
            decimal toUOMQuantity = 0m;

            if (fromUOMCategoryID != toUOMCategoryID)
            {
                toUOMQuantity = Convert.ToDecimal(fromUOMQuantity * fromUOMMultiplicationFactorToConvertToStorageUOM) / Convert.ToDecimal(ToUOMMultiplicationFactorToConvertToStorageUOM);
            }
            else
            {
                toUOMQuantity = Convert.ToDecimal(fromUOMQuantity * fromUOMMultiplicationFactorToConvertToStorageUOM) / Convert.ToDecimal(ToUOMMultiplicationFactorToConvertToStorageUOM);
            }

            return toUOMQuantity;
        }
    }
}