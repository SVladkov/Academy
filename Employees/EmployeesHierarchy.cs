using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSystem
{
    public class EmployeesHierarchy
    {
        private Dictionary<String, List<String>> employees;
        private String lowestCommonLeader;
        private String rootLeader;

        public EmployeesHierarchy(String[] inputData)
        {
            employees = new Dictionary<String, List<String>>();

            FillData(inputData);
        }

        private void FillData(String[] input)
        {
            for (int i=2; i< input.Length; i++)
            {
                String[] inputAsArray = input[i].Split(new string[] { "-", "- ", " - ", " -", " " }, StringSplitOptions.None);

                this.AddRelation(inputAsArray[0], inputAsArray[1]);
            }

            this.RootLeader = input[2].Split(new string[] { "-", "- ", " - ", " -", " " }, StringSplitOptions.None)[0];
        }

        public String RootLeader
        {
            get
            {
                return this.rootLeader;
            }

            set
            {
                this.rootLeader = value;
            }
        }

        public void AddRelation(String leaderName, String employeeName)
        {
            if(employees.ContainsKey(leaderName))
            {
                employees[leaderName].Add(employeeName);
            }
            else
            {
                List<String> currentEmployees = new List<String>();
                currentEmployees.Add(employeeName);

                employees.Add(leaderName, currentEmployees);
            }
        }

        public override String ToString()
        {
            StringBuilder output = new StringBuilder();

            foreach(KeyValuePair<String, List<String>> relation in employees)
            {
                output.Append("Leader: " + relation.Key + " ");

                if (relation.Value != null)
                {
                    output.Append("Employees: ");

                    foreach (String employee in relation.Value)
                    {
                        output.Append(employee + ", ");
                    }
                }
                //output.Remove(output.Length - 1, 1);
                output.Length -= 2;

                output.Append("\n");
            }

            return output.ToString();
        }

        public String LowestCommonLeader(String firstEmployee, String secondEmployee)
        {
            LowestCommonLeader(rootLeader, firstEmployee, secondEmployee);

            return lowestCommonLeader;
        }

        private int LowestCommonLeader(String searchedEmployee, String firstEmployee, String secondEmployee)
        {
            List<String> directEmployees;

            if (employees.ContainsKey(searchedEmployee))
            {
                directEmployees = employees[searchedEmployee];
            }
            else
            {
                if (searchedEmployee == firstEmployee || searchedEmployee == secondEmployee)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            switch (directEmployees.Count)
            {
                case 0:
                    if(searchedEmployee == firstEmployee || searchedEmployee == secondEmployee)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case 1:
                    if (searchedEmployee == firstEmployee || searchedEmployee == secondEmployee)
                    {
                        return 1 + LowestCommonLeader(directEmployees[0], firstEmployee, secondEmployee);
                    }
                    else
                    {
                        return LowestCommonLeader(directEmployees[0], firstEmployee, secondEmployee);
                    }
                case 2:
                    int numberInLeftBranch = LowestCommonLeader(directEmployees[0], firstEmployee, secondEmployee);
                    int numberInRightBranch = LowestCommonLeader(directEmployees[1], firstEmployee, secondEmployee);

                    if(numberInLeftBranch == 1 && numberInRightBranch == 1)
                    {
                        lowestCommonLeader = searchedEmployee;
                        return 2;
                    }
                    if(numberInLeftBranch + numberInRightBranch == 2)
                    {
                        return 2;
                    }

                    return numberInLeftBranch + numberInRightBranch;
                default:
                    return -1;
            }
        }
    }
}
