using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Professor : Person, UniversityMembers
    {
        private string employeeID;

        public Professor()
        {
            this.employeeID = "";
            SetAge(0);
            SetName("");
        }

        public Professor(string employeeID, string name, int age)
        {

            SetName(name);
            SetAge(age);
            this.employeeID = employeeID;
        }

        public Professor(Professor p)
        {
            SetName(p.GetName());
            SetAge(p.GetAge());
            this.employeeID = p.employeeID;
        }

        public override void Display()
        {

            Console.WriteLine("Prof Name: " + GetName() + ", Age: " + GetAge() + ", ProfessorID: " + this.employeeID);

        }

        public void Teach()
        {

            Console.WriteLine("Name: " + GetName() + ", Age: " + GetAge() + ", ProfessorID: " + this.employeeID + " Teaching");

        }

        public void DisplayRole()
        {
            Console.WriteLine("Professor Role");
        }


    }
}
