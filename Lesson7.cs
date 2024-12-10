using System;

class PraktA{
    static int factor(int n) {  //Факториал числа
        if(n == 1) {
            return 1;
        }
        return n * factor(n - 1);
    }

    static int fibnum(int n) { //Числа Фибоначчи
        if(n == 1) {
            return 0;
        }
        else if(n == 2) {
            return 1;
        }
        else if (n >= 3) {
            return fibnum(n - 1) + fibnum(n - 2);
        }
        else {
            return -1;
        }
        
    }
    static string obrashenie(string s) { //Обращение строки
        if (s.Length == 0)
        {
            return s;
        }
        return s[s.Length - 1] + obrashenie(s.Substring(0, s.Length - 1));
    }

    static int SumArray(int[] array) { // Сумма элементов массива
        return SumArray(array, 0);
    }
    static int SumArray(int[] array, int i) { // Сумма элементов массива
        if(i == array.Length - 1) {
            return array[array.Length - 1];
        }
        else {
            return array[i] + SumArray(array, i + 1); 
        }
    }
    static int NodOfNum(int a, int b) { // НОД 2 чисел
        int max, min;
        if(a>=b) {
            max = a;
            min = b;
        }
        else{
            max = a;
            min = b;
        }
        if(max % min == 0) {
            return min;
        }
        else{
            return NodOfNum(min, max % min);
        }
    }

    static bool Palindrom(string str){ // Проверка строки на палиндромность
        if(str[0] != str[str.Length-1]) {
            return false;
        }

        else{
            if (str.Length == 2 || str.Length == 1)
            {
                return true;
            }
            else
            {
                return Palindrom(str.Substring(1, str.Length - 2)); 
            }
            
        }
    }

    static int Hanoi(int n){ // Нахождение количества ходов в Ханойских башнях
        if(n > 1) {
            return 2*Hanoi(n-1); 
        }
        else if(n == 1) {
            return 1;
        }
        else{
            return 0;
        }
    }

    static void AllNums(int[,] array){ // Перебор всех элементов целочисленного массива
        AllNums(array, 0, 0);
    }

    static void AllNums(int[,] array, int i1, int i2){ // Перебор всех элементов целочисленного массива
        if(i1 < array.GetLength(0)){
            if(i2 < array.GetLength(1) - 1){
                Console.Write(array[i1, i2] + ", ");
                AllNums(array, i1, ++i2);
            }
            else{
                Console.WriteLine(array[i1, i2] + ".");
                AllNums(array, ++i1, 0);
            }
        }
    }
}
