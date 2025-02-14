using System;
using System.Linq;
using Microsoft.VisualBasic;


namespace HomeWork1102;

class HomeWork1102{
    public static int[] Task1(int[] nums){
        int[] res = [nums.Max(), nums.Min()];
        return res;
    }


    public static float Task2(int[] nums){
        int sum = nums.Sum();
        return sum / (float)nums.Length;
    }


    public static bool Task3(int n, int[] nums){
        foreach(int num in nums){
            if(num == n){
                return true;
            }
        } 
        return false;
    }


    public static void Task4(int[] nums){
        Array.Sort(nums);
        Array.Reverse(nums);
    }


    public static int[] Task5(int[] nums){
        int[] res = {nums[0]};
        int[] res1;
        for(int i = 1; i < nums.Length; i++){
            if(!res.Contains(nums[i])){
                res1 = new int[res.Length+1];
                for(int j = 0; j<res.Length; j++){
                    res1[j] = res[j];
                }
                res1[res1.Length] = nums[i];
                res = res1;
            }
        }
        return res;
    } 

    // Словари
    public static Dictionary<string, int> Task6(string text){
        string[] words = text.Split(" ");
        Dictionary<string, int> res = new Dictionary<string, int>();
        for(int i = 0; i < words.Length; i++){
            res[words[i]] = words.Count(w => w == words[i]);
        }
        return res;
    }


    public static Dictionary<int, int> Task7(Dictionary<int, int> dic1, Dictionary<int, int> dic2){
        Dictionary<int, int> res = new Dictionary<int, int>();
        int[] keys1 = new int[dic1.Count];
        int[] keys2 = new int[dic2.Count];
        dic1.Keys.CopyTo(keys1, 0);
        dic2.Keys.CopyTo(keys2, 0);
        for(int i = 0; i < dic1.Count; i++){
            res[keys1[i]] = dic1[keys1[i]];
        }
        for(int i = 0;i < dic2.Count(); i++){
            if(!res.ContainsKey(keys2[i])){
                res[keys2[i]] = dic2[keys2[i]];
            }
            else{
                res[keys2[i]] += dic2[keys2[i]];
            }
        }
        return res;
    }


    public static Dictionary<string, string> Task8(Dictionary<string, string> dic){
        Dictionary<string, string> res = new Dictionary<string, string>();
        string[] keys = new string[dic.Count];
        dic.Keys.CopyTo(keys, 0);
        foreach(string key in keys){
            res[dic[key]] = key;
        }
        return res;
    }


    public static List<int> Task13(List<int> list){
        List<int> res = new List<int>();
        foreach(int el in list){
            if(el%2 == 0){
                res.Add(el);
            }
        }
        return res;
    }


    public static List<Tuple<string, int>> Task15(List<string> list){
        List<Tuple<string, int>> res = new List<Tuple<string, int>>();
        int quantity;
        foreach(string el in list.Distinct()){
            quantity = list.Where(str => str == el).Count();
            res.Add(Tuple.Create(el, quantity));
        }
        return res;
        
    }
}
