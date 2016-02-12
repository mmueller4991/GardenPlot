using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlot
{
    public class Garden
    {
        private List<Plot> _plots; 

        public Garden(List<Plot> plots)
        {
            _plots = plots; 
        }

        public int GetFencing()
        {
            int TotalFencing = 0; 
            foreach (Plot plots in _plots)
            {
                TotalFencing += plots.Perimeter(); 
            }
            return TotalFencing; 
        }
    }
}
