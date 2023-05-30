namespace BinaryAddition
{
     class BinaryAdditionForBinary
    {
        public string BinaryAdditionForBoth(string Input1, string Input2, int carry)
        {
            string result = "";
            int m = Input1.Length - 1;
            int n = Input2.Length - 1;
            int sum = 0;
            while (m >= 0 || n >= 0)
            {
                sum = carry;
                sum = sum + (Input1[m] - '0');
                sum = sum + (Input2[n] - '0');
                result = result + (sum % 2).ToString();
                carry = sum / 2;
                m--;
                n--;
            }
            if (carry != 0)
            {
                result = result + carry;
            }
            string reversestring = "";
            int count = 0;
            int g = result.Length - 1;
            while (g >= 0)
            {
                reversestring = reversestring + result[g];
                g--;
            }
            return (reversestring);
        }

    }
}
