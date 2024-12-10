using System;

class Lesson8{
    public static void PraktA(){
        int[] nums = new int[5];
        nums = [1, 2, 3, 4, 5];
    }

    public static void PraktB(){
        int[] nums = {2, 5, 6, 7, 2, 4, 5};
        Console.WriteLine("Второй элемент: " + nums[1]);
        nums[2] = 100;
        Console.WriteLine(nums.Length);
    }

    public void PraktC(){
        int[] nums = new int[4];
    }
}