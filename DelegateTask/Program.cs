using DelegateTask.Models;

namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            List<Person> people = new List<Person>()
           {
               new Person("Adil","Nasirli",18),
               new Person("Kamil","Nasirli",19),
               new Person("Adil","Kamilov",25),
               new Person("Suleyman","Aslanli",15),
               new Person("Leyla","Shafi",18),
           };

            //foreach (Person person in people.FindAll(p => p.Name == "Kamil"))
            //{
            //    Console.WriteLine(person);
            //}

            //foreach (Person person in people.FindAll(p => p.Surname.EndsWith("ova") || p.Surname.EndsWith("ov")))
            //{
            //    Console.WriteLine(person);
            //}

            //foreach (Person person in people.FindAll(p => p.Age >= 20))
            //{
            //    Console.WriteLine(person);
            //}




            //Task2

            List<Exam> exams = new List<Exam>();
            exams.Add(new Exam("Programming", 2));
            exams.Add(new Exam("Data Structure", 3));
            exams.Add(new Exam("Cloud Technology", 4));
            exams.Add(new Exam("General English", 1));

            foreach (Exam e in exams.FindAll(e => DateTime.Now.Subtract(e.StartDate).TotalDays <= 7))
            {
                Console.WriteLine(e);
            }

            foreach (Exam e in exams.FindAll(e => e.ExamDuration >= 2))
            {
                Console.WriteLine(e);
            }

            foreach (Exam e in exams.FindAll(e => e.EndDate > DateTime.Now))
            {
                Console.WriteLine(e);
            }
        }
    }
}