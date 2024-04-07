using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Drawers;

namespace Chess
{
    internal class ChessGame
    {
        private IDrawer drawer;

        public ChessGame(IDrawer drawer)
        {
            this.drawer = drawer;
        }
        public void Start()
        {
            while (true)
            {
                drawer.WriteLine("--------");
                drawer.WriteLine("PPPPPPPP");
                drawer.WriteLine("--------");
                drawer.WriteLine("--------");
                drawer.WriteLine("--------");
                drawer.WriteLine("--------");
                drawer.WriteLine("PPPPPPPP");
                drawer.WriteLine("--------");

                Thread.Sleep(5000);
            }
        }
    }
}
