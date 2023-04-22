/*
1. Создать массив из 10 случайных чисел в диапазоне от 0 до 5. Сжать массив, удалив из него все 0, и заполнить освободившиеся справа элементы значениями -1.

2. Заполнить квадратную матрицу размером N x N по спирали (N – нечётное число). Число 1 ставится в центр матрицы, а затем массив заполняется по спирали против часовой стрелки значениями по возрастанию.

3. Дан двумерный массив размерностью N x M, заполненный случайными числами из диапазона от 0 до 100. Выполнить циклический сдвиг массива на заданное количество столбцов. Направление сдвига задаёт пользователь.
*/


using System;
using System.Collections;
using System.Drawing;
using System.Reflection.Metadata;


namespace Program
{
    class Task1
    { 
		public void task()
        {
                Random r = new Random();

                int[] a = new int[15];

            try
            { 
                Console.WriteLine("\nИсходный массив : ");

                for (int i =0; i < a.Length; i++)
                {
                    a[i] = r.Next(0, 5);

                    Console.Write("{0,4}", a[i]);
                }

                Console.WriteLine();

                int u = 0;

                if (a[a.Length - 1] == 0)                   // Если значение последнего элемента 0, сразу присваиваем -1.
                    a[a.Length - 1] = -1;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 0)                           //проверка элемента массива на значение 0
                    {
                        u++;                                // подсчет нулей в массиве
                    }
                }

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == 0)              //проверка элемента массива на значение 0
                    {                
                            for (int j = i; j < a.Length - 1; j++)      // Сдвиг значений влево 
                            {
                                a[j] = a[j + 1];
                            }

                            i--;                    // повторно проверяем элмент на значение 0 после сдвига.
                    }                   
                }

                int y = a.Length;

                for (int i = 0; i < u; i++)     //Заполняем массив значениями -1 начиная с конца
                {
                    a[--y] = -1;
                }


                Console.WriteLine("\nРезультат : ");

                for (int i = 0; i < a.Length; i++)  //Вывод результата на экран
                {
                    Console.Write("{0,4}", a[i]);
                }


                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Task2
    {
        string GetDirection(int direction)
        {
            string result = "";

            switch (direction)                  //выбор направления
            {
                case 0:
                    result = "вверх";            //вверх
                    break;

                case 1:
                    result = "влево";            //влево
                    break;

                case 2:
                    result = "вниз";            //вниз
                    break;

                case 3:
                    result = "вправо";            //вправо
                    break;

                default:
                    result = "";            //на месте
                    break;
            }
            return result;
        }
      
        void Print(int i, int j , int[,] intArray, int direction)
        {
            Console.WriteLine("i = " + i + "\t" + "j = " + j + "\t" + "value : " + intArray[i, j] + "\t" + "direction : " + GetDirection(direction));
        }

        public void task()
        {
                Console.Write("\nВведите рамер стороны квадратной матрицы : ");

                int N = int.Parse(Console.ReadLine());

                int[,] intArray = new int[N,N];

                int i = N / 2, j = N / 2, u = 1, direction = 4, steps = 0, step = 0;

            try
            {
                while (u <= Math.Pow(N, 2))
                {
                    if (direction == 4) direction = 0;      // исходное направление

                    if (direction % 2 == 0) steps++;        //количество шагов в одном направлении

                    step = steps;
                    
                    while (step > 0)                       //подсчет шагов
                    {
                        intArray[i, j] = u;

                        //Print(i, j, intArray, direction);

                        switch (direction)                  //выбор направления
                        {
                            case 0:
                                i--;            //вверх
                                break;

                            case 1:
                                j--;            //влево
                                break;

                            case 2:
                                i++;            //вниз
                                break;

                            case 3:
                                j++;            //вправо
                                break;
                        }

                        step--;

                        u++;
                    }

                    if (step == 0) direction++;    // смена направления по часовой стрелке

                    
                }
                    Console.WriteLine();

                 for (i = 0; i < N; i++)     // вывод массива на экран
                    {
                        for (j = 0; j < N; j++)
                            {
                                Console.Write("{0,4}", intArray[i, j]);
                            }
                    Console.WriteLine();
                    Console.WriteLine();
                }                                      
                                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
    class Task3
    {
        public void task()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }

        }

    }

    class MainClass
    {
        static void Main()
        {
            string answer;
            do
            {
                Console.Clear();

                Console.WriteLine("\nЗАДАНИЯ :" +
                    "\r\n\n1. Создать массив из 10 случайных чисел в диапазоне от 0 до 5. Сжать массив, удалив из него все 0, и заполнить освободившиеся справа элементы значениями -1.\r\n2. Заполнить квадратную матрицу размером N x N по спирали (N – нечётное число). Число 1 ставится в центр матрицы, а затем массив заполняется по спирали против часовой стрелки значениями по возрастанию.\r\n3. Дан двумерный массив размерностью N x M, заполненный случайными числами из диапазона от 0 до 100. Выполнить циклический сдвиг массива на заданное количество столбцов. Направление сдвига задаёт пользователь." +
                    "\r\n\n0. Выход\n");

                Console.Write("Введите номер задания: ");

                string str = Console.ReadLine();

                switch (str)
                {
                    case "1":
                        Console.WriteLine("1. Задание");

                        Task1 obj1 = new Task1();
                        
                        obj1.task();

                        break;

                    case "2":
                        Console.WriteLine("2. Задание");

                        Task2 obj2 = new Task2();

                        obj2.task();

                        break;

                    case "3":
                        Console.WriteLine("3. Задание");

                        Task3 obj3 = new Task3();

                        obj3.task();

                        break;

                    case "0":
                        Console.WriteLine("Thank you!");
                        return;
                        break;

                    default:
                        Console.WriteLine("Такого задания нет!");
                        break;
                }
                Console.WriteLine("Ещё раз? д/н");

                answer = Console.ReadLine();

            } while (answer == "д" || answer == "Д");


        }
    }


}