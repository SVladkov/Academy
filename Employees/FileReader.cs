using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSystem
{
    class FileReader : IInputReader
    {
        public string GetInput()
        {
            String input = System.IO.File.ReadAllText("../../input.txt");

            return input;
        }
    }
}
