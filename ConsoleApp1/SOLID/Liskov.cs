using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.SOLID
{
    public class Rectangle
    {
        public virtual int Height { get; set; } 
        public virtual int Width { get; set; }  

    }
    public static class Calculate
    {
        public static  int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;  
        }
    }
    public class Square : Rectangle {

        private int _height;
        private int _width;
        public override int Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }
        public override int Width { get => base.Width; set => base.Width = value; }
    }
}
