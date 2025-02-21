using System;
using System.IO;

class HomeWork2102{
    public static void Task1(){
        string path = "text.txt";
        string mess = "Наш текст.";
        File.AppendAllText(path, mess);
        string s = File.ReadAllText(path);
        Console.WriteLine(s);
    }


    public static void Task2(){
        string path = "text.txt";
        string mess = "Наш текст.";
        File.AppendAllText(path, mess);
        string s = File.ReadAllText(path);
        s = s.ToUpper();
        File.AppendAllText("text2.txt", s);
    }


    public static void Task3(){
        string path = "text3.txt";
        string mess = "John Doe;20;85,5 \nJane Smith;22;90,0 \nJim Brown;19;78,2";
        float sum = 0;
        int n = 0;
        File.WriteAllText(path, mess);
        using(StreamReader reader = new StreamReader(path)){
            string s;
            while((s = reader.ReadLine()) != null){
                sum += float.Parse(s.Split(';')[2]);
                n++;
            }
        }
        Console.WriteLine("Средний балл: " + sum/n);
    }
}