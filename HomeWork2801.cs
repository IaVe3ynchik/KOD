using System;
using PracticeA;

namespace HomeWork2801;

abstract class Shape{ // 1
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

class Rectangle: Shape{
    public int shirina;
    public int visota;
    public Rectangle(int s, int v){
        shirina = s;
        visota = v;
    }

    public override double GetArea()
    {
        return shirina * visota;
    }

    public override double GetPerimeter()
    {
        return 2 * (visota + shirina);
    }
}

class Circle: Shape{
    public int radius;
    public Circle(int r){
        radius = r;
    }

    public override double GetArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double GetPerimeter()
    {
        return 2 * radius * Math.PI;
    }
}


abstract class Animal{ // 2
    public string name;
    public Animal(string n){
        name = n;
    } 
    public abstract void MakeSound();
}

class Cat: Animal{
    public Cat(string n): base(n){}
    public override void MakeSound(){
        Console.WriteLine("Гав-гав");
    }
}

class Dog: Animal{
    public Dog(string n): base(n){}
    public override void MakeSound(){
        Console.WriteLine("Мяу-мяу");
    }
}

class Cow: Animal{
    public Cow(string n): base(n){}
    public override void MakeSound(){
        Console.WriteLine("Муу");
    }
}

abstract class Transport{ // 3
    public int speed;
    public abstract void Move();
}

class Car: Transport{
    public override void Move()
    {
        Console.WriteLine($"Еду по дороге со скоростью {speed} км/ч");
    }
}

class Boat: Transport{
    public override void Move()
    {
        Console.WriteLine($"Плыву по воде со скоростью {speed} км/ч");
    }
}

class Plane: Transport{
    public override void Move()
    {
        Console.WriteLine($"Лечу в небе со скоростью {speed} км/ч");
    }
}

abstract class BankAccount{ // 4
    public double balance;
    public abstract void Withdraw(double amount);
    public void Deposit(double amount){
        balance += amount;
    }
}

class SavingsAccount: BankAccount{
    public SavingsAccount(double m){
        balance = m;
    }

    public override void Withdraw(double amount)
    {
        if(balance - amount >= 100){
            balance -= amount;
        }
        
        else{
            Console.WriteLine("Нельзя вывести");
        }
    }
}

class CreditAccount: BankAccount{
    public CreditAccount(double m){
        balance = m;
    }

    public override void Withdraw(double amount)
    {
        if(balance - amount >= -500){
            balance -= amount;
        }
        
        else{
            Console.WriteLine("Нельзя вывести");
        }
    }
}

abstract class GameCharacter{ // 5
    public string name;
    public abstract void Attack(); 
}

class Warrior: GameCharacter{
    public override void Attack()
    {
        Console.WriteLine($"{name} атакует мечом!");
    }
}

class Mage: GameCharacter{
    public override void Attack()
    {
        Console.WriteLine($"{name} атакует магией!");
    }
}

class Archer: GameCharacter{
    public override void Attack()
    {
        Console.WriteLine($"{name} стреляет из лука!");
    }
}

abstract class Robot{ // 6
    public string Model;
    public abstract void PerformTask();
}

class CleanerRobot: Robot{
    public override void PerformTask(){
        Console.WriteLine($"{Model} убирает комнату");
    }
}

class CookRobot: Robot{
    public override void PerformTask(){
        Console.WriteLine($"{Model} готовит еду");
    }
}

class GuardRobot: Robot{
    public override void PerformTask(){
        Console.WriteLine($"{Model} охраняет помещение");
    }
}


// class HomeWork2801{
//     public static void Main(){
//         Shape[] shapes = {new Rectangle(2, 4), new Rectangle(3, 6), new Circle(3), new Circle(5), new Circle(7)}; // 1
//         foreach(Shape shape in shapes){
//             Console.WriteLine(shape.GetArea());
//             Console.WriteLine(shape.GetPerimeter());
//         }


//         Animal[] animals = {new Dog("Rex"), new Cat("Kitty"), new Cow("My")}; // 2
//         foreach(Animal animal in animals){
//             animal.MakeSound();
//         }


//         Transport[] transports= {new Car(), new Boat(), new Plane()}; // 3
//         foreach(Transport transport in transports){
//             transport.Move();
//         }


//         SavingsAccount acc1 = new SavingsAccount(100); // 4
//         acc1.Deposit(200);
//         acc1.Withdraw(299);
//         SavingsAccount acc2 = new SavingsAccount(300);
//         acc2.Deposit(1);
//         acc2.Withdraw(400);
//         CreditAccount acc3 = new CreditAccount(400);
//         acc3.Deposit(100);
//         acc3.Withdraw(499);
//         CreditAccount acc4 = new CreditAccount(350);
//         acc4.Deposit(50);
//         acc4.Withdraw(10000);


//         GameCharacter[] characters = {new Warrior(), new Mage(), new Archer()}; // 5
//         foreach(GameCharacter character in characters){
//             character.Attack();
//         }


//         Robot[] robots = {new CookRobot(), new CleanerRobot(), new GuardRobot()}; // 6
//         foreach(Robot robot in robots){
//             robot.PerformTask();
//         }
//     }
// }