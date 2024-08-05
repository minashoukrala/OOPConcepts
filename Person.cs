namespace OOPConcepts{

    internal class Person : UniversityMembers
    {

        private int age;
        private string name;

        public  Person(){

            this.age = 0;
            this.name = "";

        }

        public  Person(int age, string name){

            this.age=age;
            this.name=name;

        }
        public Person(Person p)
        {

            this.age = p.age;
            this.name = p.name;

        }

        public virtual void Display(){
            
                Console.WriteLine("Name: " + name + ", Age: " + age);

        }

        public  void CelebrateBirthday(){

            this.age+=1;

            Console.WriteLine("Happy Birthday " + "Name: " + name + ", Age: " + age);

        }

        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void DisplayRole()
        {
            Console.WriteLine("Person Role");
        }


    }
}