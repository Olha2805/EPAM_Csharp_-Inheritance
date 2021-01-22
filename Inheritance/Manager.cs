using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class Manager : Employee
    {
        private readonly int clientAmount;
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {
            Name = name;
            Salary = salary;
            this.clientAmount = clientAmount;
        }
        public override void SetBonus(decimal bonus)
        {
            if (clientAmount > 100 && clientAmount <= 150) this.bonus += 500;
            else if (clientAmount > 150) this.bonus += 1000;
            else this.bonus += 0;
        }
    }

}

