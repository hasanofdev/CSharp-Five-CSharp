using static System.Console;
namespace CSharp;

class Animal
{
    // Fields
    public string? Nickname;
    public int Age;
    public string? Gender;
    public string? Color;
    public int Energy;
    public int Price;
    public int MealQuantity;

    // Constructors
    public Animal()
    {
        Nickname = default;
        Age = default;
        Gender = default;
        Energy = default;
        Price = default;
        MealQuantity = default;
    }
    public Animal(string? nickname, int age, string? gender, string? color, int energy, int price, int mealQuantity)
    {
        Nickname = nickname;
        Age = age;
        Gender = gender;
        Color = color;
        Energy = energy;
        Price = price;
        if (mealQuantity > 100)
            MealQuantity = mealQuantity - 1;
        else
            MealQuantity = mealQuantity;
    }

    // Methods
    virtual public void Eat() { WriteLine("Eat"); }
    virtual public void Sleep() { WriteLine("Sleep"); }
    virtual public void Play() { WriteLine("Play"); }

    public override string ToString()
    {
        return $@"
      Animal
Nick Name: {Nickname}
Age: {Age}
Gender: {Gender}
Color: {Color}
Energy: {Energy}
Price: {Price}
Meal Quantity: {MealQuantity}
";
    }
}

class Cat : Animal
{
    public Cat(string? nickname,int age, string? gender, string? color, int energy, int price, int mealQuantity) : base(nickname, age, gender, color, energy, price, mealQuantity) { }
    public override void Eat()
    {
        if (MealQuantity + 20 > 100)
        {
            WriteLine("MealQuantity is Full!");
        }

        MealQuantity += 20;
    }
    public override void Play()
    {
        if (MealQuantity < 15)
        {
            WriteLine("I am Hungry!");
            return;
        }
        else if (Energy < 5)
        {
            WriteLine("I am Tired!");
            return;
        }
        else
            Energy += 30;
    }
    public override void Sleep()
    {
        Energy += 20;
    }

    public override string ToString()
    {
        return $@"
      Cat
Nick Name: {Nickname}
Age: {Age}
Gender: {Gender}
Color: {Color}
Energy: {Energy}
Price: {Price}
Meal Quantity: {MealQuantity}
";
    }
}

class Dog : Animal
{
    public Dog(string? nickname,int age, string? gender, string? color, int energy, int price, int mealQuantity) : base(nickname, age, gender, color, energy, price, mealQuantity) { }
    public override void Eat()
    {
        if (MealQuantity + 20 > 100)
        {
            WriteLine("MealQuantity is Full!");
        }

        MealQuantity += 20;
    }
    public override void Play()
    {
        if (MealQuantity < 15)
        {
            WriteLine("I am Hungry!");
            return;
        }
        else if (Energy < 5)
        {
            WriteLine("I am Tired!");
            return;
        }
        else
            Energy += 30;
    }
    public override void Sleep()
    {
        Energy += 20;
    }

    public override string ToString()
    {
        return $@"
      Dog
Nick Name: {Nickname}
Age: {Age}
Gender: {Gender}
Color: {Color}
Energy: {Energy}
Price: {Price}
Meal Quantity: {MealQuantity}
";
    }

}

class Bird : Animal
{
    public Bird(string? nickname, int age, string? gender, string? color, int energy, int price, int mealQuantity) : base(nickname, age, gender, color, energy, price, mealQuantity) { }
    public override void Eat()
    {
        if (MealQuantity + 20 > 100)
        {
            WriteLine("MealQuantity is Full!");
        }

        MealQuantity += 20;
    }
    public override void Play()
    {
        if (MealQuantity < 15)
        {
            WriteLine("I am Hungry!");
            return;
        }
        else if (Energy < 5)
        {
            WriteLine("I am Tired!");
            return;
        }
        else
            Energy += 30;
    }
    public override void Sleep()
    {
        Energy += 20;
    }
    public override string ToString()
    {
        return $@"
      Bird
Nick Name: {Nickname}
Age: {Age}
Gender: {Gender}
Color: {Color}
Energy: {Energy}
Price: {Price}
Meal Quantity: {MealQuantity}
";
    }
}

class Fish : Animal
{
    public Fish(string? nickname, int age, string? gender, string? color, int energy, int price, int mealQuantity) : base(nickname, age, gender, color, energy, price, mealQuantity) { }
    public override void Eat()
    {
        if (MealQuantity + 20 > 100)
        {
            WriteLine("MealQuantity is Full!");
        }

        MealQuantity += 20;
    }
    public override void Play()
    {
        if (MealQuantity < 15)
        {
            WriteLine("I am Hungry!");
            return;
        }
        else if (Energy < 5)
        {
            WriteLine("I am Tired!");
            return;
        }
        else
            Energy += 30;
    }
    public override void Sleep()
    {
        Energy += 20;
    }
    public override string ToString()
    {
        return $@"
      Fish
Nick Name: {Nickname}
Age: {Age}
Gender: {Gender}
Color: {Color}
Energy: {Energy}
Price: {Price}
Meal Quantity: {MealQuantity}
";
    }
}

class Program
{
    static void RemoveByNickname(List<Animal> PetShop,string Nickname)
    {
        for (int i = 0; i < PetShop.Count; i++)
            if(PetShop[i].Nickname == Nickname)
                PetShop.Remove(PetShop[i]);
    }
    static void Main()
    {
        List<Animal> PetShop = new()
        {
            new Cat("Pisik",12,"Male","Black",50,200,20),
            new Dog("It",12,"Male","Black",50,200,20),
            new Fish("Balig",12,"Male","Black",50,200,20),
            new Bird("Serce",12,"Male","Black",50,200,20)
        };

        RemoveByNickname(PetShop, "Pisik");

        foreach (var animal in PetShop)
            WriteLine(animal);
    }
}