using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID
{
   public class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public string Academy { get; set; }

        public bool CheckClassDay(string day)
        {
            if(day == "Monday" || day == "Friday")
            {
                return true;
            }
            return false;   
        }
    }
    public abstract class BaseStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Academy Academy { get; set; }
        public abstract bool CheckClassDay(string day); 

    }
    public class ProgramingStudent : BaseStudent
    {
        public ProgramingStudent() {
            Academy = Academy.Programing;
        
        }  
        public override bool CheckClassDay(string day)
        {
            if (day == "Monday" || day == "Friday")
            {
                return true;
            }
            return false;
        }
    }

    public enum Academy
    {
        Programing,
        UI,
    }
}
