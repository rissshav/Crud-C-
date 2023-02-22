using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Delete
    {
        List<Employee> delEmp = new List<Employee>();

        public Delete(List<Employee> delEmp)
        {
            this.delEmp = delEmp;
        }

        public List<Employee> DeleteEmp()
        {
            if (delEmp.Count == 0)
            {
                Console.WriteLine("\nThe list is already empty\n");
                //Console.WriteLine("Press Enter to return to Main menu");
                //Console.ReadLine();
                return delEmp;
            }
            bool loopFlag = true;
            while (loopFlag)
            {
                Viewemployee print = new Viewemployee(delEmp);
                print.AllEmployee();
                Console.WriteLine("\nEnter the Employee Id to delete.\n");
                int ID = int.Parse(Console.ReadLine());

                bool idFlag = false;
                foreach (var item in delEmp)
                {
                    if (item.id == ID)
                    {
                        idFlag = true;
                        loopFlag = false;
                        delEmp.RemoveAt(ID-1);
                        Console.WriteLine("\nDeleted\n");
                        break;
                    }
                }
                if (idFlag == false)
                {
                    Console.WriteLine("\nEmployee Not Found!\n");
                    Console.WriteLine("\nTry Again!!\n");
                }

            }

            return delEmp;
        }
    }
}
