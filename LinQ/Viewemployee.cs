using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    internal class Viewemployee
    {
        List<Employee> empList = new List<Employee>();
        public Viewemployee(List<Employee> empList)
        {
            this.empList = empList;
        }
        public void AllEmployee()
        {
            Console.WriteLine(" ID    Name         Department       technology        company name     \n");
            foreach (Employee emp in empList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", emp.id, emp.name, emp.department, emp.technology, emp.company_name);
            }
        }
    }
}
