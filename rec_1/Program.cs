// : Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.
using System;
public class task2{
    static public void Main(string [] arg){
        System.Console.WriteLine($"введите число m:");
        int m = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());
       
        System.Console.WriteLine(ShowDigits(m, n));
    }
    static public string ShowDigits(int m, int n){
       
        if (m>n)
        return " ";
       return m + " " + ShowDigits(m+1, n);
    } 
      
 } 