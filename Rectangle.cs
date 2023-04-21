using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopHCN
{
    internal class Rectangle
    {
        double width, height;
        public Rectangle()
        {
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public double GetArena()
        {
           return width * height;
        }
        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
        public string Display()
        {
            return "HCN{" + "chiều rộng =" + width + ", chiều dài =" + height + "}";
        }
    }
}
