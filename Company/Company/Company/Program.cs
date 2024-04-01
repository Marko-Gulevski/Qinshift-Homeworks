using ClassLibrary.Domain.Enums;
using ClassLibrary.Domain.Models;

#region Task 01
Manager kylo = new Manager("Kylo", "Ren", 700);
Manager skye = new Manager("Skye", "Blue", 500);
Contractor joyce = new Contractor("Joyce", "Maxwell", 40, 150, kylo);
Contractor christian = new Contractor("Christian", "Cage", 40, 150, skye);
SalesPerson rob = new SalesPerson("Rob", "Nakasa");

Console.WriteLine(kylo.GetSalary());
Console.WriteLine(skye.GetSalary());
Console.WriteLine(joyce.GetSalary());
Console.WriteLine(christian.GetSalary());
Console.WriteLine(rob.GetSalary());
rob.AddSuccessRevenue(3000);
Console.WriteLine(rob.GetSalary());
joyce.CurrentPosition();
christian.CurrentPosition();


#endregion

#region Task 02

Employee[] company =
{
    kylo,
    skye,
    joyce,
    christian,
    rob

};

CEO ceo = new CEO("Big", "Boss", company, 4500, 6500);
ceo.PrintInfo();
ceo.PrintEmployees();
Console.WriteLine(ceo.GetSalary());
ceo.AddSharesPrice(8000);
Console.WriteLine(ceo.GetSalary());

#endregion