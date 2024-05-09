using System.Threading.Channels;

namespace BrainfortHighSchool
{
    class Program
    {
        public static void Main(string[] args)
        {
            School school = new School();
            JSS1 student = new JSS1();
            school.Learning(student);
            student.Teach();   // calls the method teach in JSS1 Class
            student.Assignment(); // call out for the asignment in JSS1 Class
            JSS2 jSS2Class = new JSS2();
            jSS2Class.Teach();         // calls the method teach in JSS1 Class
            jSS2Class.Assignment();      // call out for the asignment in JSS1 Class
            Console.ReadKey();   

        }

    }
}


