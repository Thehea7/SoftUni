using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _01.ClassBoxData
{
    public class Box
    {
        
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }


        public double Length
        {
            get => length;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
                }
                length = value;
            } 
        }

        public double Width
        {
            get => width;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
                }
                width = value;
            }
        }
        public double Height
        {
            get => height;

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double SurfaceArea()
        {
            return 2*(width * height + width * length + height * length);
        }
        public double LateralSurfaceArea()
        {
            return 2 * (width +length) * height;
        }

        public double Volume()
        {
            return width * height * length;
        }
    }
}
