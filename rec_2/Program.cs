// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
using System;
public class HW_2{
    static public void Main(string [] arg){
        System.Console.WriteLine($"введите число m:");
        int m = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine($"введите число n:");
        int n = Convert.ToInt32(Console.ReadLine());
       
        System.Console.WriteLine(Accer(m, n));
    }
    static public int Accer(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Accer(m - 1, 1);
        }
        else
        {
            return Accer(m - 1, Accer(m, n - 1));
        }
            
 } }