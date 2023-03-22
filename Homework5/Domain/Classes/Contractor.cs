using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Classes
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        public Contractor(string firstName, string lastName, int workHours, int payPerHour, Manager responsible)
        {
            FirstName = firstName;
            LastName = lastName;
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
            Role = RoleEnum.Contractor;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Department.ToString();
        }
    }
}