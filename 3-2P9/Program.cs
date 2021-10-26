using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2P9
{
    struct PointS
    {
        public int X;
        public int Y;
    }

    class PointC
    {
        public int X;
        public int Y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ///переменные
            ///списки
            ///массивы
            ///перечисления
            ///структура данных
            ///поля классов (переменные, списки, массивы, перечисления, структура данных)
            ///

            PointS ps = new PointS() { X = 2, Y = 3 };
            PointC pc = new PointC() { X = 4, Y = 5 };
            #region h
            PointS ps2 = new PointS();
            ps2.X = 6;
            ps2.Y = 7;

            PointC pc2 = new PointC();
            pc2.X = 8;
            pc2.Y = 9;
            #endregion
            Distance(ps, 10, out ps);
            Distance(pc);

            Console.WriteLine($"{ps.X} {ps.Y}");
            Console.WriteLine($"{pc.X} {pc.Y}");

            MyClass<string> myClass = new MyClass<string>();
            Console.WriteLine(myClass.ToString("5"));

            ИЛетающий l = new Боинг();
            l.Взлетай();
            ИЛетающий[] m = new ИЛетающий[] {
                new Боинг(),
                new Утка()
            };
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i].Взлетай());
            }
            foreach (ИЛетающий item in m)
            {
                Console.WriteLine(item.Взлетай());
                if(item is ИПтица)
                {
                    Console.WriteLine(((ИПтица)item).Кушай());
                }
            }

            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Не удалось привести к числу");
            }
            Console.ReadLine();

        }

        public static void Distance(ref PointS ps, int z = 10)
        {
            ps.X = ps.X * z;
            ps.Y = ps.Y * z;
        }

        public static void Distance(PointC pc, int z)
        {
            pc.X = pc.X * z;
            pc.Y = pc.Y * z;
        }

        public static void Distance(PointC pc)
        {
            Distance(pc, 10);
        }

        public static void Distance(PointS ps, int z, out PointS ps1)
        {
            ps.X = ps.X * z;
            ps.Y = ps.Y * z;
            ps1 = ps;
        }
    }

    interface ИЛетающий
    {
        string Взлетай();
    }

    interface ИСамолет: ИЛетающий
    {
        void Заправиться();
    }
    interface ИПтица : ИЛетающий
    {
        string Кушай();
    }


    class Боинг : ИСамолет
    {
        public string Взлетай()
        {
            return "ЖЖЖЖЖЖ";
        }

        public void Заправиться()
        {
            throw new NotImplementedException();
        }
    }

    class Утка : ИПтица
    {
        public string Взлетай()
        {
            return "Кря-Кря";
        }

        public string Кушай()
        {
            return "Ням-Ням";
        }
    }

    class MyClass<MyType>
    {
        public string ToString(MyType x)
        {
            return x.GetType().ToString();
        }
        public override string ToString()
        {
            return typeof(MyType).ToString();
        }
    }
}
