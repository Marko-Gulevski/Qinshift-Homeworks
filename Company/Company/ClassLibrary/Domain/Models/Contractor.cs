using ClassLibrary.Domain.Enums;

namespace ClassLibrary.Domain.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }

        public int PayPerHour { get; set; }

        public Manager ResponsibleManager { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager managerResponsible) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            ResponsibleManager = managerResponsible;
            Salary = GetSalary();
        }

        public override double GetSalary()
        {
            return Salary = WorkHours * PayPerHour;
        }

        public void CurrentPosition()
        {
            Console.WriteLine($"{ResponsibleManager.FirstName} {ResponsibleManager.LastName}");
        }
    }
}
