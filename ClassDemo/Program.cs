namespace ClassDemo;

class Staff
{
    private string nameofStaff;
    private const int hourlyRate = 30;
    private int hWorked;

    public Staff(string name)
    {
        nameofStaff = name;
        Console.WriteLine("\n" + nameofStaff);
        Console.WriteLine("---------------------------------");
    }

    public Staff(string firstName, string lastName)
    {
        nameofStaff = firstName + lastName;
        Console.WriteLine("\n" + nameofStaff);
        Console.WriteLine("---------------------------------");
    }

    public int HoursWorked{
        get
        {
            return hWorked;
        }
        set
        {
            if (value > 0)
            {
                hWorked = value;
            } else
            {
                hWorked = 0;
            }
        }
    }

    public void PrintMessage(){
        Console.WriteLine("Calculating Pay...");
    }

    public int CalculatePay()
    {
        PrintMessage();

        // int staffPay;

        int staffPay = hWorked * hourlyRate;

        if (hWorked > 0)
            return staffPay;
        else
            return 0;
    }

    public int CalculatePay(int bonus, int allowance)
    {
        PrintMessage();

        if (hWorked > 0)
        {
            return hWorked * hourlyRate + bonus + allowance;
        } else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return "Name of Staff = " + nameofStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
    }


    
}

class MethodDemo
{
    public void PassByValue(int a)
    {
    a = 10;
    Console.WriteLine("a inside method = {0}", a);
    }
    public void PassByReference(int[] b)
    {
    b[0] = 5;
    Console.WriteLine("b[0] inside method = {0}", b[0]);
    }
}

class Member
{
    protected int annualFee;
    private string name;
    private int memberID;
    private int memberSince;

    public override string ToString()
    {
    return "\nName: " + name + "\nMember ID: " + memberID +
    "\nMember Since: " + memberSince + "\nTotal Annual Fee: " +
    annualFee;
    }

    public Member()
    {
    Console.WriteLine("Parent Constructor with no parameter");
    }
    public Member(string pName, int pMemberID, int pMemberSince)
    {
    Console.WriteLine("Parent Constructor with 3 parameters");
    name = pName;
    memberID = pMemberID;
    memberSince = pMemberSince;
    }
}

class NormalMember : Member
{
    
}

enum DaysOfWeek
{
    Sun, Mon, Tues, Wed, Thurs, Fri, Sat
}

class AnotherClass
{
    public int number;
}
struct MyStruct
{
    private int x, y;
    private AnotherClass myClass;
    private Days myDays;

    public MyStruct(int a, int b, int c)
    {
        myClass = new AnotherClass();
        myClass.number = a;

        x = b;
        y = c;
        myDays = Days.Mon;
    }

    public void PrintStatement()
    {
        Console.WriteLine("x = {0}, y = {1}, myDays= {2}", x, y, myDays);
    }
}

enum Days
{
    Mon, Tues, Wed
}

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Staff staff1 = new Staff("Peter");
        // staff1.HoursWorked = 160;
        // int pay = staff1.CalculatePay(1000, 400);
        // Console.WriteLine("Pay = {0}", pay);

        // int a = 2;
        // int[] b = { 1, 2, 3 };
        // MethodDemo obj = new MethodDemo();
        // Console.WriteLine("a before = {0}", a);
        // obj.PassByValue(a);
        // Console.WriteLine("a after = {0}", a);
        // Console.WriteLine("\n\n");
        // Console.WriteLine("b[0] before = {0}", b[0]);
        // obj.PassByReference(b);
        // Console.WriteLine("b[0] after = {0}", b[0]);
        MyStruct example = new MyStruct(2,3,5);
        example.PrintStatement();

    }
}
