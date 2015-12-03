using Helper;
using System;

namespace consoleApp
{
    /// <summary>
    /// Program class to test Extension Methods
    /// </summary>
    class Program
    {

        enum WorkWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5
        }

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

            #region Check if a value is contained in a list
            // Checks if a variable exists in an array of values
            string TestString = "fox";
            bool exists = TestString.ExistsIn("the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog");
            Console.WriteLine("");
            Console.WriteLine("// Extension method: ExistsIn(array)");
            Console.WriteLine("The " + TestString.GetType() + " value '" + TestString + "' exists in the array: " + exists);

            int iVal = 342;
            exists = iVal.ExistsIn(23, 55, 342, 99, 144);
            Console.WriteLine("The " + iVal.GetType() + " value " + iVal + " exists in the array: " + exists);

            int day = (int)DateTime.Now.DayOfWeek;
            exists = day.ExistsIn((int)WorkWeek.Monday, (int)WorkWeek.Tuesday, (int)WorkWeek.Wednesday, (int)WorkWeek.Thursday, (int)WorkWeek.Friday);
            Console.WriteLine("The " + day.GetType() + " value " + day + " exists in the Work Week enumeration: " + exists);
            #endregion

            #region Inject is an easier way to perform a String.Format
            // Performs a String.Format
            string StringToFormat = "One {0} to rule them {1} and in the {2} {3} them";
            string FormattedString = StringToFormat.Inject("Ring", "all", "darkness", "bind");
            Console.WriteLine("");
            Console.WriteLine("// Extension method: Inject(array)");
            Console.WriteLine(FormattedString);
            #endregion

            #region LogException
            // Writes an exception to a log which needs to be implemented.Currently only outputs the error to the Visual Studio Output window
            try
            {
                int ZeroValue = 0;
                int IntegerValue = 10;
                int Result = IntegerValue / ZeroValue;
            }
            catch (Exception ex)
            {
                ex.LogException();                
            }

            try
            {
                string NullValue = null;
                if (null == NullValue) throw new ArgumentNullException(nameof(NullValue));
            }
            catch (Exception ex)
            {
                ex.LogException();                
            }

            Console.WriteLine("");
            Console.WriteLine("// Extension method: LogException()");
            Console.WriteLine("See the Exception in the Visual Studio Output window.");
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
