namespace BrainfortHighSchool
{
    class Program
    {
        public static void Main(string[] args)
        {

            List<Student> studentlist = new List<Student>();
            {
                studentlist.Add(new Student() { Name = "Davido", Id = "10B", Age = 15, Grade = "A" });
                studentlist.Add(new Student() { Name = "Ellato", Id = "16D", Age = 11, Grade = "B" });
                studentlist.Add(new Student() { Name = "Kamsin", Id = "12K", Age = 13, Grade = "A" });
                studentlist.Add(new Student() { Name = "Kendra", Id = "1TN", Age = 12, Grade = "B" });
                studentlist.Add(new Student() { Name = "Esther", Id = "01V", Age = 14, Grade = "C" });
                studentlist.Add(new Student() { Name = "Andrew", Id = "06J", Age = 16, Grade = "C" });
                studentlist.Add(new Student() { Name = "Bright", Id = "2ED", Age = 11, Grade = "A" });
                studentlist.Add(new Student() { Name = "Vivian", Id = "1T7", Age = 17, Grade = "C" });
                studentlist.Add(new Student() { Name = "Jovani", Id = "8UY", Age = 10, Grade = "A" });
                studentlist.Add(new Student() { Name = "Divine", Id = "26I", Age = 11, Grade = "B" });

            }
            // Printing out the student details in Eliada School.
            Console.WriteLine("The studentlist with their full details in Brainforte High School:");
            // Using lambda expression to print out student's details
            studentlist.ForEach(student => Console.WriteLine($"Name: {student.Name}, Id:{student.Id},  Age: {student.Age},  Grade: {student.Grade}"));
            //Using lambda expression to print out only the names of learners in Eliada School
            Console.WriteLine("The names of all the students in Brainforte High School are:");
            studentlist.ForEach(student => Console.WriteLine(student.Name));
            //Statement for printing studentlist of learners above 12 years
            Console.WriteLine("The details all the learners above 12 years old in Brainforte High School are:");
            //Using lambda expression to print out only the Name, Id and Age of students > 12 years
            studentlist.Where(student => student.Age > 12).ToList().ForEach(student => Console.WriteLine($"Name: {student.Name},  Id:{student.Id},  Age: {student.Age}"));
            Console.ReadKey();

        }
    }

}
 