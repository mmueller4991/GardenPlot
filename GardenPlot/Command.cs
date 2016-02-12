using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlot
{
    public class Command
    {
        private UserInput _userInput; 


        public Command()
        {
            _userInput = new UserInput(); 
            _userInput.GetUserInput(); 
        }
        public void ExecuteCommand()
        {
            switch (_userInput.UserInputArray[0])
            {
                case "1":
                    break;
                case "2":
                    FileReader fr = new FileReader(_userInput.UserInputArray[1]);
                    List<Plot> plots = fr.ReadFile();
                    Garden garden = new Garden(plots);
                    //garden.GetFencing();
                    Console.WriteLine(garden.GetFencing());      
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break; 
            }
        }
    }
}
