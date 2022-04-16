using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr_3
{
    internal class Vector3
    {
        //конструктор, принимающий координаты вектора;
        static public int Count = 0;

        double x;
        double y;
        double z;

        double x1;
        double y1;
        double z1;

        double x2;
        double y2;
        double z2;


        public Vector3(double x, double y, double z)
        {//копирующий конструктор;
            Count++;
            this.x = x;
            this.y = y;
            this.z = z;

            this.x1 = x;
            this.y1 = y;
            this.z1 = z;

            this.x2 = x1;
            this.y2 = y1;
            this.z2 = z1;
        }

        public Vector3(Vector3 v)
        {
            new Vector3(v.x1, v.y1, v.z1);
            new Vector3(v.x2, v.y2, v.z2);
        }
        public double Length()
        {//метод Length, возвращающий длину вектора
            return Math.Sqrt(x1 * x1 + y1 * y1 + z1 * z1);
        }
        public double Angle()
        {//метод Angle, вычисляющий угол между текущим и другим вектором;            
            return Math.Acos((this.x1 * this.x2 + this.y1 * this.y2 + this.z1 * this.z2) / (Math.Sqrt(this.x1 * this.x1 + this.y1 * this.y1 + this.z1 * this.z1)));
        }
        public double additionX()
        {//операции сложения x=x1+x2
            return this.x = this.x1 + this.x2;
        }
        public double additionY()
        {//операции сложения y=y1+y2         
            return this.y = this.y1 + this.y2;
        }
        public double additionZ()
        {//операции сложения z=z1+z2         
            return this.z = this.z1 + this.z2;
        }
        public double subtractionX()
        {//и вычитания x=x1-x2
            return this.x = this.x1 - this.x2;
        }
        public double subtractionY()
        {//и вычитания y=y1-y2            
            return this.y = this.y1 - this.y2;
        }
        public double subtractionZ()
        {//и вычитания z=z1-z2            
            return this.z = this.z1 - this.z2;
        }
        public double imul()
        {//операцию скалярного умножения вектора на вектор (x1*x2)+(y1*y2)+(z1*z2)
            return (this.x1 * this.x2) + (this.y1 * this.y2) + (this.z1 * this.z2);
        }
        public double imulint()
        {//операции умножения на целое число
            return x * y * z;
        }
        public double divInt()
        {//операции деления на целое число;
            return x / y / z;
        }
        public override string ToString()
        {//перегруженный метод ToString.
            return string.Format("({0}, {1},{2})", x, y, z);
        }
    }
}
