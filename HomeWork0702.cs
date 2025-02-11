using System;

namespace HomeWork0702;

class HomeWork0702{
    static void Task1(int[] n){
        int[] nums = n;
        Console.WriteLine(nums.Max());
    }


    static void Task2(List<string> str){
        List<string> strings = str;
        strings.Sort();
    }


    static void Task3(Dictionary<string, int> dics){
        Dictionary<string, int> dic = dics;
        Console.WriteLine(dic.Values.Max());
    }


    static void Task4(Queue<string> t){
        // Queue<string> tasks = new Queue<string>(); - Очередь задач
        Console.WriteLine("Задача " + t.Dequeue() + " выполняется.");
    }


    static void Task5(Stack<string> p){
        // Stack<string> pages = new Stack<string>(); - Стек страниц
        Console.WriteLine("Страница " + p.Pop() + " возвращена.");
    }


    static void Task6(List<Person> p){
        List<Person> persons = p;
        for(int i = 0; i < persons.Count; i++){
            if(persons[i].age > 30){
                Console.WriteLine(persons[i].name + " старше 30 лет.");
            }
        }
    }


    static Dictionary<string, int> Task7(string text, string[] words){
        Dictionary<string, int> dic = new Dictionary<string, int>();
        for(int i = 0; i < words.Length;i++){
            dic[words[i]] = text.Split(words[i]).Length - 1;
        }
        return dic;
    }


    static void Task8(Queue<string> s){
        Queue<string> shop = s;
        shop.Dequeue(); // Обслуживание покупателя завершено 
        shop.Enqueue("Покупатель"); // Новый клиент
    }


    static void Task9(Stack<string> s, string op){
        s.Push(op);
    }
    static void Task9(Stack<string> s){
        s.Pop();
    }


    static List<int> Task10(List<int> ints){
        for(int i = 0; i < ints.Count(); i++){
            if(ints[i] < 0){
                ints.RemoveAt(i);
            }
        }
        return ints;
    }
}

class Person{
    public string name {get; set;}
    public int age {get; set;}
}