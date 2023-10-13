using Microsoft.VisualBasic.FileIO;
using System.Linq;

namespace Lab8_GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create 5 Employee objects
            Employee emp1 = new Employee(1, "Adrian", 'M', 50000);
            Employee emp2 = new Employee(2, "Alex", 'M',50000);
            Employee emp3 = new Employee(3, "Amanda", 'F', 50000);
            Employee emp4 = new Employee(4, "Andreas", 'M', 50000);
            Employee emp5 = new Employee(5, "Ashfaqul", 'M', 50000);

            // PART 1 - STACK 

            // create a stack of Employees and fill it wih employees
            Stack<Employee> employeeStack = new Stack<Employee>();  
            employeeStack.Push(emp1);
            employeeStack.Push(emp2);
            employeeStack.Push(emp3);
            employeeStack.Push(emp4);
            employeeStack.Push(emp5);
            // !! to figure out:
            // is it possible to add employees in a loop like below
            // // this one doesnt work of course: how can I make a reference to the object names?
            // for (int i = 1; i <= 5; i++) { 
            //    employeeStack.Push("emp"+i);
            // }

            // print info about employees and amount of employees in the stack
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 1 Print info on all employees in the stack ");
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine($"There are {employeeStack.Count} employees in the stack.");
            foreach (Employee employee in employeeStack)
            {
                employee.PrintEmployeeInfo();
                Console.WriteLine($"{employeeStack.Count} employees still in the stack.");
            }
            
            // fetch employees one by one, print info on them and amount of employees left in the stack
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 2 Use Pop() on all objects and print info on them ");
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine($"There are {employeeStack.Count} employees in the stack.");
            int employeeCount = employeeStack.Count;
            for (int i = 0; i < employeeCount; i++)
            {
                Employee employeePoped = employeeStack.Pop();
                employeePoped.PrintEmployeeInfo();
                if (employeeStack.Count==0)
                {
                    Console.WriteLine("Oh no, you ran out of employees!!!!");
                }
                else 
                { 
                    Console.WriteLine($"{employeeStack.Count} employees still in the stack.");
                }
            }

            // push back employees to the stack
            employeeStack.Push(emp1);
            employeeStack.Push(emp2);
            employeeStack.Push(emp3);
            employeeStack.Push(emp4);
            employeeStack.Push(emp5);

            // use Peep to take a look at two employees, print their info and check the amount of employees left in the stack
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 3 Use Peep() on two objects ");
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine($"There are {employeeStack.Count} employees in the stack.");
            for (int i = 0; i < 2; i++)
            {
                Employee employeePeeked = employeeStack.Peek();
                employeePeeked.PrintEmployeeInfo();
                Console.WriteLine($"{employeeStack.Count} employees still in the stack.");
            }
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 3x Pops one employee to be able to use Peep() on two different objects ");
            Console.WriteLine(" ---------------------------------------- ");
            // we were supposed to fetch 2 objects with Peek but it always returns the one on top of the stack
            // ie it returns twice the same one
            // if the idea was to remove one employee to use Peek on another top object here it comes:
            Console.WriteLine($"There are {employeeStack.Count} employees in the stack."); 
            employeeStack.Peek().PrintEmployeeInfo();
            Console.WriteLine($"{employeeStack.Count} employees still in the stack.");
            employeeStack.Pop();
            employeeStack.Peek().PrintEmployeeInfo();
            Console.WriteLine($"{employeeStack.Count} employees still in the stack.");

            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine($" 4 Is emp3 in the stack? {employeeStack.Contains(emp3)}");
            // 1 it seems that the object has to exist to be able to check if it is in the stack
            // 2 it seems to be impossible to access a position of a stack e.g. employeeStack[2].Id
            Console.WriteLine(" ---------------------------------------- ");

            Console.WriteLine("DONE HERE? Press any key to see results generated by LIST ");
            Console.ReadKey();
            Console.Clear();

            // PART 2 - LIST

            // create a list of Employees and fill it wih employees
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            employeeList.Add(emp3);
            employeeList.Add(emp4);
            employeeList.Add(emp5);

            // use Contain to check if an object is in the list
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 1 Use Contains() to check if an object is in the list");
            Console.WriteLine(" ---------------------------------------- ");
            Console.Write($"Is emp4 in my list? ");
            if (employeeList.Contains(emp4))
            {
                Console.WriteLine("Employee4 object exists in the list");
            }
            else
            {
                Console.WriteLine("Employee4 object does not exist in the list");
            }
            Console.Write($"Is there an object at position 4 of my list? ");
            if (employeeList[3] == null) { 
                Console.WriteLine("Nope");
            }
            else
            {
                Console.WriteLine($"Yep, {employeeList[3].Id} {employeeList[3].Name}");
            }

            // find the first object with gender 'M'
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 2 Use Find() to find the first object with gender 'M'");
            Console.WriteLine(" ---------------------------------------- ");
            Employee firstMaleEmployee = employeeList.Find(Employee => Employee.Gender == 'M');
            Console.Write($"It must be... ");
            firstMaleEmployee.PrintEmployeeInfo();

            // find all the male objects
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" 3 Use FindAll() to find all the male objects ");
            Console.WriteLine(" ---------------------------------------- ");
            List<Employee> maleEmployees = new List<Employee>();
            maleEmployees = employeeList.FindAll(Employee => Employee.Gender == 'M');
            foreach (Employee male in maleEmployees)
            {
                Console.WriteLine($"{male.Id} {male.Name} is male");
            }


        }
    }
}