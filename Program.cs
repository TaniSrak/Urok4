using Zoo;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //наследование и полиморфизм
            Tiger tiger = new Tiger("Tutu");
            tiger.Info("Tutu");


        }
    }


    //абстрактный класс
    public abstract class ABc
    {
        public abstract void B(int x); //асбстраткные методы должны быть обязательно в абстрактном классе
    }

    //родитель
    public class ABC //sealed - запрещает наследоваться от этого класса
    {
        public ABC() { }
        public virtual void A() { }
    }

    //дочка
    public class Abc : ABC
    {
        public Abc() : base() { }
    }

    //Task1
    public abstract class Geometric
    {
        public abstract double S();
        public abstract double P();
    }

    public abstract class Triangle : Geometric //если класс сбстрактный, то и дочка абстрактная
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public Triangle(int A, int B, int C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        //перегрузка
        public override double S()
        {
            return A * B * C;
        }
        public override double P()
        {
            return A + B + C;
        }
    }


    public abstract class Parallelepiped : Geometric //если класс сбстрактный, то и дочка абстрактная
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public Parallelepiped(int A, int B, int C, int D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
        }
        public override double S() //площадь
        {
            return A * B * C * D;
        }
        public override double P() //периметр //parallelogram
        {
            return A + B + C + D;
        }

        public static double P(int a) //периметр //square
        {
            return a * 4;
        }
        public static double P(int a, int b) //периметр //rhombus //rectangle
        {
            return a ^ 2 * b ^ 2;
        }
        


    }
}
