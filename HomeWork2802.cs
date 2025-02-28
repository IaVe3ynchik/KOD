using System;
using System.Linq;
using System.Collections.Generic;
using HomeWork0402;

namespace HomeWork2802;

class Person{
    public string name{ get; set;}
    public string surname{get; set;}
    public int age{ get; set;}

    public Person(string n, string s, int a ){
        name = n;
        surname = s;
        age = a;
    }
}

class HomeWork2802{
    public static dynamic Prakt1(List<Person> p){
        List<Person> people = p;
        var sovpeople = people.Where(p => p.age >= 18);
        return sovpeople;
    }


    public static dynamic Prakt2(List<Person> p){
        List<Person> people = p;
        var allAleks = people.Where(p => p.name == "Александр");
        return allAleks;
    }


    public static dynamic Prakt3(List<Person> people){
        var res = people.OrderByDescending(p => p.age);
        return res;
    }


    public static dynamic Prakt4(List<Person> people){
        var res = people.Select(p => p.name);
        return res;
    }


    public static float Prakt5(List<Person> people){
        float sum = 0;
        var ages = people.Select(p => p.age);
        foreach(int age in ages){
            sum += age;
        }
        return sum/people.Count;
    }


    public static Person Prakt6(List<Person> people){
        int res = 0;
        foreach(int age in people.Select(p => p.age)){
            if(age > res){
                res = age;
            }
        }
        foreach(Person p in people){
            if(p.age == res){
                return p;
            }
        }
        return null;
    }


    public static dynamic Prakt8(List<Person> people){
        var res = people.GroupBy(p => p.age);
        return res;
    }


    public static int Prakt9(List<Person> people){
        var allAleks = people.Where(p => p.surname == "Иванов");
        return allAleks.Count();
    }


    public static Dictionary<string, Person> Prakt10(List<Person> people){
        Dictionary<string, Person> res = new Dictionary<string, Person>();
        foreach(Person p in people){
            res[p.name] = p;
        }
        return res;
    }
}