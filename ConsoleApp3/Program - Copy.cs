using exp1;
using System;
using System.Reflection;

namespace Carm;

public interface IInfo
{
    void Info();

}
public interface IDriveable
{

    void Drive(double distance);
    void Stop();

}
public interface ICar : IDriveable,IInfo
{
    string Brand { get; }

    string Model { get; }

    int Year { get; }

    string Color { get; }

    decimal Price { get; set; }
}

public abstract class BaseCar : ICar
{
    private readonly string _Brand;

    private readonly string _Model;

    private readonly int _Year;

    private readonly string _Color;

    protected decimal _Price;
    public static int CountCar { get; private set; } = 0;

    public string Brand => _Brand;

    public string Model => _Model;

    public int Year => _Year;

    public string Color => _Color;

    public decimal Price
    {
        get => _Price;
        set => _Price = value;
    }

    public BaseCar(string brand, string model, int year, string color, decimal price)
    {
        _Brand = brand;
        _Model = model;
        _Year = year;
        _Color = color;
        _Price = price;
        CountCar++;
    }



    public abstract void Drive(double distance);
    public abstract void Stop();

    public virtual void Info()
    {
        Console.WriteLine("===  Card ===");
        Console.WriteLine($" Brand: {_Brand}");
        Console.WriteLine($"Model: {_Model}");
        Console.WriteLine($" Year: {_Year}");
        Console.WriteLine($"Color: {_Color}");
        Console.WriteLine($"Price: {_Price} $");
    }
}

public interface ISportsCar : ICar
{
    int MaxSpeed { get; }

}
public class SportsCar : BaseCar, ISportsCar
{
    private readonly int _MaxSpeed;

    public SportsCar(string brand, string model, int year, string color, decimal price, int maxSpeed)
        : base(brand, model, year, color, price)
    {
        _MaxSpeed = maxSpeed;
    }

    public int MaxSpeed => _MaxSpeed;

    public override void Drive(double distance)
    {
        throw new NotImplementedException();
    }

    

    public override void Stop()
    {
        throw new NotImplementedException();
    }

    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Max Speed: {_MaxSpeed} km/h");

    }



}


public  abstract class BaseCard
{
    protected BaseCard(string name, string description, object addData)
    {
        Name = name;
        Description = description;
        AddData = addData;
    }

    public string Name { get; set; }
    public string Description { get; set; }

    public object AddData { set; get; }


}
public class CardInt : BaseCard
{
    public int Id { get; set; }
 
    public CardInt(int id, string name, string description, object addData)
        : base(name, description, addData)
    {
        Id = id;
      
    }
}


public class Cardstring : BaseCard
{
    public string Id { get; set; }

    public Cardstring(string id, string name, string description, object addData)
        : base(name, description, addData)
    {
        Id = id;

    }
}

public class Card<T> : BaseCard
{
    public T Id { get; set; }
    public Card(T id, string name, string description, object addData)
        : base(name, description, addData)
    {
        Id = id;
    }


    public  TData GetDataAdd<TData>()
    {
        return (TData)AddData;
    }
}
