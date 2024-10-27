using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    internal static class DateUtil
    {
        public static int yearofBirth(int age)
        { 
            return DateTime.Now.Year - age;
        }
        public static int yearofBirth(DateTime dateofBirth)
        {
            if(dateofBirth == null)
                return 0;
            return dateofBirth.Year;
        }
        public static int Age(DateTime dateofBirth)
        {
            if(dateofBirth == null)
                return 0;
            return DateTime.Now.Year - dateofBirth.Year;
        }

    }
}
