using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSystem
{
    public class ConsoleInput : IInputReader
    {
        public String GetInput()
        {
            Console.WriteLine("Please enter all of the leader-employee pairs. Start with entering the employees for which you will search the lowest common leader. After that enter all of the pairs, starting with the general manager. Enter a blank line to finish adding.");

            StringBuilder result = new StringBuilder();
            String input = Console.ReadLine();

            while(input != "")
            {
                result.Append(input + "\n");

                input = Console.ReadLine();
            }

            return result.ToString();
        }
    }
}
