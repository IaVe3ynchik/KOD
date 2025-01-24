using System;
using HomeWork2101;

namespace HomeWork2401;

abstract class Animal{
    public abstract void make_sound();
    public abstract void move();
}

class Dog: Animal{
    public override void make_sound()
    {
        Console.WriteLine("Собака лает.");
    }

    public override void move()
    {
        Console.WriteLine("Собака бегает.");
    }
}

class Bird: Animal{
    public override void make_sound()
    {
        Console.WriteLine("Птица поёт.");
    }

    public override void move()
    {
        Console.WriteLine("Птица летает.");
    }
}


abstract class Shape{ // 2 Практика
    public abstract void area();

    public abstract void perimeter();
}

class Rectangle: Shape{
    public int dolgota;
    public int shirina;

    public Rectangle(int d, int sh){
        dolgota = d;
        shirina = sh;
    }

    public override void area()
    {
        Console.WriteLine(dolgota * shirina);
    }

    public override void perimeter()
    {
        Console.WriteLine(2 * (dolgota + shirina));
    }
}

class Circle: Shape{
    public int radius;

    public Circle(int r){
        radius = r;
    }

    public override void area()
    {
        Console.WriteLine(Math.PI * Math.Pow(radius, 2));
    }

    public override void perimeter()
    {
        Console.WriteLine(2 * Math.PI * radius);
    }
}


abstract class Transport{ // 3 Практика
    public abstract void move();
    public abstract void fuel_type();

    public void PrintInfo(){
        move();
        fuel_type();
    }
}

class Car: Transport{
    public override void move()
    {
        Console.WriteLine("Машина едет по дороге.");
    }

    public override void fuel_type()
    {
        Console.WriteLine("Машина использует бензин.");
    }
}

class Plane: Transport{
    public override void move()
    {
        Console.WriteLine("Самолёт летает.");
    }

    public override void fuel_type()
    {
        Console.WriteLine("Самолёт использует авиационное топливо.");
    }
}


abstract class Payment{ // 4 Практика
    public abstract void process_payment(int amount);
}

class CardPayment: Payment{
    public override void process_payment(int amount){
        Console.WriteLine("Платёж с помощью карты. Сумма: " + amount);
    }
}

class CashPayment: Payment{
    public override void process_payment(int amount){
        Console.WriteLine("Платёж наличными. Сумма: " + amount);
    }
}


abstract class Employee{ // 5 Практика
    public abstract void calculate_salary();
}

class HourlyEmployee: Employee{
    public int hours;
    public int salary_per_hour;

    public HourlyEmployee(int h, int s){
        hours = h;
        salary_per_hour = s;
    }

    public override void calculate_salary(){
        Console.WriteLine(hours * salary_per_hour);
    }
}

class SalariedEmployee: Employee{
    public int salary;

    public SalariedEmployee(int s){
        salary = s;
    }

    public override void calculate_salary()
    {
        Console.WriteLine(salary);
    }
}

abstract class MediaFile{ // 6 Практика
    public abstract void play();
    public abstract void stop();
}

class AudioFile: MediaFile{
    public override void play()
    {
        Console.WriteLine("Аудиофайл запущен.");
    }

    public override void stop()
    {
        Console.WriteLine("Аудиофайл остановлен.");
    }
}

class VideoFile: MediaFile{
    public override void play()
    {
        Console.WriteLine("Видеофайл запущен.");
    }

    public override void stop()
    {
        Console.WriteLine("Видеофайл остановлен.");
    }
}


// class HomeWork2401{ // Главный класс
//     public static void Main(){
//         Dog rex = new Dog(); // 1 Практика
//         Dog dog= new Dog();
//         Bird bird= new Bird();
//         Bird chik = new Bird();
//         Animal[] animals= {rex, dog, bird, chik};
//         foreach(Animal animal in animals){
//             animal.make_sound();
//             animal.move();
//         }


//         Rectangle rect = new Rectangle(5, 4); // 2 Практика
//         rect.area();
//         rect.perimeter();
//         Circle circ = new Circle(5);
//         circ.area();
//         circ.perimeter();


//         CardPayment operation1 = new CardPayment(); // 4 Практика
//         operation1.process_payment(100);
//         CashPayment operation2 = new CashPayment();
//         operation1.process_payment(456);


//         HourlyEmployee hourly1 = new HourlyEmployee(4, 500); // 5 Практика
//         SalariedEmployee salaried1 = new SalariedEmployee(600);
//         Employee[] employees = {hourly1, salaried1};
//         foreach(Employee employee in employees){
//             employee.calculate_salary();
//         }


//         AudioFile audio1 = new AudioFile(); // 6 Практика
//         VideoFile video1 = new VideoFile();
//         MediaFile[] medias = {video1, audio1};
//         foreach(MediaFile media in medias){
//             media.play();
//             media.stop();
//         }
//     }
// }