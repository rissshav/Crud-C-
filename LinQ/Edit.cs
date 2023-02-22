using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Edit
    {
        List<Employee> edit = new List<Employee>();
        public Edit(List<Employee> edit)
        {
            this.edit = edit;
        }

        public List<Employee> Edituser()
        {
            Viewemployee print = new Viewemployee(edit);
            bool loopflag = true;
            print.AllEmployee();
            while (loopflag)
            {
                Console.WriteLine("Enter ID of Employee you want to edit details");
                int ID = int.Parse(Console.ReadLine());
                bool idflag = false;
                foreach (Employee e in edit)
                {
                    if (e.id == ID)
                    {
                        idflag= true;
                        loopflag= false;
                        Console.WriteLine("Update details of ID {0}",ID);

                        Console.WriteLine("Update the Name");
                        e.name = Console.ReadLine();

                        Console.WriteLine("Update the Department");
                        e.department = Console.ReadLine();

                        Console.WriteLine("update the Technology");
                        e.technology = Console.ReadLine();

                        Console.WriteLine("Update the company");
                        e.company_name = Console.ReadLine();

                    }

                }
                if (idflag == false)
                {
                    Console.WriteLine("\nEmployee Not Found!\n");
                    Console.WriteLine("\nTry Again!!\n");
                }
            }
            Console.WriteLine("Updated Successfully");
            return this.edit;
        }
    }
}
