using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3q1
{
     public class Employee
    {
        int empid;
        string empname;
        string address;
        string city;
        string dept;
        double salary=10000;

        public virtual double GetSalary()
        {
            return salary;

        }

    }



    class ContractEmployee : Employee
    {
        double perks;
        public override double GetSalary()
        {
            Console.WriteLine("Enter Perks:");
            perks = Convert.ToDouble(Console.ReadLine());
            return base.GetSalary() + perks;
        }

    }
    class PermanentEmployee : Employee
    {
        int leaves;
        double PFfund;

        public override double GetSalary()
        {
            Console.WriteLine("Enter Provident Fund:");
            PFfund = Convert.ToDouble(Console.ReadLine()); 

            return base.GetSalary() - PFfund;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string address;
            string city;
            string dept;
            int type;
            double finalsal;

            Employee emp = new Employee();

            Console.WriteLine("Console based Application");
            Console.WriteLine("Salary Calculation ");
            Console.WriteLine("Enter you Employee's Name:");
            name = Console.ReadLine();

            Console.WriteLine("Enter Employee's ID");
            id = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Enter Employee's Address:");
            address = Console.ReadLine();

            Console.WriteLine("Enter Employee's City:");
            city= Console.ReadLine();

            Console.WriteLine("Enter Employee's Department:");
            dept = Console.ReadLine();

            Console.WriteLine("Enter Employee Type:1)Contract Employee  2)Permanent Employee:");
            type =Convert.ToInt32( Console.ReadLine());

            if(type == 1)
            {
                emp = new ContractEmployee();
                finalsal= emp.GetSalary();
                Console.WriteLine("Total Salary :{0}",finalsal);
            }
            else
            {
                emp = new PermanentEmployee();
                finalsal = emp.GetSalary();
                Console.WriteLine("Total Salary :{0}", finalsal);
            }


            Console.ReadKey();
        }
    }
}
