using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Q2
{
    class Student
    {
        int rollno;
        string name;
        int std;
        string sem;
        string branch;
        int[] marks;
        bool flag = true;

        public Student(int rollno, string name, int std, string sem, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.std = std;
            this.sem = sem;
            this.branch = branch;



        }


        public void insertMarks()
        {
            
            marks = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter marks for subject {0} :", i + 1);
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void displayResult()
        {
            Console.WriteLine("Marks for the all subjects:");
            
            int sum = 0;
            foreach (int i in marks)
            {
                
                if (i > 35)
                {
                    total += j;
                }
                else
                {
                    flag = false;
                    total += j;
                }
            }
            Console.WriteLine("Total Marks: {0}", sum);
            if (flag == false)
            {
                Console.WriteLine("Fail: 35 or less marks scored in one or more subjects." );
            }
            else if (total / subjectCount < 50)
            {
                Console.WriteLine("Fail:Low Average: {0}", total / subjectCount);
            }
            else
            {
                Console.WriteLine("Passed!!!: Average: {0}%", total / subjectCount);
            }
        }

        public void displayDetails()
        {

            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Roll No: {0}", rollno);
            Console.WriteLine("Branch: {0}", branch);
            Console.WriteLine("Sem: {0}", sem);
            Console.WriteLine("Batch: {0}", std);

            displayResult()



        }
    class Program
    {
        static void Main(string[] args)
        {
                int rollNo;
                string name;
                int sem;
                string batch;
                string branch;
                int subjectCount;
                Console.WriteLine("Enetr student name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter roll no: ");
                rollNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Branch name");
                branch = Console.ReadLine();
                Console.WriteLine("Enter Sem No: ");
                sem = int.Parse(Console.ReadLine());
                Console.WriteLine("Enetr Batch/ Division: ");
                batch = Console.ReadLine();
                Console.WriteLine("Enter total subject count: ");
                subjectCount = int.Parse(Console.ReadLine());

                Student student = new Student(rollNo, name, std, sem, branch);
                student.insertMarks();
                int ch;
                do
                {
                    
                    Console.WriteLine("Select your choice:\n1. Display Result \n2. Display all details with result \n3. Exit");
                    ch = int.Parse(Console.ReadLine());
                    
                    switch (ch)
                    {
                        case 1:
                            mm.displayResult();
                            break;
                        case 2:
                            mm.displayDetails();
                            break;
                        case 3:
                            Console.WriteLine("Bye...!");
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            break;
                    }


                } while (ch != 3);






            }
        }
    }
    
}
