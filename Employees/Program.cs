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
            EmployeesHierarchy SoftDudes = new EmployeesHierarchy();

            SoftDudes.AddRelation("Nikolay", "Simeon");
            SoftDudes.AddRelation("Nikolay", "Anton");
            SoftDudes.AddRelation("Anton", "Dragan");
            SoftDudes.AddRelation("Dragan", "Petar");
            SoftDudes.AddRelation("Dragan", "Blagoy");
            SoftDudes.AddRelation("Petar", "Dimitar");
            SoftDudes.AddRelation("Blagoy", "Ivan");
            SoftDudes.AddRelation("Anton", "Megi<3");
            SoftDudes.RootLeader = "Nikolay";

            String output = SoftDudes.ToString();
            Console.WriteLine(output);

            String lowestCommonLeader = SoftDudes.LowestCommonLeader("Simeon", "Megi<3");
            Console.WriteLine(lowestCommonLeader);
        }
    }
}
