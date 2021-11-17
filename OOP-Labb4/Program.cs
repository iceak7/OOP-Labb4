using System;
using System.Collections.Generic;

namespace OOP_Labb4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { ID = 1, Gender = "Male", Name = "Isak", Salary = 30000 };
            Employee e2 = new Employee { ID = 2, Gender = "Female", Name = "Johanna", Salary = 25000 };
            Employee e3 = new Employee { ID = 3, Gender = "Male", Name = "Anders", Salary = 22000 };
            Employee e4 = new Employee { ID = 4, Gender = "Male", Name = "Lasse", Salary = 35000 };
            Employee e5 = new Employee { ID = 5, Gender = "Male", Name = "Tomas", Salary = 40000 };


            Stack<Employee> stack1 = new Stack<Employee>();
            stack1.Push(e1);
            stack1.Push(e2);
            stack1.Push(e3);
            stack1.Push(e4);
            stack1.Push(e5);

            foreach (Employee e in stack1)
            {            
                Console.WriteLine($"{e.ID} - {e.Name} - {e.Gender} - {e.Salary}");
                Console.WriteLine("Items left in stack = " + stack1.Count);
            }

            Console.WriteLine("\n-----------------------------------------\n");
            Console.WriteLine("Using pop");


            while(stack1.Count>0)
            {
                Employee removed = stack1.Pop();
                Console.WriteLine($"{removed.ID} - {removed.Name} - {removed.Gender} - {removed.Salary}");
                Console.WriteLine("Items left in stack = " + stack1.Count);
            }   


            Console.WriteLine("\n-----------------------------------------\n");

            stack1.Push(e1);
            stack1.Push(e2);
            stack1.Push(e3);
            stack1.Push(e4);
            stack1.Push(e5);

            Console.WriteLine("Using peek");
            Employee first = stack1.Peek();
            Console.WriteLine($"{first.ID} - {first.Name} - {first.Gender} - {first.Salary}");
            Console.WriteLine("Items left in stack = " + stack1.Count);

            first = stack1.Peek();
            Console.WriteLine($"{first.ID} - {first.Name} - {first.Gender} - {first.Salary}");
            Console.WriteLine("Items left in stack = " + stack1.Count);

            Console.WriteLine("\n-----------------------------------------\n");

            if (stack1.Contains(e3))
            {
                Console.WriteLine("Emp3 is in stack");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack");
            }



            Console.WriteLine("\n------------------List-----------------------\n");
            List<Employee> employees = new List<Employee> { e1, e2, e3, e4, e5 };

            if (employees.Contains(e2))
            {
                Console.WriteLine("Employee 2 object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee 2 object does not exist in the list.");
            }
            Console.WriteLine("\n-----------------------------------------\n");

            Employee firstMale = employees.Find(x => x.Gender == "Male");
            Console.WriteLine(firstMale.Name + " is the first male in the list.");

            Console.WriteLine("\n-----------------------------------------\n");

            List<Employee> males = employees.FindAll(x => x.Gender == "Male");
            Console.WriteLine("All males in the list:");
            foreach (Employee male in males)
            {
                Console.WriteLine($"{male.ID} - {male.Name} - {male.Salary}");
            }


        }
    }
}
