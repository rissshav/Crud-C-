using LinQ;
using System.Collections;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee obj = new Employee(1, "Aman", "CSE", "MVC", "AspireFox");
        Employee obj1 = new Employee(2, "Aman", "CSE", "MVC", "AspireFox");
        //Employee obj2 = new Employee(3, "Aman", "CSE", "MVC", "AspireFox");
        //Employee obj3 = new Employee(4, "Aman", "CSE", "MVC", "AspireFox");
        //Employee obj4 = new Employee(5, "Aman", "CSE", "MVC", "AspireFox");

        List<Employee> employees = new List<Employee>();
        employees.Add(obj);
        employees.Add(obj1);
        //employees.Add(obj2);
        //employees.Add(obj3);
        //employees.Add(obj4);

        //Console.WriteLine("Employee Details :");
        //Console.WriteLine();
        //Console.WriteLine("ID Name Department Technology Company_name");

        //foreach (Employee<int, string> item in employees)
        //{
        //    //Console.Write(item.id);
        //    //Console.Write(" " + item.name);
        //    //Console.Write(" " + item.department);
        //    //Console.Write(" " + item.technology);
        //    //Console.Write(" " + item.company_name);
        //    //Console.WriteLine(item.id + " " + item.name + " " + item.department + " " + item.technology + " " + item.company_name);
        //    Console.WriteLine("{0} {1} {2} {3} {4}", item.id,item.name, item.department,item.technology, item.company_name);
        //}
        //List<Employee> employees = new List<Employee>();
        Add addnew = new Add();
        Delete deleteEmp = new Delete(employees);




        bool exit = true;
        while (exit)
        {
            Console.WriteLine("\nC# Assignment\n");
            Console.WriteLine("Select the Below Options");
            Console.WriteLine("1 View Employee");
            Console.WriteLine("2 Add Employee");
            Console.WriteLine("3 Edit Employee");
            Console.WriteLine("4 Delete Employee");
            Console.WriteLine("5 Exit\n");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("View Employee");
                    Console.WriteLine("    ");
                    Viewemployee allemp = new Viewemployee(employees);
                    allemp.AllEmployee();
                    break;
                case "2":
                    Console.WriteLine("Add Employee");
                    var emp = addnew.AddNew();
                    employees.Add(emp);
                    break;
                case "3":
                    Console.WriteLine("Edit Employee");
                    Edit editemp= new Edit(employees);
                    editemp.Edituser();
                    break;
                case "4":
                    Console.WriteLine("Delete Employee");
                    deleteEmp.DeleteEmp();
                    break;
                case "5":
                    Console.WriteLine("Exit");
                    exit = false;
                    break;
                default:
                    Console.WriteLine("Please select the valid option");
                    break;
            }
        }
    }
}