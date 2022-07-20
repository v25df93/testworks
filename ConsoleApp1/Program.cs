using System;
public class Animal
{
    private string name;
    private int calories;
    private int amount;
    public int days;

    private int banana = 1200;
    private int meat = 2600;

    public Animal()
    {
        this.name = "0";
        this.calories = 0;
        this.amount = 0;
    }

    public Animal (string name, int calories, int amount)
    {
        this.name = name;
        this.calories = calories;
        this.amount = amount;
    }

    public string getNameAnimal()
    {
        return name;
    }

    public int getCaloriesPerMonth()
    {
        return (calories*amount*days)/meat;  

    }
    public int getAmountAnimal()
    {
        return amount;
    }
    public int getCaloriesAnimal()
    {
        return calories;
    }

    //public int getCaloriesLion()
    //{
        
    //}


};

class testanimal
{
    //static void addNewAnimal(List<Animal> theAnimals)
    //{
    //    bool flag = false;
    //    Console.WriteLine("Введите название животного");
    //    string name = Console.ReadLine();
    //    Console.WriteLine("Введите количество калорий в день для животного");
    //    int calories = Convert.ToInt16(Console.ReadLine());
    //    Console.WriteLine("Введите количество животных");
    //    int amount = Convert.ToInt16(Console.ReadLine());
        
    //    foreach (Animal theAnimal in theAnimals)
    //    {
    //        if (theAnimal.getNameAnimal() == name)
    //            flag = true;
    //    }
    //    if (flag)
    //        Console.WriteLine("Животное уже добавлено");
    //    else
    //    {
    //        theAnimals.Add(new Animal(name, calories, amount));
    //        Console.WriteLine("Животное уже добавлено");
    //    }
    //}
    static void Main()
    {
        int banana = 1200, meat = 2600;
        int amount;
        var theAnimals = new List<Animal>();

        string month;
        int days = 31;
        Console.WriteLine("Введите месяц");
        month = Console.ReadLine();
         switch (month)
      {
        case "Январь":
        case "Март":
        case "Май":
        case "Июль":
        case "Август":
        case "Октябрь":
        case "Декабрь":
          Console.WriteLine("Количество дней = " + days);
          break;
        case "Февраль":
                days = 28;
          Console.WriteLine("Количество дней = 28");
          break;
        case "Апрель":
        case "Июнь":
        case "Сентябрь":
        case "Ноябрь":
                days = 30;
                Console.WriteLine("Количество дней = 30");
          break;
        default:
          Console.WriteLine("Неправильный ввод");
          break;
      }


        Console.WriteLine("Введите количество медведей");
        amount = Convert.ToInt16(Console.ReadLine());
        theAnimals.Add(new Animal("Медведь", 15000, amount));

        Console.WriteLine("Введите количество львов");
        amount = Convert.ToInt16(Console.ReadLine());
        theAnimals.Add(new Animal("Лев", 10000, amount));

        Console.WriteLine("Введите количество обезьян");
        amount = Convert.ToInt16(Console.ReadLine());
        theAnimals.Add(new Animal("Обезьяна", 1000, amount));
    
        foreach (Animal theAnimal in theAnimals)
        {
            Console.WriteLine(theAnimal.getCaloriesPerMonth());
        }
    }
}




// int amount = Convert.ToInt32(Console.ReadLine());

//Animal bear = new Animal();

//Animal bear("Медведь","Мясо");

//Animal = Animal.Animal("bear", "monkey", "lion");



