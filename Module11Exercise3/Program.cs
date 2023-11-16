using System;

interface IEatable
{
    void Eat(Cat cat);
}

enum Food
{
    Fish,
    Mouse,
    CatFood
}

class Fish : IEatable
{
    public void Eat(Cat cat)
    {
        cat.IncreaseHungerLevel(3);
        Console.WriteLine($"Cat ate fish. Hunger level: {cat.GetHungerLevel()}");
    }
}

class Mouse : IEatable
{
    public void Eat(Cat cat)
    {
        cat.IncreaseHungerLevel(2);
        Console.WriteLine($"Cat ate a mouse. Hunger level: {cat.GetHungerLevel()}");
    }
}

class CatFood : IEatable
{
    public void Eat(Cat cat)
    {
        cat.IncreaseHungerLevel(1);
        Console.WriteLine($"Cat ate cat food. Hunger level: {cat.GetHungerLevel()}");
    }
}

class Cat
{
    private int hungerLevel; 

    public Cat()
    {
        hungerLevel = 0; 
    }

    public void IncreaseHungerLevel(int amount)
    {
        hungerLevel += amount;
    }

    public int GetHungerLevel()
    {
        return hungerLevel;
    }
    
    public void Eat(IEatable food)
    {
        food.Eat(this); 
    }
}

class Program
{
    static void Main()
    {
        Cat myCat = new Cat();

        IEatable fish = new Fish();
        IEatable mouse = new Mouse();
        IEatable catFood = new CatFood();

        myCat.Eat(fish);    
        myCat.Eat(mouse);   
        myCat.Eat(catFood); 
    }
}
