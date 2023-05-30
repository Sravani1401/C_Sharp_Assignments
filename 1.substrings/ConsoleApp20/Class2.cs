namespace ConsoleApp20
{
     class Validations
    {
        public static int TestcasesValidation(string givenString,string givenSubString)
        {
            int result;
            if (givenString.Length == 0 || givenSubString.Length == 0 || givenString.Length == 0 && givenSubString.Length == 0)
            {
                result = 0;
            }
            else
            {
                result = 1;
            }
            return result;
        }
    }
}
