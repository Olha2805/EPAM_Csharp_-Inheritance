using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTask
{
    public class SalesPerson : Employee
    {
        private int percent;
        public SalesPerson(string name, decimal salary, int percent) : base(name, salary)
        {
                 this.percent = percent;
        }
        public virtual void SetBonus(decimal bonus, int percent)
        {
            if (bonus > 0)
            {
                if (percent > 100 && percent <= 200) bonus *= 2;
                else if (percent > 200) bonus *= 3;
            }
            else bonus = 0;
        }

    }

}
