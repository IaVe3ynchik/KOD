using System;

namespace HomeWork0402;

abstract class Animal{ // 1
    public string name{get; set;}
    public Animal(string s){
        name = s;
    }
    public abstract void make_sound();
    public abstract void info();
}

class Lion: Animal{
    public Lion(string s) : base(s){}
    public override void make_sound(){
        Console.WriteLine("рычит: Р-р-р!");
    }
    public override void info()
    {
        Console.WriteLine("Это лев по имени " + name);
    }
}

class Elephant: Animal{
    public Elephant(string s) : base(s){}
    public override void make_sound(){
        Console.WriteLine("трубит: Тууу!");
    }
    public override void info()
    {
        Console.WriteLine("Это слон по имени " + name);
    }
}

class Parrot: Animal, ICanFLy{
    public Parrot(string s) : base(s){}
    public override void make_sound(){
        Console.WriteLine("говорит: Привет!");
    }
    public void fly() => Console.WriteLine("Попугай умеет летать");
    public override void info()
    {
        Console.WriteLine("Это попугай по имени " + name);
    }
}

interface ICanFLy{
    void fly();
}


abstract class BankAccount{ // 2
    public float Balance{get; protected set;}
    public BankAccount(float b){
        Balance = b;
    }
    public abstract void deposit(float amount);
    public abstract void withdraw(float amount);
    public abstract void get_balance();
}

class SavingsAccount: BankAccount, ITransaction{
    public SavingsAccount(float b): base(b){}
    public override void deposit(float amount)
    {
        Balance += amount;
        Console.WriteLine("Накопительный счёт пополнен на " + amount);
    }
    public override void withdraw(float amount){
        Console.WriteLine("Вывести деньги с накопительного счёта нельзя");
    }
    public override void get_balance()
    {
        Console.WriteLine(Balance);
    }
    public void transfer(float amount, BankAccount account){
        withdraw(amount);
        account.deposit(amount);
    }
}

class CreditAccount: BankAccount, ITransaction{
    public CreditAccount(float b): base(b){}
    public override void deposit(float amount)
    {
        Balance += amount;
        Console.WriteLine("Кредитный счёт пополнен на " + amount);
    }
    public override void withdraw(float amount){
        if(Balance -  amount >= -1000){
            Balance -= amount;
            Console.WriteLine("С кредитного счёта снято " + amount);
        }
        else{
            Console.WriteLine("Ошибка вывода");
        }
    }
    public override void get_balance()
    {   
        Console.WriteLine(Balance);
    }

    public void transfer(float amount, BankAccount account){
        withdraw(amount);
        account.deposit(amount);
    }

}

interface ITransaction{
    void transfer(float amount, BankAccount account);
}


abstract class Product: IDiscountable{ // 3
    public string name{get; set;}
    public int price{get; set;}
    public Product(string n, int p){
        name = n;
        price = p;
    }
    public void apply_discount(int percent){
        price *= 1 - percent/100;
    }
    public abstract void print_info();
}

class FoodProduct: Product{
    public int shelf_life{get; set;}
    public FoodProduct(string n, int p, int s): base(n, p){
        shelf_life = s;
    }
    public override void print_info()
    {
        Console.WriteLine($"Продукт {name} стоимостью {price} рублей и со сроком годности {shelf_life} дней.");
    }
}

class Electronics: Product{
    public int warranty{get; set;}
    public Electronics(string n, int p, int w): base(n, p){
        warranty = w;
    }
    public override void print_info()
    {
        Console.WriteLine($"Продукт {name} стоимостью {price} рублей и с гарантией {warranty} дней.");
    }
}

interface IDiscountable{
    void apply_discount(int percent);
}


abstract class Vehicle: IRefuelable{ // 4
    public int speed{get; set;}
    public Vehicle(int s){
        speed = s;
    }
    public abstract void move();
    public void refuel(int amount){
        Console.WriteLine("Транспорт заправлен на " + amount + " литров.");
    }
    public abstract void get_info();
}

class Car: Vehicle{
    public string brand;
    public Car(int s, string b): base(s){
        brand = b;
    }
    public override void move(){
        Console.WriteLine("Педаль нажата - машина едет.");
    }
    public override void get_info()
    {
        Console.WriteLine($"Автомобиль бренда {brand} движется со скоростью {speed} км/ч.");
    }
}

class Motorcycle: Vehicle{
    public string type;
    public Motorcycle(int s, string t): base(s){
        type = t;
    }
    public override void move(){
        Console.WriteLine("Ручка газа выжата - мотоцикл едет.");
    }
    public override void get_info()
    {
        Console.WriteLine($"Мотоцикл типа {type} движется со скоростью {speed} км/ч.");
    }
}

interface IRefuelable{
    void refuel(int amount);
}


