using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    public class TimeCalculator
    {
        public int ConvertMinutesToSeconds(int minutes)
        {
            if (minutes < 0)
            {
                throw new Exception("This method converts minutes to seconds. if the minutes are below 0 it is already converted to seconds");
            }
            return minutes * 60;
        }
    }
}
