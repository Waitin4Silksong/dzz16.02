Console.OutputEncoding = System.Text.Encoding.UTF8;

Car car = new Car("Audi A5", 280767, "Dark-blue", "Private car");
Plane plane = new Plane("Boeing 747", 93785, "White", "Commercial plane");
Motorcycle bike = new Motorcycle("Kawasaki Z750", 4828442, "Green", "Private motorcycle");

car.start();
plane.start();
plane.stop();
plane.refuel();
bike.info();
public abstract class Transport
{
    public string model;
    public int id;
    public string color;
    public string descrip;

    public abstract void start();
    public abstract void stop();
    public abstract void refuel();
    public void info()
    {
        Console.WriteLine($"Model: {model}\nID: {id}\nColor: {color}\nDescription: {descrip}");
    }
}

public class Car : Transport
{
    public override void start()
    {
        Console.WriteLine("Car started moving");
    }
    public override void stop()
    {
        Console.WriteLine("Car stopped");
    }
    public override void refuel()
    {
        Console.WriteLine("Car has been refueled");
    }

    public Car(string model, int id, string color, string descrip)
    {
        this.model = model;
        this.id = id;
        this.color = color;
        this.descrip = descrip;
    }
}

public class Plane : Transport
{
    public override void start()
    {
        Console.WriteLine("Plane tooked off");
    }
    public override void stop()
    {
        Console.WriteLine("Plane landed");
    }
    public override void refuel()
    {
        Console.WriteLine("Plane has been refueled");
    }

    public Plane(string model, int id, string color, string descrip)
    {
        this.model = model;
        this.id = id;
        this.color = color;
        this.descrip = descrip;
    }
}

public class Motorcycle : Transport
{
    public override void start()
    {
        Console.WriteLine("Motorcycle started moving");
    }
    public override void stop()
    {
        Console.WriteLine("Motorcycle stopped");
    }
    public override void refuel()
    {
        Console.WriteLine("Motorcycle has been refueled");
    }

    public Motorcycle(string model, int id, string color, string descrip)
    {
        this.model = model;
        this.id = id;
        this.color = color;
        this.descrip = descrip;
    }
}