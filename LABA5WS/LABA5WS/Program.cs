using System;

class Animal
{
    public string food;
    public string location;

    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издает звук");
    }

    public virtual void eat()
    {
        Console.WriteLine("Животное ест");
    }

    public void sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

class Dog : Animal
{
    public string breed;

    public override void makeNoise()
    {
        Console.WriteLine("Собака лает");
    }

    public override void eat()
    {
        Console.WriteLine("Собака кушает кость");
    }
}

class Cat : Animal
{
    public bool isLazy;

    public override void makeNoise()
    {
        Console.WriteLine("Кошка мяучит");
    }

    public override void eat()
    {
        Console.WriteLine("Кошка ест рыбу");
    }
}

class Horse : Animal
{
    public string color;

    public override void makeNoise()
    {
        Console.WriteLine("Лошадь ржет");
    }

    public override void eat()
    {
        Console.WriteLine("Лошадь пасется");
    }
}

class Ветеринар
{
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"Еда: {animal.food}, Локация: {animal.location}");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog { food = "Кость", location = "Уличная будка", breed = "Лабрадор" };
        Cat cat = new Cat { food = "Рыба", location = "Домашний кот", isLazy = true };
        Horse horse = new Horse { food = "Трава", location = "Луг", color = "Рыжий" };

        Ветеринар vet = new Ветеринар();
        vet.treatAnimal(dog);
        vet.treatAnimal(cat);
        vet.treatAnimal(horse);
    }
}