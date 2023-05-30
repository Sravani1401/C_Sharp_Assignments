namespace BinaryAddition
{
     class FractionalPart
    {
        public string FractionalTobinary(double m)
        {

            int count = 0;
            string conversion;
            string binary = "";
            while (m != 1)
            {
                m = m * 2;
                conversion = m.ToString();
                binary = binary + (conversion[0]);
                if (m > 1)
                {
                    m = m - 1;
                }
                count++;
                if (count == 23)
                {
                    break;
                }
            }
            string result = "";
            for (int i = 0; i <= (23 - binary.Length); i++)
            {
                result = result + 0;
            }
            string h = binary + result;

            return h;
        }
    }
}
