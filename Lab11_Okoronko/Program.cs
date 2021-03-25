using System;

namespace Lab11_Okoronko
{
    class Vector
    {

        // Координаты точки в трехмерном пространстве
        public int x, y, z;
        public Vector(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public Vector() { }
        public override string ToString()
        {
            return "Координаты (x, y, z) = (" + this.x + ", " + this.y + ", " + this.z + ")";
        }
        // ПЕРЕГРУЗКА УНАРНЫХ ОПЕРАТОРОВ
        // "+" (+1)
        public static Vector operator ++(Vector obj1)
        {
            Vector obj2 = new Vector();
            obj2.x = obj1.x + 1;
            obj2.y = obj1.y + 1;
            obj2.z = obj1.z + 1;
            return obj2;
        }
        // "-" (-3)
        public static Vector operator --(Vector obj1)
        {
            Vector obj2 = new Vector();
            obj2.x = obj1.x - 3;
            obj2.y = obj1.y - 3;
            obj2.z = obj1.z - 3;
            return obj2;
        }
        // ПЕРЕГРУЗКА ОПЕРАТОРОВ ОТНОШЕНИЙ

        // Перегрузка оператоар false
        public static bool operator false(Vector obj)
        {
            if ((obj.x <= 0) || (obj.y <= 0) || (obj.z <= 0))
                return true;
            return false;
        }

        // Перегрузка парного оператора true
        public static bool operator true(Vector obj)
        {
            if ((obj.x > 0) && (obj.y > 0) && (obj.z > 0))
                return true;
            return false;
        }
        // Перегрузка парного оператора ">"
        public static bool operator >(Vector obj1, Vector obj2)
        {
            if ((obj1.x > obj2.x) && (obj1.y > obj2.y) && (obj1.z > obj2.z))
                return true;
            return false;
        }

        // Перегрузка парного оператора "<"
        public static bool operator <(Vector obj1, Vector obj2)
        {
            if ((obj1.x != obj2.x) || (obj1.y != obj2.y) || (obj1.z != obj2.z))
                return true;
            return false;
        }

        // ПЕРЕГРУЗКА БИНАРНЫХ ОПЕРАТОРОВ
        // "+"
        public static Vector operator +(Vector obj1, Vector obj2)
        {
            Vector obj3 = new Vector();
            obj3.x = obj1.x + obj2.x;
            obj3.y = obj1.y + obj2.y;
            obj3.z = obj1.z + obj2.z;
            return obj3;
        }
        // "-"
        public static Vector operator -(Vector obj1, Vector obj2)
        {
            Vector obj3 = new Vector();
            obj3.x = obj1.x - obj2.x;
            obj3.y = obj1.y - obj2.y;
            obj3.z = obj1.z - obj2.z;
            return obj3;
        }
        // "*"
        public static Vector operator *(Vector obj1, Vector obj2)
        {
            Vector obj3 = new Vector();
            obj3.x = obj1.x * obj2.x;
            obj3.y = obj1.y * obj2.y;
            obj3.z = obj1.z * obj2.z;
            return obj3;
        }
        // "/" (Деление)
        public static Vector operator /(Vector obj1, Vector obj2)
        {
            Vector obj3 = new Vector();
            obj3.x = obj1.x / obj2.x;
            obj3.y = obj1.y / obj2.y;
            obj3.z = obj1.z / obj2.z;
            return obj3;
        }
        // ПЕРЕГРУЗКА ЛОГИЧЕСКИХ ОПЕРАТОРОВ
        // "&"
        public static bool operator &(Vector obj1, Vector obj2)
        {
            if (((obj1.x > 0) && (obj1.y > 0) && (obj1.z > 0))
                & ((obj2.x > 0) && (obj2.y > 0) && (obj2.z > 0)))
                return true;
            return false;
        }

        // "!"
        public static bool operator !(Vector obj1)
        {
            if ((obj1.x > 0) && (obj1.y > 0) && (obj1.z > 0))
                return false;
            return true;
        }

    }
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату х: ");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату у: ");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату z: ");
            int z = Int32.Parse(Console.ReadLine());
            Vector EnterPoint = new Vector(x,y,z);
            Console.WriteLine("Координаты Вашей точки: (x, y, z) = (" + EnterPoint.x + ", " + EnterPoint.y + ", " + EnterPoint.z+")");

            // Перегрузка унарных операторов
            // "+" (+1)
            Vector Point1 = EnterPoint;
            Point1++;
            Console.WriteLine("\nУвеличение на 1: \n{0}", Point1.ToString());
            // "-" (-3)
            Vector Point2 = EnterPoint;
            Point2--;
            Console.WriteLine("\nУменьшение на 3: \n{0}", Point2.ToString());

            Console.Write("\nВвод координат второй точки.");
            Console.WriteLine("\nКоордината k: ");
            int k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Координата i: ");
            int i = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Координата j: ");
            int j = Int32.Parse(Console.ReadLine());
            Vector MinorPoint = new Vector(k,i,j);
            Console.WriteLine("\nКоординаты Вашей второй точки: (k, i, j) = (" + MinorPoint.x + ", " + MinorPoint.y + ", " + MinorPoint.z + ")");
            // Перегрузка true, false
            if (EnterPoint)
                Console.WriteLine("\nКоординаты первой введенной точки положительны");
            // Перегрузка >,<
            if (EnterPoint>MinorPoint)
            {
                Console.WriteLine("\nКоординаты первой точки, больше второй");
            }
            else
            {
                Console.WriteLine("\nКоординаты первой точки, меньше координат второй");
            }
       
            // Перегрузка бинарного "+"
            Vector Point3 = EnterPoint + MinorPoint;
            Console.WriteLine("\nПервая точка + Вторая точка = " + Point3.x + " " + Point3.y + " " + Point3.z);
            // Перегрузка бинарного "-"
            Vector Point4 = EnterPoint - MinorPoint;
            Console.WriteLine("\nПервая точка - Вторая точка = "+ Point4.x + " " + Point4.y + " " + Point4.z);
            // Перегрузка бинарного "*"
            Vector Point5 = EnterPoint * MinorPoint;
            Console.WriteLine("\nРезультат умножения координат Первой точки на Вторую точку = " + Point5.x + " " + Point5.y + " " + Point5.z);
            // Перегрузка бинарного "/"
            Vector Point6 = EnterPoint / MinorPoint;
            Console.WriteLine("\nРезультат деления координат Первой точки на Вторую точку = " + Point6.x + " " + Point6.y + " " + Point6.z);

            // Перегрузка логических операторов
            if (EnterPoint & MinorPoint)
                Console.WriteLine("\nУ двух точек все координаты положительные");
            else
                Console.WriteLine("\nЕсть отрицательные или равные нулю координаты");
            if (!EnterPoint)
                Console.WriteLine("\nУ Первой точки есть отрицательные координаты");
            if (!MinorPoint)
                Console.WriteLine("\nУ Второй точки есть отрицательные координаты");



            Console.ReadLine();
        }
    }
}
