using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Vector3.Count);
            var v = new Vector3(1, 4, 5);
            var w = new Vector3(1, 2, 4);

            var v2 = new Vector3(v);
            Console.WriteLine("|v|= {0} ", v.Length());
            Console.WriteLine("|v|= {0} ", w.Length());
            Console.WriteLine("Угол вектор равен {0}", v.Angle());
            Console.WriteLine("Угол вектор равен {0}", w.Angle());
            Console.WriteLine("скалярного умножения вектора на вектор ={0}", v.imul());
            Console.WriteLine("скалярного умножения вектора на вектор ={0}", w.imul());
            Console.WriteLine("перегруженный метод ToString.= {0} ", v.ToString());
            Console.WriteLine("перегруженный метод ToString = {0}", w.ToString());
        }
    }
}
