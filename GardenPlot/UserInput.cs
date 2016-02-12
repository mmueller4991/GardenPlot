using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlot
{
    public class UserInput
    {
        public string[] UserInputArray { get; set; }
      
        public void GetUserInput()
        {
            string getUserInput = Console.ReadLine();
            UserInputArray = getUserInput.Split(' ');
            
        }
    }
}
