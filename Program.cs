Start();

void Start()
{
    while (true)
    {
       

        System.Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        System.Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        System.Console.WriteLine("44) Задача 44:выведите первые N чисел Фибоначчи.");
       
        System.Console.WriteLine("0) End");

        int numTask = EnterNumber("task");

        switch (numTask)
        {
            case 0: return; break;



            case 41:
                Console.Clear();
                // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

                // 0, 7, 8, -2, -2 -> 2

                // 1, -7, 567, 89, 223-> 3


                Console.WriteLine($"\n\nЗадача 41");


                int ArraySize = EnterNumber($"\nHow much elemenets would you like to enter?");

                int [] array41 = new int [ArraySize];

                for (int i = 0; i < array41.Length; i++)

                    {
                        Console.Write($"\nEnter {i} element of curent array:\t");
                        array41[i] = int.Parse(Console.ReadLine());
                    }
                int result = 0;
                foreach (var el in array41)
                {
                    if (el >0)
                    {
                        result++;
                    }
                }

                Console.WriteLine($"\nIn current array \n\n{String.Join(" ", array41)} ->\t{result} nummbers bigger than 0.\n");
                
                break;

            case 43:
                Console.Clear();

                // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
                // заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

                // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

                Console.WriteLine($"\n\nЗадача 43");

                double b1 = EnterNumber ("\nPlese enter b1");
                double k1 = EnterNumber ("\nPlese enter k1");
                double b2 = EnterNumber ("\nPlese enter b2");
                double k2 = EnterNumber ("\nPlese enter k2");

                crossPoint(b1, k1, b2, k2);

    
                break;




                default: System.Console.WriteLine("error"); break;
        }       
    }
}


int EnterNumber(string number) // функция для ввода целочисленного значения пользователем
        {
            Console.Write($"{number}: "); 
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }


 int[] CreateArray(int size, int minValue, int maxValue) // функция по заполнению массива целочисленными значениями
        {
            int[] res = new int[size];

            for (int i = 0; i < size; i++)
            {
                res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
        }

void crossPoint (double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1)/(k1 - k2);
    double y = k1*x + b1;

    if (k1 == k2)
    {
        Console.WriteLine($"\nCurent lines dosen't cross.");
        return;
    }
    
    Console.WriteLine($"\nPoint of cross is ({x};{y})\n");
}

