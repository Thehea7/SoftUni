using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private readonly int width;
        private readonly int height;

        public Rectangle(int width, int height)
        {
            Width = width; Height = height;
        }

        public int Height
        {
            get => height;
            init => height = value; 
        }


        public int Width
        {
            get => width;
            init => width = value;
        }


        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height -1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int width, char end, char mid)
        {
            Console.Write(end);
            for (int i = 1; i < width -1; ++i)
            {
                Console.Write(mid);
            }

            Console.WriteLine(end);
        }
    }
}
