using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class CEO : Employee
    {
        private double _sharesPrice;
        public Employee[] Company { get; set; }
        public int Shares { get; set; }
        public double SharesPrice
        {
            get => _sharesPrice;
            private set => _sharesPrice = value;
        }
        public CEO(string firstName, string lastName, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = Enums.RoleEnum.CEO;

            Company = new Employee[]
            {
                new Contractor("Bob", "Bobert", 8, 100, new Manager("Mona", "Monalisa", 2000)),
                new Contractor("Rick", "Rickert", 9, 90, new Manager("Igor", "Igorsky", 2500)),
                new Manager("Mona", "Monalisa", 2000),
                new Manager("Igor", "Igorsky", 2500),
                new SalesPerson("Lea", "Leova")
            };
        }

        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");

            foreach (Employee employee in Company)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}