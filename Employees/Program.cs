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
            
            String output = SoftDudes.ToString();
            Console.WriteLine(output);

            SoftDudes.LowestCommonLeader("Nikolay", "Simeon", "Megi<3");
            Console.WriteLine(SoftDudes.lowestCommonLeader);
        }
    }
}
