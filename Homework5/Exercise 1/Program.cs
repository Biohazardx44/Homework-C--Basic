using Domain.Classes;
using Domain.Enums;

Employee employee = new Employee()
{
    FirstName = "Ed",
    LastName = "Sheeran",
    Role = RoleEnum.Manager
};
Console.WriteLine(employee.GetInfo());

int enumToInt = (int)employee.Role;
Console.WriteLine(enumToInt);

SalesPerson salesPerson = new SalesPerson("Zara", "Larsson");
salesPerson.AddSuccessRevenue(400);
Console.WriteLine(salesPerson.GetSalary());

Manager manager = new Manager("Tom", "Cruise", 1200);
Console.WriteLine(manager.GetSalary());
manager.AddBonus(250);
Console.WriteLine(manager.GetSalary());
Console.WriteLine("=====================================");
Manager newManager = new Manager("Johny", "Bravo", 2000);
Manager mainManager = new Manager("Bill", "Gate", 10000);
newManager.Department = "First Department";
mainManager.Department = "Main Department";
Contractor contractor = new Contractor("Bob", "Halt", 20, 100, newManager);
Contractor mainContractor = new Contractor("Jimmy", "Hilton", 15, 500, mainManager);

Console.WriteLine($"The manager that is responsible for {contractor.FirstName} {contractor.LastName} is in the {contractor.CurrentPosition()}.");
Console.WriteLine($"The manager that is responsible for {mainContractor.FirstName} {mainContractor.LastName} is in the {mainContractor.CurrentPosition()}.");
Console.WriteLine("=====================================");
CEO mainCEO = new CEO("Ron", "Ronsky", 1500) { Shares = 8 };

mainCEO.AddSharesPrice(175);
Console.WriteLine("CEO:");
Console.WriteLine($"First Name: {mainCEO.FirstName}, Last Name: {mainCEO.LastName}, Salary: {mainCEO.Salary}");
Console.WriteLine($"Salary of CEO is: {mainCEO.GetSalary()}");
mainCEO.PrintEmployees();
Console.WriteLine("=====================================");