/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
//using System.CodeDom.Compiler;

int[] GenerateArroy(int n)
{
    int[] Arr = new int[n];
    for(int i = 0; i < n; i++)
    {
       Arr[i] = new Random().Next(-99, 99);
    }
    return Arr;
}

void PrintArray(int[] Arr)
    {
    Console.Write("[ ");  
    
    for (int i = 0; i < Arr.Length; i++)
    {
    Console.Write(Arr[i] + " ");        
    }
    Console.Write("]");  
    }

int SummNeChetnArray(int[] Arr)
{ int Sum = 0; 
  for (int i = 0; i < Arr.Length; i++)
    {
    if ((Arr[i] % 2) != 0)  Sum = Sum+Arr[i];     
    } 
    return Sum;
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int[] Arr = GenerateArroy(n);
PrintArray(Arr);
Console.WriteLine(""); 
Console.Write("Сумма нечетных чисел:" + SummNeChetnArray(Arr)); 
