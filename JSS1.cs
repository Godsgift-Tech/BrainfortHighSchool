using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainfortHighSchool
{
    internal class JSS1 : School
    {
        public string TutorName;
        public string StudentName;
        public string SubjectName;
        public string ClassName;
        public void Teach()
        {
            Console.WriteLine("TEACHING IS CURRENTLY ON IN OUR JSS1 CLASS!!!!");
            Console.WriteLine("");
            List<JSS1> student = new List<JSS1>();
            {
                student.Add(new JSS1 { TutorName = "Mr. Lucky", StudentName = "Mary", SubjectName = "English", ClassName = "JSS1 Class" });
                student.Add(new JSS1 { TutorName = "Mr. Justice", StudentName = "Jenifa", SubjectName = "Biology", ClassName = "JSS1 Class" });
                student.Add(new JSS1 { TutorName = "Ms. Jeff", StudentName = "Emmanuella", SubjectName = "Literature", ClassName = "JSS1 Class" });
                student.Add(new JSS1 { TutorName = "Mr. Daniel", StudentName = "David", SubjectName = "Geography", ClassName = "JSS1 Class" });


            }
            student.ForEach(student => Console.WriteLine($"{student.TutorName} teaches {student.StudentName} {student.SubjectName} in {student.ClassName}"));
            Console.WriteLine("");
            Console.WriteLine("LIST OF JSS1 TUTOR NAMES ARE: ");
            student.ForEach(student => Console.WriteLine($"{student.TutorName}"));
            Console.WriteLine("");
            Console.WriteLine("LIST OF STUDENTS IN JSS1 CLASS ARE: ");
            student.ForEach(student => Console.WriteLine($"{student.StudentName}"));
            Console.WriteLine("");




        }
        public void Asignment()
        {
            Console.WriteLine("There is no asignment in JSS1 class this week!");
            Console.WriteLine("");
        }
    }
}
