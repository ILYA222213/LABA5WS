using System;

class Animal
{
    // Поля для хранения еды и местоположения животного
    public string food;
    public string location;

    // Виртуальный метод makeNoise, который будет переопределен в дочерних классах
    public virtual void makeNoise()
    {
        Console.WriteLine("Животное издает звук");
    }

    // Виртуальный метод eat, который будет переопределен в дочерних классах
    public virtual void eat()
    {
        Console.WriteLine("Животное ест");
    }

    // Не виртуальный метод sleep, который используется всеми животными
    public void sleep()
    {
        Console.WriteLine("Животное спит");
    }
}

// Класс Dog, представляющий конкретное поведение собаки
class Dog : Animal
{
    // Поле для хранения породы собаки
    public string breed;

    // Переопределенный метод makeNoise, который выводит лай собаки
    public override void makeNoise()
    {
        Console.WriteLine("Собака лает");
    }

    // Переопределенный метод eat, который выводит, что собака ест кость
    public override void eat()
    {
        Console.WriteLine("Собака кушает кость");
    }
}

// Класс Cat, представляющий конкретное поведение кошки
class Cat : Animal
{
    // Поле для хранения значения, указывающего на ленивость кошки
    public bool isLazy;

    // Переопределенный метод makeNoise, который выводит мяуканье кошки
    public override void makeNoise()
    {
        Console.WriteLine("Кошка мяучит");
    }

    // Переопределенный метод eat, который выводит, что кошка ест рыбу
    public override void eat()
    {
        Console.WriteLine("Кошка ест рыбу");
    }
}

// Класс Horse, представляющий конкретное поведение лошади
class Horse : Animal
{
    // Поле для хранения цвета лошади
    public string color;

    // Переопределенный метод makeNoise, который выводит ржание лошади
    public override void makeNoise()
    {
        Console.WriteLine("Лошадь ржет");
    }

    // Переопределенный метод eat, который выводит, что лошадь пасется
    public override void eat()
    {
        Console.WriteLine("Лошадь пасется");
    }
}

// Класс Ветеринар, который лечит животных
class Ветеринар
{
    // Метод treatAnimal, который выводит информацию о еде и местоположении животного
    public void treatAnimal(Animal animal)
    {
        Console.WriteLine($"Еда: {animal.food}, Локация: {animal.location}");
    }
}

// Класс Program, содержащий точку входа приложения
class Program
{
    static void Main()
    {
        // Создание экземпляров классов Dog, Cat и Horse
        Dog dog = new Dog { food = "Кость", location = "Уличная будка", breed = "Лабрадор" };
        Cat cat = new Cat { food = "Рыба", location = "Домашний кот", isLazy = true };
        Horse horse = new Horse { food = "Трава", location = "Луг", color = "Рыжий" };

        // Создание экземпляра класса Ветеринар
        Ветеринар vet = new Ветеринар();

        // Вызов метода treatAnimal для каждого животного
        vet.treatAnimal(dog);
        vet.treatAnimal(cat);
        vet.treatAnimal(horse);
    }
}
