using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainfortHighSchool
{
    internal class JSS2 : School
    {
        public string TutorName;
        public string StudentName;
        public string SubjectName;
        public string ClassName;
        public void Teach()
        {
            Console.WriteLine("TEACHING IS CURRENTLY ON IN OUR JSS2 CLASS");
            List<JSS2> pupil = new List<JSS2>();
            {
                pupil.Add(new JSS2 { TutorName = "Mr. Godsgift", StudentName = "Michael", SubjectName = "Mathematics", ClassName = "JSS2 Class" });
                pupil.Add(new JSS2 { TutorName = "Mr.  Okome", StudentName = "Jenifa", SubjectName = "Creative Arts", ClassName = "JSS2 Class" });
                pupil.Add(new JSS2 { TutorName = "Ms. Jeff", StudentName = "Emmanuella", SubjectName = "Englih", ClassName = "JSS2 Class" });
                pupil.Add(new JSS2 { TutorName = "Mr. Daniel", StudentName = "David", SubjectName = "Basic Science", ClassName = "JSS2 Class" });
            }
            pupil.ForEach(pupil => Console.WriteLine($"{pupil.TutorName} teaches {pupil.StudentName} {pupil.SubjectName} in {pupil.ClassName}"));
            Console.WriteLine("LIST OF JSS2 TUTOR NAMES ARE");
            pupil.ForEach(pupil => Console.WriteLine($"{pupil.TutorName}"));
            Console.WriteLine("LIST OF STUDENTS IN JSS2 CLASS ARE");
            pupil.ForEach(pupil => Console.WriteLine($"{pupil.StudentName}"));
        }
        public void Assignment()
        {
            Console.WriteLine("There is no asignment in JSS2 class this week!");
        }
    }
}
