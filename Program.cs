using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Mohamed", "Ahmed", "20", 20);
            s.setCourse(1, "nf445");
            s.setCourse(2, "n445");
            s.setCourse(3, "nf445");
            s.setCourse(1, "nf445");
            s.setCourse(1, "nf445");
            s.setCourse(1, "nf445");
            s.setCourse(1, "nf445");
            Console.WriteLine(s.getTimeTable());
        }
    }
    public class Student
    {
        string firstName;
        string lastName;
        string studentNumber;
        int grade;
        string[] timeTable;
        public Student(string firstName , string lastName, string studentNumber, int grade )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.grade = grade;
            timeTable = new string[8];
        }
        public void setFirstName(string NewFirstName)
        {
            this.firstName = NewFirstName;
        }
        public void setLastName(string NewLastName)
        {
            this.lastName = NewLastName;

        }
        public string getLastNaME()
        {
            return lastName;
        }
        public void setTheGrade(int newGrade)
        {
            this.grade = newGrade;
        }
        public int getNewGrade()
        {
            return this.grade;
        }
        public void setCourse(int block,string courseCode)
        {
            timeTable[block - 1] = courseCode;
        }
        public string getCourse(int block)
        {
            if (timeTable[block - 1] == null)
            {
                return "No course Is schduel";
            }
            else
            {
                return this.timeTable[block - 1];
            }

        }
        public string getFullName()
        {
            string Result = firstName + " " + lastName;
            return Result;
        }
        public string getTimeTable()
        {
            string result = "Time table============\n";
            for (int i = 0; i < timeTable.Length; i++)
            {
               result=result + "\n"+(i+1)+":"+getCourse(i+1);
            }
            return result;
        }
    }
}
