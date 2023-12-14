// Задайте произвольный массив. Выведете 
// его элементы, начиная с конца. Использовать 
// рекурсию, не использовать циклы

using System;
public class HW_3 {
    static public void Main (string [] arg) {
        int [] array1 = {1, 4, 7, 20, 5, 6};
        
        System.Console.WriteLine(ShowArray(array1, array1.Length-1));

    }
    static string ShowArray(int [] array, int index)
 {
        if ( index < 0 )
            return "";
            return array[index] +" "+ ShowArray(array, index-1);
       
 }
    

    }