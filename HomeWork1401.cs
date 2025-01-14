using System;

class Person{
    public string name;
    public int age;

    public void Introduce(){
        Console.WriteLine("Привет, мое имя " + name);
    }

    public Person(string n, int a){
        name = n;
        age = a;
    }

    public void CheckSet(int a){
        if(a >= 0){
            age = a;
            Console.WriteLine("Возраст неотрицательный.");
        }
        else{
            Console.WriteLine("Возраст отрицательный.");
        }
    }
}

class Employee: Person{
    public int position;

    public Employee(int p, string n, int a): base(n, a){
        position = p;
    }
    

}

// class HomeWork1401{
//     static void Main(){
//         Person a = new Person("Vik", 19);
//         Person b = new Person("Mike", 10);
//         Person c = new Person("Max", 29);
//         Person d = new Person("Oleg", 9);
//         Person[] objs = {a, b, c, d};
//         foreach(Person obj in objs){
//             obj.Introduce();
//         }
//     }
// }