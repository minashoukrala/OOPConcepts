// See https://aka.ms/new-console-template for more information
using OOPConcepts;

void PrintPersonDetails(Person p)
{
    p.Display();
}

void Birthday(Person p)
{
    p.CelebrateBirthday();
}


Console.WriteLine("Hello, World!");

Student student = new Student("IDS","StudentName",3);

Professor professor = new Professor("IDP","ProfessorName",30);

Person person = new Person(13, "PersonName");

 

PrintPersonDetails(person);
Birthday(person);
person.DisplayRole();

Console.WriteLine();    

PrintPersonDetails(professor);
Birthday(professor);
professor.DisplayRole();
professor.Teach();

Console.WriteLine();

PrintPersonDetails(student);
Birthday(student);
student.DisplayRole();
student.Study();

Console.WriteLine();


