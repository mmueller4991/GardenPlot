using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenPlot
{
    public class FileWriter
    {
        private string _fileName;
        public FileWriter(string filename)
        {
            this._fileName = filename;
        }

        public void WriteFile(List<Plot> plots)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Plot plot in plots)
                    {
                        sw.WriteLine(plot);
                    }
                }
            }
        }
    }
}
