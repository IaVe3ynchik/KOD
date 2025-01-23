using System;

namespace HomeWork2101;
class Contact{ // 1
    public string name;
    public string phone;
    public string email;
    public void PrintContact(){
        Console.WriteLine($"Имя: {name}, телефон: {phone}, почта: {email}");
    } 
}
class PhoneBook{
    Contact[] list;

    public void AddContact(Contact c){
        if(list == null){
            list = new Contact[1];
            list[0] = c;
        }
        else{
            Contact[] result = new Contact[list.Length + 1];
            for(int i = 0; i < list.Length; i++){
                result[i] = list[i];
            }
            result[result.Length - 1] = c;
            list = result;
        }
    }

    public void FindContactByName(Contact c){
        int i = Array.IndexOf(list, c);
        Console.WriteLine(i!= -1 ? "Индекс контакта: " + i : "Такого контакта нет.");
    }

    public void RemoveContact(int id){
        if(list != null){
            Contact[] res = new Contact[list.Length - 1];
            for(int i = 0; i < id; i++){
                res[i] = list[i];
            }
            for(int i = id + 1; i < list.Length; i++){
                res[i - 1] = list[i];
            }
            list = res;
        }
    }   
}


class Student{ // 2
    public string name;
    public int[] grades;

    public void AddGrade(int g){
        if(grades == null){
            grades = new int[1];
            grades[0] = g;
        }
        else{
            int[] result = new int[grades.Length + 1];
            for(int i = 0; i < grades.Length; i++){
                result[i] = grades[i];
            }
            result[result.Length - 1] = g;
            grades = result;
        }
    }

    public float GetAverageGrade(){
        float sum = 0;
        foreach(int grade in grades){
            sum += grade;
        }
        return sum/grades.Length;
    }
}
class Classroom{
    Student[] students;

    public void AddStudent(Student s){
        if(students == null){
            students = new Student[1];
            students[0] = s;
        }
        else{
            Student[] result = new Student[students.Length + 1];
            for(int i = 0; i < students.Length; i++){
                result[i] = students[i];
            }
            result[result.Length - 1] = s;
            students = result;
        }
    } 

    public void GetTopStudent(){
        if(students != null){
            int res = 0;
            for(int i = 1; i < students.Length; i++){
                if(students[i].GetAverageGrade() > students[i-1].GetAverageGrade()){
                    res = i;
                } 
            }

            Console.WriteLine($"У ученика {students[res].name} самый высокий средний балл.");
        }

        else{
            Console.WriteLine("В списке нет учеников.");
        }     
    }
}

class Product{ // 3
    public string name;
    public int price;
    public int quantity;

    public void Buy(int i){
        if(quantity - i >= 0){
            quantity -= i;
            Console.WriteLine("Покупка совершена успешно.");
        }
        
        else{
            Console.WriteLine("Покупка не совершена.");
        }
    }
}
class Store{
    Product[] products;
    public void AddProduct(Product prod){
        if(products == null){
            products = new Product[1];
            products[0] = prod;
        }
        else{
            Product[] result = new Product[products.Length + 1];
            for(int i = 0; i < products.Length; i++){
                products[i] = products[i];
            }
            result[result.Length - 1] = prod;
            products = result;
        }
    }

    public void FindProductByName(Product prod){
        int i = Array.IndexOf(products, prod);
        Console.WriteLine(i!= -1 ? "Индекс продукта: " + i : "Такого продукта нет.");
    } 

    public void SellProduct(int id){
        if(products != null){
            Product[] res = new Product[products.Length - 1];
            for(int i = 0; i < id; i++){
                res[i] = products[i];
            }
            for(int i = id + 1; i < products.Length; i++){
                res[i - 1] = products[i];
            }
            products = res;
        }
    } 
}

class Animal{ // 4
    public void Eat(){
        Console.WriteLine("Животное ест.");
    }

    public virtual void Speak(){
        Console.WriteLine("Животное произносит звуки.");
    }
}
class Lion: Animal{
    public override void Speak()
    {
        Console.WriteLine("Лев рычит");
    }
}
class Elephant: Animal{
    public override void Speak()
    {
        Console.WriteLine("Слон трубит.");
    }
}
class Monkey: Animal{
    public override void Speak()
    {
        Console.WriteLine("Обезьяна кричит.");
    }
}

class GameCharacter(){ // 5
    public string name;
    public int health = 100;

