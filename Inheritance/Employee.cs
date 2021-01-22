using System;

namespace InheritanceTask
{
    public class Employee
    {
        private string name;
        private decimal salary;
        private decimal bonus;
        public static decimal total_salary;

        public string Name
        {
            get => name;
            set { if (name != null) this.name = name; else this.name = "mane"; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { if (value > 0) this.salary = value; else this.salary = 0; }
        }

        public Employee(string name, decimal salary)
        {
            this.name = name;
            this.salary = salary;
            total_salary += salary;
        }

        public virtual void SetBonus(decimal bonus)
        {
            if (bonus > 0) this.bonus = bonus;
            else this.bonus = 0;
        }

        public decimal ToPay()
        {
            decimal totalToPay = salary + bonus;
            return totalToPay;
        }

    }
    }

