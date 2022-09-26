using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._2
{
    internal class Class2
    {
        
        public void get_volume(int a)
        {
            int cube = a * a * a;
            Console.WriteLine(cube);
        }
        public void get_volume(int l,int w,int h)
        {
            int cuboid = l * w * h;
            Console.WriteLine(cuboid);
        }
        public void get_volume(int r, int h)
        {
            double cylinder = 3.14 * r * r * h;
            Console.WriteLine(cylinder);
        }
    }
}
