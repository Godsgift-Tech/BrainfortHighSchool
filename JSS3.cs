using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainfortHighSchool
{
    internal class JSS3 : JSS2
    {

        public override void Teach()
        {
            Console.WriteLine("TEACHING IS CURRENTLY ON IN OUR JSS3 CLASS!!!!");
            Console.WriteLine("");
            List<JSS3> folks = new List<JSS3>();
            {
                folks.Add(new JSS3 { TutorName = "Mr. Charles", StudentName = "Isabella", SubjectName = "Mathematics", ClassName = "JSS3 Class" });
                folks.Add(new JSS3 { TutorName = "Mr.  Okome", StudentName = "Maya", SubjectName = "Creative Arts", ClassName = "JSS3 Class" });
                folks.Add(new JSS3 { TutorName = "Ms. Samuel", StudentName = "Akintola", SubjectName = "Englih", ClassName = "JSS3 Class" });
                folks.Add(new JSS3 { TutorName = "Mr. Emmanuel", StudentName = "Solomon", SubjectName = "Basic Technology", ClassName = "JSS3 Class" });
            }
            folks.ForEach(folks => Console.WriteLine($"{folks.TutorName} teaches {folks.StudentName} {folks.SubjectName} in {folks.ClassName}"));
            Console.WriteLine("");
            Console.WriteLine("LIST OF JSS3 TUTOR NAMES ARE: ");
            folks.ForEach(folks => Console.WriteLine($"{folks.TutorName}"));
            Console.WriteLine("");
            Console.WriteLine("LIST OF STUDENTS IN JSS3 CLASS ARE: ");
            folks.ForEach(folks => Console.WriteLine($"{folks.StudentName}"));
            Console.WriteLine("");
        }
        public override void Asignment()
        {
            Console.WriteLine("BASIC TECHNOLOGY ASIGNMENT!!!!");
            Console.WriteLine("Construct  angle 45 degree, 135 degree and 165 degrees");
        }
    }
    }

