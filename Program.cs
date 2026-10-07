
Member member = new Athlete();

member.Workout();

Func<double, string> InBodyTest = bodyFat =>
    bodyFat < 15 ? "Excellent" :
    bodyFat < 25 ? "Normal" :
    "High";

string result = InBodyTest(18);

Console.WriteLine(result);

Gym gym = new Gym(new CashPayment());

gym.Member = member;

gym.MakePayment();

public class Member
{
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private string phoneNumber;

    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    public virtual void Workout()
    {
        Console.WriteLine("Member is working out.");
    }

    public void UseGym()
    {
        Console.WriteLine("Member is using the gym.");
    }
}


public class Athlete : Member
{
    public void UsingTheMachines()
    {
        Console.WriteLine("Using the weight machine.");
    }

    public void BuyTheSupplements()
    {
        Console.WriteLine("Buying nutrition supplements.");
    }

    public void UsingThePool()
    {
        Console.WriteLine("Swimming.");
    }

    public override void Workout()
    {
        Console.WriteLine("Athlete is training hard.");
    }
}


public interface IUsable
{
    void TurnOn();
    void TurnOff();
}


public class Machines : IUsable
{
    private int lifeSpanYears;

    public int LifeSpanYears
    {
        get { return lifeSpanYears; }
        set { lifeSpanYears = value; }
    }

    public void TurnOn()
    {
        Console.WriteLine("ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("OFF");
    }
}


public class Employee
{
    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private double salary;

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public bool CheckMember(Member member)
    {
        return member.Id > 0;
    }

    public void MaintainMachines()
    {
        Console.WriteLine("Employee is maintaining machines.");
    }
}


public class Trainer
{
    public void Train(Member member)
    {
        Console.WriteLine("Trainer is training the member.");
    }

    public void GiveAdvice(Member member)
    {
        Console.WriteLine("Trainer is giving advice.");
    }
}


public interface IPayment
{
    void Pay();
}


public class CashPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment by cash.");
    }
}


public class CardPayment : IPayment
{
    public void Pay()
    {
        Console.WriteLine("Payment by card.");
    }
}


public class Gym
{
    public Member Member { get; set; }

    private IPayment payment;

    public Gym(IPayment payment)
    {
        this.payment = payment;
    }

    public void MakePayment()
    {
        payment.Pay();
    }
}


