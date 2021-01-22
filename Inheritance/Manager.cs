using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class Manager : Employee
    {
        private int quantity;
        public Manager(string name, decimal salary, int clientAmount) : base(name, salary)
        {

        }
        public void SetBonus(decimal bonus, int clientAmount)   // public override virtual SetBonus(decimal bonus, int clientAmount)
        {
            quantity += clientAmount;
            if (clientAmount > 100 && clientAmount <= 150) bonus += 500;
            else if (clientAmount > 150) bonus += 1000;
            else bonus += 0;
        }
    }

}

