using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IWcfService
    {
        public int AddDigits(int value)
        {
            int sum = 0;

            while (value != 0)
            {
                sum += value % 10;
                value /= 10;
            }

            return sum;
        }

        public string CheckIfPrimeNumber(int value)
        {
            if (value == 1) return "not a prime number";
            if (value == 2) return "a prime number";

            var limit = Math.Ceiling(Math.Sqrt(value));

            for (int i = 2; i <= limit; ++i)
                if (value % i == 0)
                    return "not a prime number";
            return "a prime number";
        }

        public string PrintHtmlTag(string tag, string value)
        {
            return "<" + tag + ">" + value + "</" + tag + ">";
        }

        public string ReverseString(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }

        public int[] SortNumbers(int[] numbers, bool ascending)
        {
            if (ascending)
            {
                Array.Sort(numbers);

                return numbers;
            }

            else
               return numbers.OrderByDescending(x => x).ToArray();
        }
    }
}
