using System;

class Lesson9{
    public static int SumNums(int[] nums){ // Сумма целых чисел
        int sum = 0;
        for(int i=0; i<nums.Length; i++){
            sum += nums[i];
        }
        return sum;
    }

    public static int MaxNum(int[] nums){ // Возвращает максимальное число
        return nums.Max();
    }

    public static int[] ReversNums(int[] nums){ //Переворот массива
        int[] res = new int[nums.Length];
        for(int i = 0; i < res.Length; i++){
            res[i] = nums[nums.Length - i - 1];
        }
        return res;
    }

    public static void ChetNums(int[] nums){ //Выводит чётные числа
        Console.Write("Четные числа: ");
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] % 2 == 0){
                Console.Write(nums[i] + " ");
            }
        }
        Console.WriteLine();
    }

    public static int NegativeNums(int[] nums){ //Возвращает количество отрицательных чисел
        int res = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < 0){
                res++;
            }
        }
        return res;
    }

    public static void OddNums(int[] nums){
        Console.Write("Числа на нечётных позициях: ");
        for(int i = 0; i < nums.Length; i += 2){
            Console.Write(nums[i] + " ");
        }
        Console.WriteLine();
    }

    public static void MaxAndMin(int[] nums){ //Максимальное и минимальное значение
        Console.WriteLine("Максимальное значение: " + nums.Max());
        Console.WriteLine("Минимальное значение: " + nums.Min());
    }

    public static int[] SortNums(int[] nums){ // Сортировка по возрастанию
        int a;
        for(int i = 0; i<nums.Length - 1; i ++){
            for(int k = 0; k < nums.Length - 1; k++){
                if(nums[k] > nums[k+1]){
                    a = nums[k];
                    nums[k] = nums[k+1];
                    nums[k+1] = a;
                }
            }
        }

        return nums;
    }

    public static int[] NegatToNull(int[] nums){ //Негативные числа равны 0
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] < 0){
                nums[i] = 0;
            }
        }
        return nums;
    }


    // static void Main(){
    //     int[] nums = {1, 5, 2, 1, 6, 10, 4};
    //     SortNums(nums);
    //     for(int i = 0; i<nums.Length;i++){
    //         Console.WriteLine(nums[i]);
    //     }

    // }
}