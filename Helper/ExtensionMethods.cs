using System;
using System.Linq;

namespace Helper
{
    /// <summary>
    /// Extension Methods Helper class. This contains common and easily used extension methods for your projects.
    /// </summary>
    public static class ExtensionMethods
    {
        #region GetFinancialYear
        /// <summary>
        /// A DateTime extension method that finds the current financial year.
        /// </summary>
        /// <param name="dt">The current date</param>
        /// <param name="financialYearStartMonth">The month that the new financial year starts on</param>
        /// <returns>The financial year that the supplied date is currently in.</returns>
        public static int GetFinancialYear(this DateTime dt, int financialYearStartMonth)
        {
            int month = dt.Month;
            int year = dt.Year;
            if (month >= financialYearStartMonth)
            {
                return (year + 1);
            }
            else
            {
                return year;
            }
        }
        #endregion

        #region PropertyCount
        /// <summary>
        /// This is a simple extension method to count the properties in an object
        /// </summary>
        /// <param name="obj">The object to find the property count for</param>
        /// <returns>An Integer Count of the properties found</returns>
        public static int PropertyCount(this Object obj)
        {
            return obj.GetType().GetProperties().Count();
        }
        #endregion

        #region ReturnNumericIntFromString
        /// <summary>
        /// A String extension method that returns a numeric integer from string.
        /// </summary>
        /// <remarks>
        ///          Example: Return "5 145" as 5145
        ///          Convert.ToInt32("5 145") fails because of the space.
        /// </remarks>
        /// <param name="value">The String value to act on.</param>
        /// <returns>The numeric Integer from the string</returns>
        public static int ReturnNumericIntFromString(this String value)
        {
            int i = 0;
            if (Int32.TryParse(value, out i))
            {
                return i;
            }
            else
            {
                string result = new String(value.Where(x => Char.IsDigit(x)).ToArray());
                if (int.TryParse(result, out i))
                {
                    return i;
                }
                else
                    return i;
            }
        }
        #endregion

        #region IsEqualToIgnoreCase
        /// <summary>A String extension method that returns a boolean value after comparing string equality.</summary>
        /// <remarks>
        ///          Example: string sVal1 = "hello";
        ///                   string sCompare = "HELLO";
        ///                   bool blnEqual = sVal.IsEqualToIgnoreCase(sCompare);
        /// </remarks>
        /// <param name="value">The String value to act on.</param>
        /// <param name="compareToString">The String value to compare to.</param>
        /// <returns>The Boolean Result.</returns>
        public static bool IsEqualToIgnoreCase(this String value, string compareToString)
        {
            // Avoid using .ToUpper() or .ToLower() to compare strings. Using either upper or lower creates a new string
            // Using StringComparison.InvariantCultureIgnoreCase doesn't create anew string and is suited for an Extension method
            if (value.Equals(compareToString, StringComparison.InvariantCultureIgnoreCase))
                return true;
            else
                return false;
        }
        #endregion

        #region IsValidURL
        /// <summary>
        /// Checks that a URL is valid
        /// </summary>
        /// <param name="value">The URL to validate</param>
        /// <returns>True or False</returns>
        public static bool IsValidURL(this String value)
        {
            Uri uri = null;
            if (!Uri.TryCreate(value, UriKind.RelativeOrAbsolute, out uri))
                return false; // Invalid URL
            else
                return true; // Valid URL                      
        }
        #endregion
    }
}
