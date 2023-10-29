using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enum_Generics.Practice.Helpers
{
    internal static class Extension
    {
        public static bool CheckEmail(this string email)
        {
            int count = 0;
            foreach (int item  in email)
            {
                if (count == '@')
                {
                    count++;
                }

                if(count ==2)
                {
                    break;
                }
            }

            if (count == 1)
            {
                return true;
            }
            else
            {
                return false; 
            }   
        }

        public static bool CheckTrim(this string email,string pattern)
        {
            return Regex.IsMatch(email,pattern);
        }

        public static string GetFullName(this Person person)
        {
            return $"{person.Name}-{person.SurName}";

        }
        public static int MultipleOfNums(this int[] nums)
        {
            int multiple = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                multiple *= nums[i];
            }
            return multiple;
        }
    }
}
