// using static System.Console;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// int numby = Convert.ToInt32(Console.ReadLine());

// WriteLine("number printed is: " + numby);



// int [] numbers = {12, 1, 5, -2, 16, 14};

// Array.Sort(numbers);

// foreach (int num in numbers)
// {
//     WriteLine(num);
// }

// WriteLine( 11 <= 7);

// int userAge;
// Console.Write("Please enter your age: ");
// int userAge = Convert.ToInt32(Console.ReadLine());
// if (userAge < 0 || userAge > 100)
// {
// Console.WriteLine("Invalid Age");
// Console.WriteLine("Age must be between 0 and 100");
// }
// else if (userAge < 18)
// Console.WriteLine("Sorry you are underage");
// else if (userAge < 21)
// Console.WriteLine("You need parental consent");
// else
// {
// Console.WriteLine("Congratulations!");
// Console.WriteLine("You may sign up for the event!");
// }

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

// MyStruct example = new MyStruct(2,3,5);


class Test
{
    string testName;
    public Test(string name){
        testName = name;
    }

    public override string ToString()
    {
        return testName;
    }
}

Test myTest = new Test("sometest");

Console.WriteLine(myTest)