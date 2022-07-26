public class Animal  //само животное
{
    protected string name;
    protected int calories;
    protected int amount;

    public Animal()  //имеет имя калории и количество
    {
        this.name = "0";
        this.calories = 0;
        this.amount = 0;

    }

    public Animal(string name, int calories, int amount) //привязка переменных
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;


    }
    public string getNameAnimal() //возврат имени животного
    {
        return name;
    }

    public int getAmountAnimal() //возврат количества животного
    {
        return amount;
    }
    public int getCaloriesAnimal() //возврат требуемых калорий животного
    {
        return calories;
    }

};
class Plant : Animal  //травоядное
{

    float kgOfFood;
    int caloriesInBanana = 960;
    public Plant(string name, int calories, int amount) //учет килограм еды для травоядного
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
        kgOfFood = (float)amount * calories / caloriesInBanana;
    }

    public float getBananas()  //возврат килограм еды для травоядного
    {
        return kgOfFood;
    }
}
class Meat : Animal        //мясоед
{
    float kgOfFood;
    int caloriesInMeat = 3180;
    public Meat(string name, int calories, int amount)  //учет килограм еды для мясоеда
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
        kgOfFood = (float)amount * calories / caloriesInMeat;
    }


    public float getMeat()  //возврат килограм еды сколько нужно мясоеду
    {
        return kgOfFood;
    }
}
class meatPlant : Animal  //всеядные
{
    private float kgOfMeat;
    private float kgOfBananas;
    private int caloriesInMeat = 3180;
    private int caloriesInBananas = 960;

    public meatPlant(string name, int calories, int amount)    //учет сколько килограммов еды нужно всеядному
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
        kgOfMeat = (float)amount * calories / (2 * caloriesInMeat);
        kgOfBananas = (float)amount * calories / (2 * caloriesInBananas);
    }

    public float getMeat()  //возврат киломяса
    {
        return kgOfMeat;
    }
    public float getBananas() //возврат килобананов
    {
        return kgOfBananas;
    }
}
class testanimal  //класс вывода
{
    static int amountofdays()   //ввод месяца
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


    static void Main()  //ввод количества животных и вывод данных
    {
        int amount;
        int days;
        float kgBanans = 0;
        float kgMeat = 0;
        var theMeats = new List<Meat>();        //мясоед
        var thePlants = new List<Plant>();      //травоядное
        var theBoth = new List<meatPlant>();    //всеядное
        days = amountofdays();


        Console.WriteLine("Введите количество медведей");
        amount = Convert.ToInt16(Console.ReadLine());
        theBoth.Add(new meatPlant("Медведь", 15000, amount));

        Console.WriteLine("Введите количество львов");
        amount = Convert.ToInt16(Console.ReadLine());
        theMeats.Add(new Meat("Лев", 10000, amount));

        Console.WriteLine("Введите количество обезьян");     //добавление нового животного сюда
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