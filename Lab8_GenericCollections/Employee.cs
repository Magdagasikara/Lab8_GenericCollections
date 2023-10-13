using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_GenericCollections
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Salary{ get; set; }

        public Employee(int  id, string name, char gender, int salary) 
        { 
            Id= id;
            Name= name; 
            Gender= gender;
            Salary= salary;
        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Employee id: {Id}\tName: {Name}\tGender: {Gender}\tSalary: {Salary}");
        }
    }
}
