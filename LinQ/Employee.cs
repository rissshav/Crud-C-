using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Employee
    {
        public int id;
        public string name;
        public string department;
        public string technology;
        public string company_name;

        public Employee(int ID, string Name, string Department, string Technology, string Comapny_name)
        {
            id = ID;
            name = Name;
            department = Department;
            technology = Technology;
            company_name = Comapny_name;
        }

    } 
}
