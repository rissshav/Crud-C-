using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class Add
    {
        public static string department()
        {
            Console.WriteLine("Select your department");
            Console.WriteLine("1. HR\n2. Manager\n3. Development\n4. Team Lead");
            string x = Console.ReadLine();
            string select = "";
                switch (x)
                {
                    case "1":
                        Console.WriteLine("You have selected HR");
                        select = "HR";
                        return select;
                    case "2":
                        Console.WriteLine("You have selected Manager");
                        select = "Manager";
                        return select;
                    case "3":
                        Console.WriteLine("You have selected Development");
                        select = "Development";
                        return select;
                    case "4":
                        Console.WriteLine("You have selected Team lead");
                        select = "Team Lead";
                        return select;
                    default:
                        Console.WriteLine("Please Select valid option");
                        break;
                }
           
            return select;

        }

        public static string Technology()
        {
            Console.WriteLine("Select your Technology");
            Console.WriteLine("1. C#\n2. MVC\n3. .NET");
            string x = Console.ReadLine();
            string select = "";
            switch (x)
            {
                case "1":
                    Console.WriteLine("You have selected C#");
                    select = "C#";
                    return select;
                case "2":
                    Console.WriteLine("You have selected MVC");
                    select = "MVC";
                    return select;
                case "3":
                    Console.WriteLine("You have selected .NET");
                    select = ".NET";
                    return select;
                default:
                    Console.WriteLine("Please select valid option");
                    break;
            }
            return select;
        }

        public int id = 2;
        public Employee AddNew()
        {
            validation validate= new validation();

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            name = validate.checkName(name);

            Console.WriteLine("Enter your Department");
            bool deptflag = true;
            string dept = "";
            while (deptflag)
            {
                dept = Add.department();
                if (dept != "")
                {
                    deptflag= false;
                }
            }
            

            Console.WriteLine("Enter your Technology");
            string tech = "";
            bool techflag = true;
            while (techflag)
            {
                tech = Add.Technology();
                if(tech != "")
                {
                    techflag= false;
                }
            }

            Console.WriteLine("Enter your Company name");
            bool compflag = true;
            string cmpname = "";
            while (compflag)
            {
                cmpname = Console.ReadLine();
                if (cmpname != "")
                {
                    compflag= false;
                }
                else
                { Console.WriteLine("Please Enter your company name"); }
            }
            

            Console.WriteLine("Employee Added Succesfully");
            id += 1;

            Employee emp = new Employee(id, name, dept, tech, cmpname);
            return emp;
        }
    }
}
