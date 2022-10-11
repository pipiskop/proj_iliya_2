Console.WriteLine("4. Закрыть программу");
int Num = Convert.ToInt32(Console.ReadLine());
{
    while (Num < 4)
    {

        switch (Num)
        {
            case 1:
                Console.WriteLine("\n1. ну такое (0 - 50)\n2. уже покруче (0 - 100)\n3. супер лвл (0 - 10000)\n");
                Console.WriteLine("выбор режима, введите число ");
                int num = 0;
                Random rand = new Random();
                while (true)
                {
                    Double reg = Convert.ToDouble(Console.ReadLine());
                    if (reg == 1)
                    {
                        num = rand.Next(0, 50);
                        break;
                    }
                    else if (reg == 2)
                    {
                        num = rand.Next(0, 100);
                        break;
                    }
                    else if (reg == 3)
                    {
                        num = rand.Next(0, 10000);
                        break;
                    }
                    else
                        Console.WriteLine("введено недопустимое число. Введите 1, 2, либо 3");
                }
                Console.WriteLine("я загадал число, аты угадывай");
                while (true)
                {
                    Double input = Convert.ToDouble(Console.ReadLine());
                    if (num > input)
                        Console.WriteLine("возьми больше.");
                    else if (num < input)
                        Console.WriteLine("возьми меньше.");
                    else
                        Console.WriteLine("ты угадал!!!!! ");
                }
                break;

            case 2:
                int[,] arr = new int[10, 10];
                int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                for (int i = 0; i < arr1.Length; ++i)
                {
                    Console.Write(arr1[i] + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 1; i < arr.GetLength(0); ++i)
                {
                    for (int j = 1; j < arr.GetLength(1); ++j)
                    {
                        int sum = i * j;
                        if (i == j)
                        {
                            arr[i, j] = sum;
                            Console.Write(arr[i, j] + "\t");
                        }
                        else if (i > j)
                        {
                            arr[i, j] = sum;
                            Console.Write(arr[i, j] + "\t");
                        }
                        else if (i < j)
                        {
                            arr[i, j] = sum;
                            Console.Write(arr[i, j] + "\t");
                        }
                    }
                    Console.WriteLine("\n\n");
                }

                break;
            case 3:
                Console.WriteLine("введите число");
                Double переменная_которое_написано_на_русском = Convert.ToDouble(Console.ReadLine());
                for (int i = 1; i <= переменная_которое_написано_на_русском; i++)
                {
                    if (переменная_которое_написано_на_русском % i == 0)
                        Console.WriteLine(i);
                }
                break;
        }
        Console.WriteLine("1. Угадай число");
        Console.WriteLine("2. Таблица умножения");
        Console.WriteLine("3. Вывод делителей числа");
        Console.WriteLine("4. Закрыть программу");
        Num = Convert.ToInt32(Console.ReadLine());
        if (Num == 4)
        {
            Environment.Exit(0);
        }
    }
}
