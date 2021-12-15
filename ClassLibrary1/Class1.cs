using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int[] randomArr(int length, int minValue = -10, int maxValue = 10)  
        {
            int[] array = new int[length];
        Random random = new Random();
           for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minValue, maxValue);

            }
            return array;
        }


        public static int task1(int [] array)
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] < 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static int task2(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                   if(array[i] > max)
                    {
                        max = array[i];
                    }
                }
            }
            return max;
        }
        public static int task3(int[] array)
        {

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
        public static int task4(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                
                
                    if (array[i] > max)
                    {
                        max = i;
                    }
                
            }
            return max;
        }
        public static int task5(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
               
                    if (Math.Abs(array[i]) > max)
                    {
                        max = array[i];
                    }
                
            }
            return max;
        }
        public static int task6(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {


                if (array[i] > 0)
                {
                    sum += i;
                }

            }
            return sum;
        }
        public static int task7(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
               if(array[i] % 2 != 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    }
    

