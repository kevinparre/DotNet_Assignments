using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign3Q2
{
    abstract class Student
    {
        protected string name;
        protected int id;
       protected Double grade;

       


        abstract public bool Ispassed(Double grade);
    }
    class Undergraduate : Student

   
    {

        public Undergraduate(string name, int id, double grade)
        {
            this.name = name;
            this.id = id;
            this.grade = grade;

        }
        public override bool Ispassed(Double grade)
        {
            if (grade > 70)
            {
                return true;

            }
            else
                return false;
            
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int id, double grade)
        {
            this.name = name;
            this.id = id;
            this.grade = grade;

        }
        public override bool Ispassed(Double grade)
        {
            if (grade > 80)
            {
                
                return true;

            }
            else
                return false;
            
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            string name;
            int id;
            double grade;
            string type;

            Console.WriteLine("Enter the Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the ID:");
            id =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Enter the Grade:");
            grade =Convert.ToDouble( Console.ReadLine());

            Console.WriteLine("Enter the Class(Graduate/Undergraduate):");
            type = Convert.ToString(Console.ReadLine());
            
            if (type == "g")
            {
                Student student = new Graduate(name, id, grade);
                if (student.Ispassed(grade))
                {
                    Console.WriteLine("You Have Passed !!!");
                }
                else
                {
                    Console.WriteLine("Sorry! You have Failed.");

                }
            }
            else
            { 
                Student student2 = new Undergraduate(name, id, grade);
                if (Convert.ToBoolean(student2.Ispassed(grade)) == true)
                {
                    Console.WriteLine("You Have Passed !!!");
                }
                else
                {
                    Console.WriteLine("Sorry! You have Failed.");

                }
            }

            Console.ReadKey();
        }

    }
}
