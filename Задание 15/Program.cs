using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствую инженер \nвведите число для нахождения арифметической и геометрической прогрессии");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите шаг");
            int s = Convert.ToInt32(Console.ReadLine());
            ArithProgression arith = new ArithProgression();
            arith.SetStart(x);
            arith.SetStep(s);
            Console.WriteLine(arith.GetNext());
            arith.Reset();

            GeomProgression geom = new GeomProgression();
            geom.SetStart(x);
            geom.SetStep(s);
            Console.WriteLine(geom.GetNext());
            geom.Reset();

            Console.ReadKey();
        }
    }

    interface ISeries // интерфейс генерации ряда чисел
    {
        void SetStart(int x); // метод установления начального значения

        int GetNext(); // метод возвращения следующего числа ряда

        void Reset(); // метод с броса к начальному значению
    }

    class ArithProgression : ISeries // класс арифметической прогрессии
    {
        int step;
        int startValue;
        int currentValue;

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStep(int s)
        {
            step = s;
        }
    }

    class GeomProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;

        public void SetStart(int x)
        {
            startValue = x;
            currentValue = startValue;
        }

        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStep(int s)
        {
            step = s;
        }
    }
}
