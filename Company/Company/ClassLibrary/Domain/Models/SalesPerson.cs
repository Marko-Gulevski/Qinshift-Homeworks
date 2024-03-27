using ClassLibrary.Domain.Enums;
namespace ClassLibrary.Domain.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue { get; set; }
        public SalesPerson(string firstName, string lastName) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }

        public double AddSuccessRevenue(double successSaleRevenue)
        {
            return SuccessSaleRevenue = successSaleRevenue;
        }

        public override double GetSalary()
        {
            double salary = 0;
            if (SuccessSaleRevenue <= 2000)
            {
                salary = Salary + 500;
            }
            else if (SuccessSaleRevenue > 2000 && SuccessSaleRevenue <= 5000)
            {
                salary = Salary + 1000;
            }
            else
            {
                salary = Salary + 1500;
            }
            return salary;
        }
    }
}
