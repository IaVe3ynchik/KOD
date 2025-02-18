using System;
using System.Collections.Generic;

namespace HomeWork1802;

class Task1{
    Dictionary<string, int> dict;

    public Task1(Dictionary<string, int> d){
        dict = d;
    }

    public void Check(string s){
        try{
            int res = dict[s];
            Console.WriteLine("Перемеменная найдена.");
        }
        catch(KeyNotFoundException){
            Console.WriteLine("Переменная не найдена.");
        }
        
        Console.WriteLine("Программа продолжается.");
    }
}


class Task2{
    public static void Delenie(int a, int b){
        try{
            int res = a/b;
            Console.WriteLine(res);
        }
        catch(DivideByZeroException ex){
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Продолжение программы.");
    } 
}


class Task3{
    public static void Test(){
        try{
            Console.Write("Введите делимое: ");
            SByte a = SByte.Parse(Console.ReadLine());
            Console.Write("Введите делитель: ");
            SByte b = SByte.Parse(Console.ReadLine());
            float res = a/b;
            Console.WriteLine("Результат: " + res);
        }
        catch(FormatException){
            Console.WriteLine("Введите значение с требуемым типом.");
        }
        catch(OverflowException){
            Console.WriteLine("Число дожна находиться в пределах типа данных SByte.");
        }
        catch(DivideByZeroException){
            Console.WriteLine("На 0 делить нельзя.");
        }
    }
}