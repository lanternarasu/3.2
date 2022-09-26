using System;
namespace _3._2
{
    public class Class1
    {
        public static void Main(String[] args)
        {
            Class2 obj1 = new Class2();
            obj1.get_volume(2);
            obj1.get_volume(2, 3);
            obj1.get_volume(2, 3, 4);
        }
    }
}