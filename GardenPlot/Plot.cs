using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlot
{
    public class Plot
    {
        private int _x;
        private int _y;
        private int _w;
        private int _h;
        public Plot(int x, int y, int w, int h)
        {
            _x = x;
            _y = y;
            _w = w;
            _h = h;
        }

        public int Perimeter()
        {
            return 2 * (_w + _h); 
        }


        public override string ToString()
        {
            return $"{_x}, {_y}, {_w}, {_h}";
        }
    }
}
