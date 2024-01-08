// abstraction
abstract class Transport
{
    public string name { get; set; }
    public int year { get; set; }
    public int maxSpeed { get; set; }
    public bool isEngined { get; set; }

    public abstract void forwardDrive();
    public abstract void reverseDrive();
}

// inheritance
class Car : Transport
{

    private int mileage = 0;
    public int Milliage
    {
        get { return mileage; }
        set { mileage = value; }
    }
    public Car()
    {
        isEngined = true;
    }

    public override void forwardDrive()
    {
        Console.WriteLine($"{name} moves forward");
    }
    public override void reverseDrive()
    {
        Console.WriteLine($"{name} moves backward");
    }

}

// inheritance
class Bike : Transport
{
    public Bike()
    {
        isEngined = false;
    }

    public override void forwardDrive()
    {
        Console.WriteLine($"{name} moves forward");
    }
    public override void reverseDrive()
    {
        Console.WriteLine($"Bikes do not move backward");
    }

}

class Program
{
    static void Main()
    {
        Car car = new Car();
        car.name = "Aston Martin";
        Console.WriteLine($"{car.name} has an engine: {car.isEngined}");
        car.forwardDrive();
        car.reverseDrive();

        Console.WriteLine();

        Bike bike = new Bike();
        bike.name = "test";
        Console.WriteLine($"{bike.name} has an engine: {bike.isEngined}");
        bike.forwardDrive();
        bike.reverseDrive();
    }

}