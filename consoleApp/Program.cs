using Helper;
using System;

namespace consoleApp
{
    /// <summary>
    /// Program class to test Extension Methods
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main test console app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            #region Calculate Financial Year
            // Calculate Financial Year
            int iFinYear = DateTime.Now.GetFinancialYear(2);
            Console.WriteLine("// Extension method: GetFinancialYear(2)");
            Console.WriteLine("The financial year (starting in Feb) for the current date: " + iFinYear);
            #endregion

            #region Count the properties in the Human class
            // Count the properties in the Human class
            Human oHuman = new Human();
            int iPropCount = oHuman.PropertyCount();
            Console.WriteLine("");
            Console.WriteLine("// Extension method: PropertyCount()");
            Console.WriteLine("The Human class Property Count: " + iPropCount);
            #endregion

            #region Return the Numeric Integer from a String value
            // Return the Numeric Integer from a String value
            string sValue = "5 421";
            int iIntegerValue = sValue.ReturnNumericIntFromString();
            Console.WriteLine("");
            Console.WriteLine("// Extension method: ReturnNumericIntFromString()");
            Console.WriteLine("The " + iIntegerValue.GetType() + " value of 5 421: " + iIntegerValue);
            #endregion

            #region A String extension method that returns a boolean value after comparing string equality
            // A String extension method that returns a boolean value after comparing string equality
            string sCompareString = "hello";
            string sCompareWith = "HeLlO";
            bool blnEqual = sCompareString.IsEqualToIgnoreCase(sCompareWith);
            Console.WriteLine("");
            Console.WriteLine("// Extension method: IsEqualToIgnoreCase(sCompareWith)");
            Console.WriteLine("Ignoring case, the string " + sCompareString + " is equal to " + sCompareWith + " : " + blnEqual);
            #endregion

            #region Checks that a URL is valid
            // Checks that a URL is valid
            string sURL = "www.google.com";
            bool blnValid = sURL.IsValidURL();
            Console.WriteLine("");
            Console.WriteLine("// Extension method: IsValidURL()");
            Console.WriteLine("Is the URL " + sURL + " valid: " + blnValid); 
            #endregion

            Console.Read();
        }
    }

    /// <summary>
    /// The Human class is a test object for the ExtensionMethods class
    /// </summary>
    public class Human
    {
        /// <summary>
        /// The Human Age
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// The Human First name
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// The Human Last Name
        /// </summary>
        public string LastName { get; set; }
    }
}
