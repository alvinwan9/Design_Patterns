using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    abstract class Employee
    {
        private string name;
        private double income;
        private int vacationDays;
        private string dept;

        public string Name { get; set; }
        public double Income { get; set; }
        public int VacationDays { get; set; }
        public string Dept { get; set; }
        abstract public  void Accept(Visitor visitor);
    }

     class Engineer : Employee
    {
         public Engineer(string name,string dept, double income, int vacationDays)
         {
             Name = name;
             Dept = dept;
             Income = income;
             VacationDays = vacationDays;
         }

         public override void Accept(Visitor visitor)
         {
             visitor.Visit(this);
         }
    }
     class Saleman : Employee
     {
         public Saleman(string name, string dept, double income, int vacationDays)
         {
             Name = name;
             Dept = dept;
             Income = income;
             VacationDays = vacationDays;
         }

         public override void Accept(Visitor visitor)
         {
             visitor.Visit(this);
         }
     }
     class Economist : Employee
     {
         public Economist(string name, string dept, double income, int vacationDays)
         {
             Name = name;
             Dept = dept;
             Income = income;
             VacationDays = vacationDays;
         }

         public override void Accept(Visitor visitor)
         {
             visitor.Visit(this);
         }
     }

    class Employees
    {
         private ArrayList employees=new ArrayList();

        public void Attach(Employee employee)
        {
            employees.Add(employee);
        }

        public void Detach(Employee employee)
        {
            employees.Remove(employee);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Employee e in employees)
            {
                e.Accept(visitor);
            }
        }
    }
    abstract class Visitor
    {
        public abstract void Visit(Employee employee);
    }

     class IncomeVisitor : Visitor
    {
         public override void Visit(Employee employee)
         {
             employee.Income += 500.0;
             Console.WriteLine("{0}的{1}的新工资是{2:C}", employee.Dept, employee.Name, employee.Income);
         }
    }
     class VacationVisitor : Visitor
     {
         public override void Visit(Employee employee)
         {
             employee.VacationDays += 3;
             Console.WriteLine("{0}的{1}的新假期是{2}天",employee.Dept ,employee.Name,employee.VacationDays);
         }
     }
}
