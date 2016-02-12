using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GardenPlot
{
    public class FileReader
    {
        private string _filename;
        public FileReader(string filename)
        {
            this._filename = filename; 
        }
        public List<Plot> ReadFile()
        {
            using (FileStream fs = new FileStream(_filename, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<Plot> plots = new List<Plot>();
                    while (!sr.EndOfStream)
                    {
                        string storeString = sr.ReadLine();
                        string[] parseString = storeString.Split(',');                       
                        plots.Add(new Plot(int.Parse(parseString[0]), int.Parse(parseString[1]), int.Parse(parseString[2]), int.Parse(parseString[3])));
                    }
                    return plots; 
                }
            }
        }
    }
}
