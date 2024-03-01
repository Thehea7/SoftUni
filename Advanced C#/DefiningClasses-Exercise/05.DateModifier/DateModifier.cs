using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = System.Math;

namespace DefiningClasses
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secondDate;
        private int differenceInDays;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = DateTime.Parse(firstDate);
            this.secondDate = DateTime.Parse(secondDate);
        }

        public int DifferenceInDays
        {
            get => Math.Abs((int)(firstDate - secondDate).TotalDays);
        }
    }
}
