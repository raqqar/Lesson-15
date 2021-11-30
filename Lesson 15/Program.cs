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
            Console.WriteLine("Введите разность арифметической прогрессии "); // Из условия не понятно нужно ли реализовывать выбор разнисти прогрессии , принял решение сделать вызова метода.
            int diff = Convert.ToInt32(Console.ReadLine());
            ArithProgression arithProgression = new ArithProgression(diff);
            Console.WriteLine("Введите длину ряда чисел");
            int series = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите начальное значение");
            arithProgression.setStart();

            for (int i = 0; i < series; i++)
            {
                arithProgression.getNext();
                Console.Write(arithProgression.value + " ");
            }
            Console.WriteLine("\nПоследнее число в ряду равно : {0}\n", arithProgression.value);
            arithProgression.reset();
            Console.WriteLine("\nЗначение после вызова метода reset равно : {0}\n", arithProgression.value);


            Console.WriteLine("Введите значение знаменателея геометрической прогрессии");
            int denom = Convert.ToInt32(Console.ReadLine());
            GeomProgression geomProgression = new GeomProgression(denom);
            Console.WriteLine("Введите длину ряда чисел");
            series = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начальное значение");
            geomProgression.setStart();

            for (int i = 0; i < series; i++)
            {
                geomProgression.getNext();
                Console.Write(geomProgression.value + " ");
            }
            geomProgression.reset();
            Console.WriteLine("\nЗначение после вызова метода reset равно : {0}\n", geomProgression.value);
            Console.ReadKey();
        }
    }
    //Создаем интерфейс с методами setStart(),getNext(),reset()
    interface ISeries
    {
        void setStart();
        int getNext();
        void reset();
    }
    //Создаем класс Арифм.прогрессии и реализуем интерфейс
    class ArithProgression : ISeries
    {

        public int value { get; set; }
        public int difference;
        public int valueStart;
        public ArithProgression(int difference)
        {
            this.difference = difference;
        }
        public void setStart()
        {
            value = Convert.ToInt32(Console.ReadLine());
            valueStart = value;
        }
        public int getNext()
        {
            value += difference;
            return value;
        }
        public void reset()
        {
            value = valueStart;
            return;
        }
    }
    //Создаем класс Геометр. прогрессии и реализуем интерфейс
    class GeomProgression : ISeries
    {

        public int value;
        public int valueStart;

        public int denominator;
        public GeomProgression(int denominator)
        {
            this.denominator = denominator;
            
        }
        public void setStart()
        {
            value = Convert.ToInt32(Console.ReadLine());
            valueStart=value;
    }
        
        public int getNext()
        {
            
            value=value*denominator;
            
            return value;
        }

        public void reset()
        {
            value = valueStart;
            return;
        }
    }
}
