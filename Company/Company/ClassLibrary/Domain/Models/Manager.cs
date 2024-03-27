using ClassLibrary.Domain.Enums;

namespace ClassLibrary.Domain.Models
{
    public class Manager : Employee
    {
        private double Bonus { get; set; }
        public Manager(string firstName, string lastName, double bonus) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Manager;
            Bonus = AddBonus(bonus);
            Salary = GetSalary();
        }

        public double AddBonus(double bonus)
        {
            return bonus;
        }

        public override double GetSalary()
        {
            return Salary + Bonus;
        }
    }
}
