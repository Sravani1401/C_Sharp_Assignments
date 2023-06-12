using ConsoleApp21;
using System;
namespace MaximumProductofAdjacentdigits
{
    /// <summary>
    /// Validations to view for given input
    /// </summary>


    class ValidationsForMaxProduct
    {
        /// <summary>
        /// Method to find Validations to view for given input
        /// </summary>
        /// <param name="givenValue"></param>
        /// <returns></returns>
        public bool CheckLength(string givenInput)
        {
            for (int i = 0; i < givenInput.Length; i++)
            {
                if (givenInput[i] < '0' || givenInput[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }
        public bool TestcasesValidations(string givenInput)
        {
            string result;
            HandlingCases o = new HandlingCases();
            if (givenInput.Length == 0 || givenInput.Length < 4)
            {

                result = "There are no 4 digits in givenValue";
                o.Print(result);
                return false;
            }
            if (CheckLength(givenInput) == false)
            {
                result = "There should be only positive numerical values";
                o.Print(result);
                return false;
            }
            return true;
        }




    }
}
