using System;

namespace HomeWork3101;

interface IAnimal{ // Базовая задача
    void MakeSound();
}

class Dog: IAnimal{
    public void MakeSound() => Console.WriteLine("Собака гавкает.");
}

class Cat: IAnimal{
    public void MakeSound() => Console.WriteLine("Кошка мяукает.");
}


interface IVehicle{ // Средний уровень
    int Speed{ get; set;}
    void Move();
}

class Car: IVehicle{
    public void Move() => Console.WriteLine("Машина едет по шоссе.");
    public int Speed{ get; set;}
}

class Bicycle: IVehicle{
    public void Move() => Console.WriteLine("Машина едет по шоссе.");
    public int Speed{ get; set;}
}


interface IWritter{ // Продвинутый уровень
    void Write();
}

interface IReader{
    void Read();
}

class FileManager: IWritter, IReader{
    public void Write() => Console.WriteLine("Запуск изменения текста..");
    public void Read() => Console.WriteLine("Чтение текста запущено.");
}