abstract class Person{ // 5
    public string name{get; set;}
    public int age{get; set;}
    public Person(string n, int a){
        name = n;
        age = a;
    }
    public abstract void introduce();
}

class Student: Person, ITeachable{
    public int grade{get; set;}
    public Student(string n, int a, int g) : base(n, a){
        grade = g;
    }
    public void teach() => Console.WriteLine("Ученик готов к учёбе.");
    public override void introduce()
    {
        Console.WriteLine($"Ученик {grade} класса {name} в возрасте {age} лет.");
    }
}

class Teacher: Person{
    public string subject{get; set;}
    public Teacher(string n, int a, string s) : base(n, a){
        subject = s;
    }
    public void teach() => Console.WriteLine("Учитель готов обучать.");
    public override void introduce()
    {
        Console.WriteLine($"Учитель по {subject} {name} в возрасте {age} лет.");
    }
}

interface ITeachable{
    void teach();
}


abstract class Racer{ // 6
    public int speed{get; set;}
    public Racer(int s){
        speed = s;
    }
    public abstract void race();
    public void get_race_status(){
        Console.WriteLine("Текущая скорость гонщика - " + speed);
    }

}

class CarRacer: Racer, ITurboBoost{
    public CarRacer(int s): base(s){}
    public override void race() => Console.WriteLine("Гонщик жмёт на педаль.");
    public void boost(){
        speed++;
        Console.WriteLine("Гонщик включает следующую передачу.");
    }
}

class BikeRacer: Racer, ITurboBoost{
    public BikeRacer(int s): base(s){}
    public override void race() => Console.WriteLine("Гонщик крутит педали");
    public void boost() {
        speed++;
        Console.WriteLine("Гонщик начал быстрее крутить педали.");
    }
}

interface ITurboBoost{
    void boost();
}

class User{ // 7
    public string name{get; set;}
    public string email{get; set;}
    public User(string n, string e){
        name = n;
        email = e;
    }
}

class Customer: User{
    Product[] Cart;
    public Customer(string n, string e): base(n, e){}
}

class Admin: User, IManageable{
    public Admin(string n, string e): base(n, e){}
    public void add_product(Product product) => Console.WriteLine("В магазин добавлен товар " + product.name);
    public void remove_product(Product product) => Console.WriteLine("В магазине убран товар " + product.name);
}

interface IManageable{
    void add_product(Product product);
    void remove_product(Product product);
}


abstract class Instrument{ // 8
    public abstract void play();
    public abstract void get_sound();
}

class Guitar: Instrument, ITunable{
    public override void play() => Console.WriteLine("Зажат аккорд.");
    public void tune() => Console.WriteLine("Все шесть струн настроены.");
    public override void get_sound()
    {
        Console.WriteLine("Трии-и-и-инь");
    }
}

class Piano: Instrument, ITunable{
    public override void play() => Console.WriteLine("Несколько клавиш нажато.");
    public void tune() => Console.WriteLine("Все клавиши настроены.");
    public override void get_sound()
    {
        Console.WriteLine("Звя-я-як");
    }
}

interface ITunable{
    void tune();
}

class Book{ // 9
    public string title{get; set; }
    public string author{get; set; }
    public Book(string t, string a){
        title = t;
        author = a;
    }
}

class FictionBook: Book, IReadable{
    public FictionBook(string t, string a): base(t, a){}
    public void read() => Console.WriteLine($"Книга \"{title}\" жанра фантастика, автор: {author}");
}

class ScienceBook: Book, IReadable{
    public ScienceBook(string t, string a): base(t, a){}
    public void read() => Console.WriteLine($"Книга \"{title}\" научная, автор: {author}");
}

interface IReadable{
    void read();
}

class Library{
    public Book[] books;
    public void add_book(Book book){
        // создание нового списка с длинной 1, если его не существует
        // или, если список существует, создание нового списка длинной на 1 больше, копирование элементов из старого списка в новый, добавление в новый нового элемента
    }
    public void remove_book(Book book){
        // Вывести сообщение об ошибке, если списка нет или длина списка 0
        // или, если список существует, создание нового списка длинной на 1 меньше; копирование элементов, кроме выбранного, из старого списка в новый
    }
}


class Character{
    public string name{get; set; }
    public int health{get; set; }
    public Character(string n, int h){
        name = n;
        health = h;
    }
}

class Warrior: Character, IFightable{
    public Warrior(string n, int h): base(n, h){}
    public void attack() => Console.WriteLine("Воин атакует мечом врага.");
}

class Mage: Character, IFightable{
    public Mage(string n, int h): base(n, h){}
    public void attack() => Console.WriteLine("Маг запускает огненный шар во врага.");
}

interface IFightable{
    void attack();
}


class Program{
    public static void Main(){
        Animal[] animals= {new Lion("Лео"), new Elephant("Джордж"), new Parrot("Майк")};
        foreach(Animal anim in animals){
            anim.make_sound();
        }
    }
}