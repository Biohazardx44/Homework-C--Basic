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
        public CEO(string firstName, string lastName, int salary, Employee[] company)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Role = Enums.RoleEnum.CEO;
            Company = company;
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