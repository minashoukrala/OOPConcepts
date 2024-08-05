namespace OOPConcepts{

    internal class Student : Person, UniversityMembers{

        private string studentID;

        public Student(){

            this.studentID = "";
            SetName("");
            SetAge(0);

        }

        public Student(string studentID, string name, int age){

            this.studentID = studentID;
            SetAge(age);
            SetName(name);

        }
        public Student(Student s)
        {

            this.studentID = s.studentID;
            SetAge(s.GetAge());
            SetName(s.GetName());

        }

        public override void Display(){
            
                Console.WriteLine("Student Name: " + GetName() + ", Age: " + GetAge() + ", StudentID: " + this.studentID);

        }

        public void Study(){
            
                Console.WriteLine("Name: " + GetName() + ", Age: " + GetAge() + ", StudentID: " + this.studentID + " Studying");

        }

        public void DisplayRole()
        {
            Console.WriteLine("Student Role");
        }



    }
}