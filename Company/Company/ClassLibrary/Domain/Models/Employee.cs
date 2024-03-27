using ClassLibrary.Domain.Enums;

namespace ClassLibrary.Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName)
        {
            Role = Role.Other;
            Salary = GetSalary();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"First Name: {FirstName}\nLast Name: {LastName}\nSalary: {GetSalary()}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}
