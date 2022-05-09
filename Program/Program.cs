using System;
namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)

        {
            string[] arrayString = NewArray();
            Console.WriteLine();
            PrintArray();

//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.




            void PrintArray()
            {
                for(int i = 0; i<arrayString.Length; i++)
                {
                    if (arrayString[i].Length<=3)
                    {
                        Console.WriteLine(arrayString[i]);
                    }
                }

            }


            string[] NewArray()
            {

                Console.WriteLine("Введите длину массива: ");
                int l = Convert.ToInt32(Console.ReadLine());
                string[] array = new string[l];
                
                int count = 0;

                while(count<l)
                    {
                        Console.WriteLine($"Введите {count+1}ю строку: ");
                        string stroka = Convert.ToString(Console.ReadLine());
                        array[count] = stroka;
                        count++;
                    }

                return array;

            }




        }
    }
}

