using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainfortHighSchool
{

    internal class School
    {
       
        public void Learning (JSS1 JSS1) 
        {
            JSS1.Teach();
           
        }
        public void Test(JSS1 JSS1) 
        {
            JSS1.Asignment();
         
        }
        public void Learning(JSS2 JSS2) 
        {
            JSS2.Teach();
          
        }
        public void Test(JSS2 JSS2) 
        {
            JSS2.Asignment();
           
        }
        
    }
}
   
