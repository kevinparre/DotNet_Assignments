using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2Q2
{

    public class Student
    {
        int rollNo;
        string name;
        int sem;
        string std;
        string branch;
        int[] marks;
        bool flag=true;
        
        public Student(int rollNo, string name, int sem, string branch, string std)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.sem = sem;
            this.branch = branch;
            this.std = std;
        }
        public void insertMarks()
        {
            
            marks = new int[5];
            for(int i=0; i < 5; i++)
            {
                Console.WriteLine("Enetr marks for subject {0} :",i+1);
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void displayResult()
        {
            Console.WriteLine("Marks for the all subjects:");
            Console.WriteLine();
            int total=0;
            foreach(int i in marks)
            {
                Console.Write(i + ", ");
                if (i > 35)
                {
                    total += i;
                }
                else
                {
                    flag = false;
                    total += i;
                }
            }
            Console.WriteLine("Total Marks: {0}",total);
            if (flag == false)
            {
                Console.WriteLine("Failed!");
            }
            else if (total/5 < 50)
            {
                Console.WriteLine("Failed!Average too low: {0}",total/5);
            }
            else{
                Console.WriteLine("Passede: {0}%",total/5);
            }
        }

        public void displayDetails()
        {
            
            Console.WriteLine("Student Name: {0}",name);
            Console.WriteLine("Roll No: {0}",rollNo);
            Console.WriteLine("Class/ Branch: {0}",branch);
            Console.WriteLine("Sem: {0}",sem);
            Console.WriteLine("STD: {0}", std);

            displayResult();
           
        }

    }
    class StudentResult
    {
        public static void Main()
        {
            int rollNo;
            string name;
            int sem;
            string std;
            string branch;
            
            Console.WriteLine("Enter student's Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter roll no: ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Branch name");
            branch = Console.ReadLine();
            Console.WriteLine("Enter Sem No: ");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter STD: ");
            std = Console.ReadLine();
           

            Student student = new Student(rollNo, name, sem,branch,std);
            student.insertMarks();
            int ch;
            do
            {
                
                Console.WriteLine("Select your choice:\n1. Display Result \n2. Display all details with result \n3. Exit");
                ch = int.Parse(Console.ReadLine());
                
                switch (ch)
                {
                    case 1:
                        student.displayResult();
                        break;
                    case 2:
                       student.displayDetails();
                        break;
                    case 3:
                        Console.WriteLine(" ");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
               

            } while (ch != 3);






        }
    }
}
