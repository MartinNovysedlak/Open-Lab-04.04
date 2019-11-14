using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            var b = numbers;
            return ($"({b[0]}{b[1]}{b[2]}) {b[3]}{b[4]}{b[5]}-{b[6]}{b[7]}{b[8]}{b[9]}");
        }
    }
}
