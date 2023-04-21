using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopHCN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double width, height;
            Console.WriteLine("Tính chu vi, diện tích HCN.");
            Console.WriteLine("Nhập chiều rộng < chiều dài.");
            do
            {
                Console.Write("Nhập chiều rộng HCN :");
                width = double.Parse(Console.ReadLine());
                Console.Write("Nhập chiều dài HCN :");
                height = double.Parse(Console.ReadLine());
            }
            while (width > height);
            Rectangle rectangle = new Rectangle(width,height);
            Console.WriteLine(rectangle.Display());
            Console.WriteLine($"Diện tích HCN :{rectangle.GetArena()} ");
            Console.WriteLine($"Chu vi HCN : {rectangle.GetPerimeter()}");
            Console.ReadLine();            
        }
    }
}