    public virtual void Attack(GameCharacter target){
        Console.WriteLine(name + " атакует " + target.name);
    }
}
class Warrior: GameCharacter{
    public int armor = 100;
    public override void Attack(GameCharacter target){
        target.health -= 5;
        Console.WriteLine(name + " атакует мечом персонажа " + target.name);
    }
} 
class Mage: GameCharacter{
    public int mana = 100;
    public override void Attack(GameCharacter target){
        target.health -= 5;
        Console.WriteLine(name + " атакует магией персонажа " + target.name);
    }
} 


class Delivery{ // 6
    public string address;
    public int price;
}
class CourierDelivery: Delivery{
    public void DeliverByCourier(string address, int price){
        this.address = address;
        this.price = price;
        Console.WriteLine("Заказ будет доставлен курьером по адресу: " + address + ". Стоимость: " + price);
    }
}
class Pickup: Delivery{
    public void PickUpFromStore(int price){
        this.price = price;
        Console.WriteLine("Заказ будет доступен самовывозом в магазине. Стоимость: " + price);
    }
}


class Book{ // 7
    public string name;
    public string author;
    public int price;
    public Book(string n, string a, int p){
        name = n;
        author = a;
        price = p;
    }
}
// Через foreach и входящий в него if вывести методом Console.WriteLine() нужные книги

class Lesson{ // 8
    public string subject;
    public int time;
    public string teacher;
}
// Создать расписание в виде списка, и, как в предыдущем примере, вывести нужные уроки


class Employee{ // 9
    public string name;
    public string position;
    public int salary;
}
class Manager: Employee{
    Employee[] workers;

    public void AddWorker(Employee worker){
        if(workers == null){
            workers = new Employee[1];
            workers[0] = worker;
        }
        else{
            Employee[] result = new Employee[workers.Length + 1];
            for(int i = 0; i < workers.Length; i++){
                result[i] = workers[i];
            }
            result[result.Length - 1] = worker;
            workers = result;
        }
    }

    public int GeneralSalary(){
        int res = 0;
        if(workers != null){
            foreach(Employee worker in workers){
                res += worker.salary;
            }
        }
        return res;
    }
}


class Car{ // 11
    public string model;
    public int speed;
    public int distance;

    public void Drive(int hours){
        distance = hours * speed;
    }
}
class Race{
    public Race(Car a, Car b){
        if(a.distance > b.distance){
            Console.WriteLine("Победила машина модели " + a.model);
        }
        if(a.distance < b.distance){
            Console.WriteLine("Победила машина модели " + b.model);
        }
        else{
            Console.WriteLine("Ничья");
        }
    }
}


class Passenger{ // 14
    public string name;
    public int passportNumber;
}
class Flight{
    public int flightNumber;
    public string destination;
    Passenger[] passengers;

    public void AddPassenger(Passenger passen){
        if(passengers == null){
            passengers = new Passenger[1];
            passengers[0] = passen;
        }
        else{
            Passenger[] result = new Passenger[passengers.Length + 1];
            for(int i = 0; i < passengers.Length; i++){
                result[i] = passengers[i];
            }
            result[result.Length - 1] = passen;
            passengers = result;
        }
    }

    public bool CheckPassenger(Passenger passen){
        if(passengers.Contains(passen)){
            return true;
        }

        else{
            return false;
        }
    }
}


class Astronaut{ // 15
    public string name;
    public string role;
}
class Rocket{
    public string name;
    public int fuel;
    Astronaut[] crew;

    public void AddAstr(Astronaut astr){
        if(crew == null){
            crew = new Astronaut[1];
            crew[0] = astr;
        }
        else{
            Astronaut[] result = new Astronaut[crew.Length + 1];
            for(int i = 0; i < crew.Length; i++){
                result[i] = crew[i];
            }
            result[result.Length - 1] = astr;
            crew = result;
        }
    }

    public void Launch(){
        if(fuel >= 100){
            Console.WriteLine("Топлива в ракете достаточно.");
            if(crew != null){
                Console.WriteLine("Состав экипажа: ");
                foreach(Astronaut a in crew){
                    Console.Write(a.name + " ");
                }
                Console.WriteLine();
            }
            else{
                Console.WriteLine("У ракеты нет экипажа.");
            }
        }
        else{
            Console.WriteLine("Топлива не хватает.");
        }

    }
}