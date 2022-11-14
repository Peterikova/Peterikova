using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
//Даны три значения а. b. с. Нанта значение, наиболее близкое к среднему арифметическому (а+b+с)/3, вывести это значение н его имя.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;//задаем вводимые переменные 
            double m,//среднее арифметические
                ka, kb, kc;//разница между переменной и средним арифметическим
            Console.Write(" целое значение a = ");
            a = Convert.ToInt32(Console.ReadLine());//ввод переменной a
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());//ввод переменной b
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());//ввод переменной c
            m = (a + b + c) / 3;//расчет среднего арифметического
            ka = Math.Abs(m - a);//разница между переменной a и m
            kb = Math.Abs(m - b);//разница между переменной b и m
            kc = Math.Abs(m - c);//разница между переменной b и m
            if (ka < kb)//расчет и вывод наименьшей разницы
            {
                if (ka < kc)
                    Console.Write("Наиболее близкое к среднему арифметическому число a = " + a);
                else
                    Console.Write("Наиболее близкое к среднему арифметическому число c = " + c);
            }
            else
            {
                if (kb < kc)
                    Console.Write("Наиболее близкое к среднему арифметическому число b = " + b);
                else
                    Console.Write("Наиболее близкое к среднему арифметическому число c = " + c);
            }
            Console.ReadKey();

        }
    }
}
