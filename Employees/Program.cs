using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSystem
{
    class Program
    {
        static void Main()
        {
            IInputReader inputReader;

            Console.WriteLine("Input from:\n1.File\n2.Console");
            int inputMode = int.Parse(Console.ReadLine());

            if(inputMode == 1)
            {
                inputReader = new FileReader();
            }
            else
            {
                inputReader = new ConsoleInput();
            }

            try
            {
                String input = inputReader.GetInput();
                String[] lines = input.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                EmployeesHierarchy SoftDudes = new EmployeesHierarchy(lines);
                String firstDude = lines[0];
                String secondDude = lines[1];

                Console.WriteLine(SoftDudes);

                String lowestCommonLeader = SoftDudes.LowestCommonLeader(firstDude, secondDude);

                if (lowestCommonLeader != null)
                {
                    Console.WriteLine("Common leader of " + firstDude + " and " + secondDude + " is " + lowestCommonLeader);
                }
                else
                {
                    Console.WriteLine("Common leader of " + firstDude + " and " + secondDude + " is " + SoftDudes.RootLeader);
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
