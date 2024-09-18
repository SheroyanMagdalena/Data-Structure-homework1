using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // Data Structures

        List<int> list = new List<int>() { 8, 9, 5, 7 };
        list.Add(0);
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

       Dictionary<string,int> keyValuePairs = new Dictionary<string, int>();
        keyValuePairs.Add("Adam", 34);
        keyValuePairs.Add("Roman", 15);
        keyValuePairs.Add("Mark", 25);
        keyValuePairs.Add("Louis", 45);
        keyValuePairs.Add("Andy", 10);

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(90);
        queue.Enqueue(18);
        queue.Enqueue(26);
        queue.Enqueue(33);
        queue.Enqueue(40);

        Stack<int> stack = new Stack<int>();
        stack.Push(231);
        stack.Push(254);
        stack.Push(38);
        stack.Push(41);
        stack.Push(50);

        //Operation on DS

        // sum of all elements in the list
        int listsum = 0;
        foreach (int item in list)
        {
            listsum += item;
        }
        Console.WriteLine("Sum of all element in list = " + listsum);

        //sum of all values in the dictionary
        int dictsum = 0;
        foreach (var item in keyValuePairs.Values)
        {
            dictsum += item;
            }
        Console.WriteLine("Sum of elements in dictionary is " + dictsum);

        //Remove 2 elements from the queue and print the remaining elements
        queue.Dequeue();
        queue.Dequeue();

        Console.WriteLine("Remaining elements in the queue:");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }

        //Remove 2 elements from the stack and print the remaining elements.
        stack.Pop();
        stack.Pop();
        Console.WriteLine("Remaining elements in the stack:");
        foreach (int item in stack)
        {
            Console.WriteLine(item);
        }

        // Additional Task

        //Print all elements of the list
        Console.WriteLine("All elements in list");
        foreach(int item in list)
        {
            Console.WriteLine(item);
        }

        // Largest & smallest digit
        int number = 876;
        int min = 10000;
        int max = -1000;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > max)
            {
                max = digit; 
            }
            number /= 10; 
        }
        Console.WriteLine("Largest number is " + max);

        while (number > 0)
        {
            int digit = number % 10;
            if (digit < min)
            {
                min = digit;
            }
            number /= 10;
        }
        Console.WriteLine("Smallest number is " + min);

        // find all even values in array and print their sum.
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int evenSum = 0;
        foreach(int item in arr)
        {
            if (item % 2 == 0)
                evenSum += item;
        }
        Console.WriteLine("Sum of even elements are " + evenSum);

        //Avarage sum in array
        float avarSum = 0;
        float sum1 = 0;
        foreach(int item in arr)
        {
            sum1 += item;
            avarSum = sum1/arr.Length;
        }
        Console.WriteLine("Avarage sum of all elements are " + avarSum);
    }
}

