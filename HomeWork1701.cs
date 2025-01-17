using System;
using System.Net.WebSockets;

namespace HomeWork1701;
class BankAccount{
    private float balance;

    public float money{
        get{
            return balance;
        }
    }

    public void Deposit(float a){
        if(a > 0){
            balance += a;
        }
    }

    public void Withdraw(float a){
        if(a > 0 && a <= balance){
            balance -= a;
        }
    }

}

class Car{
    public string Make;
    public int Year;

    public Car(string s, int a){
        Make = s;
        Year = a;
    }

    public void DisplayInfo(){
        Console.WriteLine($"Марка: {Make}. Год выпуска: {Year}");
    }
}

class Person{
    public string Name;
    public int Age;

    public Person(string s, int a){
        Name = s;
        Age = a;
    }

    public virtual void GetInfo(){
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}

class Student: Person{
    public int Grade;

    public override void GetInfo()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}, Класс: {Grade}");
    }

    public Student(string s, int a, int b): base(s, a){
        Grade = b;
    }

}

class Shape{
    public virtual void GetArea(){

    }
}

class Circle: Shape{
    public int Radius;
    public override void GetArea(){
        Console.WriteLine("Площадь круга: " + Math.PI * Math.Pow(Radius, 2));
    }
}

class Rectangle: Shape{
    public int Width;
    public int Height;

    public override void GetArea(){
        Console.WriteLine("Площадь прямоугольника: " + Width * Height);
    }
}


class Animal{
    public virtual void Speak(){
        Console.WriteLine("Животное издаёт звук");
    }
}

class Dog: Animal{
    public override void Speak(){
        Console.WriteLine("Собака гавкает");
    }
}

class Cat: Animal{
    public override void Speak(){
        Console.WriteLine("Кошка мяукает");
    }
}