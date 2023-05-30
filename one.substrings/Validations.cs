namespace Substrings
{
    /// <summary>
    /// Validations to view for given input
    /// </summary>
    class Validations
    {
        /// <summary>
        /// Method For input TestCases 
        /// </summary>
        /// <param name="givenString"></param>
        /// <param name="givenSubString"></param>
        /// <returns>
        /// returns result for invalid input
        /// </returns>
        public bool TestcasesValidations(string givenString, string givenSubString)
        {
            ExceptionHandling object1 = new ExceptionHandling();
            string result;
            if ((givenString.Length == 0 && givenSubString.Length == 0))
            {
                result = "Input givensubstring and givenstring should not be empty";
                object1.Display(result);
                return false;

            }
            if ((givenString.Length == 0))
            {
                result = "Input givenstring should not be empty";
                object1.Display(result);
                return false;
            }
            if (givenSubString.Length == 0)
            {
                result = "Input givensubstring should not be empty";
                object1.Display(result);
                return false;
            }


            return true;
        }
    }
}
