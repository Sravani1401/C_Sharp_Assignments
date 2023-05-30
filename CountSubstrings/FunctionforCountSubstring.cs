using System.Collections.Generic;
namespace Substrings
{
    /// <summary>
    /// Class to Find Index positions  and  Number of Substrings
    /// </summary>

    class FunctionForCountSubstring
    {
        /// <summary>
        /// Method Function to find the index position of start of substring and Count Number of Strings 
        /// </summary>
        /// <param name="givenstring"></param>
        /// <param name="givensubstring"></param>
        /// <returns>
        /// returns a list of indexpositions and Number of Substrings
        /// </returns>
        public List<int> CountSubstringsAndIndexPositions(string givenstring, string givensubstring)
        {
            List<int> List1 = new List<int>();
            int noOfSubstrings = 0;
            for (int i = 0; i <= givenstring.Length - givensubstring.Length; i++)
            {

                if (givenstring[i] == givensubstring[0])
                {
                    int j = 0, count = 0, k = i;
                    while (j < givensubstring.Length)
                    {

                        if (givenstring[k] == givensubstring[j])
                        {
                            count++;
                        }
                        j++;
                        k++;
                    }

                    int substringLength = givensubstring.Length;
                    if (count == substringLength)
                    {
                        noOfSubstrings++;
                        List1.Add((k - (substringLength)));
                    }
                }
            }
            List1.Add(noOfSubstrings);
            return List1;

        }
    }
}
