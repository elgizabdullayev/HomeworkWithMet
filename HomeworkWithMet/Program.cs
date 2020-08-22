using System;

namespace HomeworkWithMet
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            do
            {
                try
                {
                    Console.WriteLine("Введите имя и возраст первого человека.");
                    string Name1 = Console.ReadLine();
                    int age1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите имя и возраст второго человека.");
                    string Name2 = Console.ReadLine();
                    int age2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите имя старшего.");
                    string Name3 = Console.ReadLine();

                    if (age1 > age2)
                    {
                        if (Name3 == Name1)
                        {
                            Console.WriteLine($"Все верно! : {Name1} старше {Name2} на {age1 - age2} лет (год).");
                            break;
                        }
                        if (Name3 == Name2)
                        {
                            Console.WriteLine($"Не верно! : {Name1} старше {Name2} на {age1 - age2} лет (год) .");
                            break;
                        }
                        if (Name3 != Name1 && Name3 != Name2)
                        {
                            Console.WriteLine("Введено неверное имя!");
                            continue;
                        }
                    }
                    if (age2 > age1)
                    {
                        if (Name3 == Name2)
                        {
                            Console.WriteLine($"Все верно! : {Name2} старше {Name1} на {age2 - age1} лет (год).");
                            break;
                        }
                        if (Name3 == Name1)
                        {
                            Console.WriteLine($"Не верно! : {Name2} старше {Name1} на {age2 - age1} лет (год).");
                            break;
                        }
                        if (Name3 != Name1 && Name3 != Name2)
                        {
                            Console.WriteLine("Введено неверное имя!");
                            continue;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Введено неверное значение. Проверьте порядок ввода.");
                    continue;
                }
            }
            while (i > 0);
            Console.ReadKey();
        }
    }
}
