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

