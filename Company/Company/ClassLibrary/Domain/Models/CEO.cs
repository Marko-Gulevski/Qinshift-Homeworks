using ClassLibrary.Domain.Enums;

namespace ClassLibrary.Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        public CEO(string firstName, string lastName, Employee[] employees, int shares, double sharesPrice) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Employees = employees;
            Shares = shares;
            SharesPrice = sharesPrice;
            Salary = GetSalary();
        }

        public double AddSharesPrice(double amount)
        {
            return SharesPrice = amount;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}
