using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Person : Isum
    {
        private string _url;
        public string Name { get; set; }    
        public int Age { get; set; }

       
        public bool IsActive { get; set; }  
        public void Sum(int age ,int num1)
        {
            Console.WriteLine(age + num1);// varijabla ako sakam ovde da stam odit so mala bukva
        }

    }
}
