using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee xz = new Engineer("小张", "工业设计部", 3000.0, 10);
            Employee xw = new Engineer("小王", "工业设计部", 3100.0, 11);
            Employee xc = new Engineer("小张", "营销零售部", 2800.0, 5);
            Employee xl = new Engineer("小李", "营销零售部", 2900.0, 4);
            Employee xzh = new Engineer("小周", "财务管理部", 3200.0, 3);

            Employees employees=new Employees();
            employees.Attach(xz);
            employees.Attach(xw);
            employees.Attach(xc);
            employees.Attach(xl);
            employees.Attach(xzh);

            Visitor incomeVisitor=new IncomeVisitor();
            Visitor vacationVisitor=new VacationVisitor();

            employees.Accept(incomeVisitor);
            employees.Accept(vacationVisitor);

            Console.ReadKey();

        }
    }
}
