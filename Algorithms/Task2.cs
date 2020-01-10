using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Task2
    {
        const string taskInfoStr = "\nЛестницы\n" +
            "Ограничение времени: 1.0 секунды\n" +
            "Ограничение памяти: 64 МБ\n" +
            "У маленького мальчика есть набор из N кубиков(5 <= N <= 500). Из этих кубиков можно сложить различные лестницы.\n" +
            "Лестницы имеют ступени различного размера, следующие в порядке возрастания этого размера(обратите особое внимание \n" +
            "на то, что лестница не может иметь две одинаковые ступени). Каждая лестница должна иметь минимум две ступени, и каждая \n" +
            "ступень должна состоять минимум из одного кубика.\n" +
            "Найдите число Q различных лестниц, которые маленький мальчик может построить ровно из N кубиков.\n" +
            "Исходные данные \n" +
            "Число N\n"+
            "Результат\n"+
            "Число Q\n" +
            "УДАЧИ!!!\n";
        public Task2()
        {
            taskInfo();
        }

        public void Start()
        {
            int N;
            string str = "";
            while (str != "q")
            {
                Console.WriteLine("Input N");
                N = int.Parse(Console.ReadLine());
                Console.WriteLine($"Result:{ladersCombination(N)}");
                Console.WriteLine("Press 'q' to quit");
                str = Console.ReadLine();
            }
        }

        long ladersCombination(int num)
        {
            long n = num;
            long[] count = null;
            count = new long[n + 1];
            count[0] = 1;
            for (long i = 1; i <= n; i++)
            {
                for (var j = n; j >= i; j--)
                {
                    count[j] = count[j] + count[j - i];
                }
            }

            return count[num] - 1;

        }
        void taskInfo()
        {
            Console.WriteLine(taskInfoStr);
        }
    }
}
