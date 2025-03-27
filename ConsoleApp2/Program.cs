namespace ConsoleApp2
{


    public class Student 
    {
        public static int idCounter { get; set; } = 1011;
        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
    
    
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            Id = idCounter++;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wellcome to github");
            Console.WriteLine("code changed");

            Student student1 = new Student("janidu", 24);
            Student student2 = new Student("ravindu", 26);

            Console.WriteLine($"student  name {student1.Name}");
            Console.WriteLine($"student age {student1.Age}");
            Console.WriteLine($"student ID {student1.Id }");

            Console.WriteLine($"student  name {student2.Name}");
            Console.WriteLine($"student age {student2.Age}");
            Console.WriteLine($"student ID {student2.Id}");
        }
    }
}
