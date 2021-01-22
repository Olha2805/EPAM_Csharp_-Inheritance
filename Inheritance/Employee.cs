using System;

namespace InheritanceTask
{
    public class Employee
    {
        private string name;
        private decimal salary;
        protected decimal bonus;
        private static decimal total_salary;

        public string Name {
            get { return name; }
            set { if (value != null) name = value; }
        } 

        public decimal TotalSalary { get { return salary; }
            set { if (value > 0) salary = value; } }

        public decimal Salary
        {
            get { return salary; }
            set { if (value > 0) { salary = value; } else { salary = 0; } }
        }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
            total_salary += salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            this.bonus = bonus;
        }

        public decimal ToPay()
        {
            decimal toPay = salary + bonus;
            return toPay;
        }
    }
}

