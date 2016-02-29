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
<<<<<<< HEAD
            
            String input = inputReader.GetInput();
            String[] lines = input.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            try
            {
=======

            try
            {
                String input = inputReader.GetInput();
                String[] lines = input.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
>>>>>>> 892d4863aa24f6a1016827fc5928e0809fcaec97
                EmployeesHierarchy SoftDudes = new EmployeesHierarchy(lines);
                String firstDude = lines[0];
                String secondDude = lines[1];

                Console.WriteLine(SoftDudes);

                String lowestCommonLeader = SoftDudes.LowestCommonLeader(firstDude, secondDude);
<<<<<<< HEAD
                Console.WriteLine(lowestCommonLeader);
=======

                if (lowestCommonLeader != null)
                {
                    Console.WriteLine("Common leader of " + firstDude + " and " + secondDude + " is " + lowestCommonLeader);
                }
                else
                {
                    Console.WriteLine("Common leader of " + firstDude + " and " + secondDude + " is " + SoftDudes.RootLeader);
                }
>>>>>>> 892d4863aa24f6a1016827fc5928e0809fcaec97
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
