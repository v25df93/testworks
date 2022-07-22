public class Animal
{
    protected string name;
    protected int calories;
    protected int amount;
    public int days;

    public Animal()
    {
        this.name = "0";
        this.calories = 0;
        this.amount = 0;

    }

    public Animal(string name, int calories, int amount)
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;


    }

    public string getNameAnimal()
    {
        return name;
    }

    //public int getCaloriesPerMonth()
    //{
    //    return calories * amount * 30;

    //}
    public int getAmountAnimal()
    {
        return amount;
    }
    public int getCaloriesAnimal()
    {
        return calories;
    }

};
class Plant : Animal
{

    float kgOfFood;
    int caloriesInBanana = 960;
    public Plant(string name, int calories, int amount)
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
        kgOfFood = (float)amount * calories / caloriesInBanana;
    }

    public float getBananas()
    {
        return kgOfFood;
    }
}
class Meat : Animal
{
    float kgOfFood;
    int caloriesInMeat = 3180;
    public Meat(string name, int calories, int amount)
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
        kgOfFood = (float)amount * calories / caloriesInMeat;
    }


    public float getMeat()
    {
        return kgOfFood;
    }
}
class meatPlant : Animal
{
    private float kgOfMeat;
    private float kgOfBananas;
    private int caloriesInMeat = 3180;
    private int caloriesInBananas = 960;

    public meatPlant(string name, int calories, int amount)
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
        kgOfMeat = (float)amount * calories / (2 * caloriesInMeat);
        kgOfBananas = (float)amount * calories / (2 * caloriesInBananas);
    }

    public float getMeat()
    {
        return kgOfMeat;
    }
    public float getBananas()
    {
        return kgOfBananas;
    }
}
class testanimal
{
    static int amountofdays()
    {
        Console.WriteLine("Введите цифру месяца: \n 1)Январь \n 2)Февраль \n 3)Март \n 4)Апрель \n 5)Май \n 6)Июнь \n 7)Июль\n 8)Август \n 9)Сентябрь \n 10)Октябрь \n 11)Ноябрь \n 12)Декабрь");
        int month;
        int days;
        month = Convert.ToInt16(Console.ReadLine());
        if (month == 4 || month == 6 || month == 9 || month == 11)
            days = 30;
        else if (month == 2)
            days = 28;
        else
            days = 31;
        return days;
    }


    static void Main()
    {
        int amount;
        int days;
        float kgBanans = 0;
        float kgMeat = 0;
        var theMeats = new List<Meat>();
        var thePlants = new List<Plant>();
        var theBoth = new List<meatPlant>();
        days = amountofdays();


        Console.WriteLine("Введите количество медведей");
        amount = Convert.ToInt16(Console.ReadLine());
        theBoth.Add(new meatPlant("Медведь", 15000, amount));

        Console.WriteLine("Введите количество львов");
        amount = Convert.ToInt16(Console.ReadLine());
        theMeats.Add(new Meat("Лев", 10000, amount));

        Console.WriteLine("Введите количество обезьян");
        amount = Convert.ToInt16(Console.ReadLine());
        thePlants.Add(new Plant("Обезьяна", 1000, amount));

        foreach (meatPlant theAnimal in theBoth)
        {
            kgBanans += theAnimal.getBananas();
            kgMeat += theAnimal.getMeat();
        }
        foreach (Meat theAnimal in theMeats)
        {
            kgMeat += theAnimal.getMeat();
        }
        foreach (Plant theAnimal in thePlants)
        {
            kgBanans += theAnimal.getBananas();
        }
        Console.WriteLine("Необходимо мяса: " + Math.Round(kgMeat * days, 1) + "кг " + "Необходимо бананов: " + Math.Round(kgBanans * days / 1) + "кг");
    }
}




// int amount = Convert.ToInt32(Console.ReadLine());

//Animal bear = new Animal();

//Animal bear("Медведь","Мясо");

//Animal = Animal.Animal("bear", "monkey", "lion");