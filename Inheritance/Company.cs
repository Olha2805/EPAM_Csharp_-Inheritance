using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceTask
{
    public class Company
    {
        private readonly Employee[] employees;
        public Company(Employee[] employee)
        {
            employees = employee;
        }
        public void GiveEverybodyBonus(decimal companyBonus)
        {
            for(int i = 0; i < employees.Length; i++)
            {
                employees[i].SetBonus(companyBonus);
            }
        }

        public decimal TotalToPay()
        {
            decimal total_salary = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                total_salary += employees[i].ToPay();
            }
            return total_salary;
        }

        public string NameMaxSalary()
        {
            string NameMaxSalary = employees[0].Name;
            decimal maxSalary = employees[0].ToPay();
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].ToPay() > maxSalary)
                {
                    maxSalary = employees[i].ToPay();
                    NameMaxSalary = employees[i].Name;
                }
            }
            return NameMaxSalary;
        }
    }
    
}
