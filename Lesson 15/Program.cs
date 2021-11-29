using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Program
    {
        //Разработать интерфейс ISeries генерации ряда чисел.Интерфейс содержит следующие элементы:
        //  метод void setStart(int x) - устанавливает начальное значение
        //  метод int getNext() - возвращает следующее число ряда
        //  метод void reset() - выполняет сброс к начальному значению
        //Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries.
        //В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите разность арифметической прогрессии "); // Из условия не понятно нужно ли реализовывать выбор разнисти прогрессии , принял решение сделать вызова метода.
            //int diff = Convert.ToInt32(Console.ReadLine());
            //ArithProgression arithProgression = new ArithProgression(diff);
            //Console.WriteLine("Введите длину ряда чисел");
            //int series = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Введите начальное значение");
            //arithProgression.setStart();

            //for (int i = 0; i < series; i++)
            //{
            //    arithProgression.getNext();
            //    Console.Write(arithProgression.value + " ");
            //}
            //Console.WriteLine("\nПоследнее число в ряду равно : {0}\n", arithProgression.value);
            //arithProgression.reset();
            //Console.WriteLine("\n Значение после вызова метода reset равно : {0}", arithProgression.value);


            //Console.ReadKey();

            Console.WriteLine("Введите значение знаменателеz геометрической прогрессии");
            int denom = Convert.ToInt32(Console.ReadLine());
            GeomProgression geomProgression = new GeomProgression(denom);
            Console.WriteLine("Введите длину ряда чисел");
            int series = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начальное значение");
            geomProgression.setStart();

            for (int i = 0; i < series; i++)
            {
                geomProgression.getNext();
                Console.Write(geomProgression.n + " ");
                geomProgression.n+=1;
            }
            //geomProgression.getNext();
            //Console.Write(geomProgression.n + " ");
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart();
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {

        public int value { get; set; }
        public int difference;
        public ArithProgression(int difference)
        {
            this.difference = difference;
        }
        public void setStart()
        {
            value = Convert.ToInt32(Console.ReadLine());
        }
        public int getNext()
        {
            value += difference;
            return value;
        }
        public void reset()
        {
            value = 0;
            return;
        }
    }
    class GeomProgression : ISeries
    {

        public int value;
        public int n;
        public int denominator;
        public GeomProgression(int denominator)
        {
            this.denominator = denominator;
            
        }
        public void setStart()
        {
            value = Convert.ToInt32(Console.ReadLine());
        }
        
        public int getNext()
        {
            
            value=Convert.ToInt32(value*(Math.Pow(denominator,n-1)));
            
            return value;
        }

        public void reset()
        {
            value = 0;
            return;
        }
    }
}
