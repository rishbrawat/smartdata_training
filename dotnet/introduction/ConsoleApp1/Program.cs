using System;


/*
    .net consists of 4 separate components:
        1. common language runtime (CLR)
        2. class library
        3. application development framework
        4. languages

    the most important component of .net is the common language runtime (CLR) which is the execution engine that handles running applications. it provides services such as memory management, type safety, exception handling, garbage collection, security and thread management.

    it is a case sensitive language, meaning that it differentiates between uppercase and lowercase letters. for example, the variable name "myVariable" is different from "myvariable".

    use cases of c#
        1. web applications
        2. windows applications
        3. mobile applications
        4. games
        5. cloud based applications
        etc.

    c# is a strogly typed language, meaning that every variable and object must have a declared type. this helps catch errors at compile time rather than at runtime.


*/

public class Program
{
    // Main is in capital letters because it is a method. methods are always capitalized in C#. the Main method is the entry point of a C# console application or windows application. it is where the program starts execution.


    // static is a keyword that means the method belongs to the class itself, rather than an instance of the class. this means that you can call the Main method without creating an object of the Program class. static methods can only access other static members of the class. they cannot access instance members of the class.
    static void Main()
    {
        Console.WriteLine("Goodbye, World!");

        int x = 10;
        int y = 20;

        // implcit and explicit type conversion
        // implicit type conversion is when a value of one data type is automatically converted to another data type by the compiler. this happens when the conversion is safe and there is no risk of data loss. for example, converting an int to a long is safe because a long can hold all the values that an int can hold.
        long z = x + y; // implicit type conversion

        // explicit type conversion is when a value of one data type is explicitly converted to another data type by the programmer. this is done using a cast operator. for example, converting a long to an int is not safe because a long can hold values that an int cannot hold. therefore, the programmer must explicitly cast the long to an int.
        int a = (int)z; // explicit type conversion

        // a constant is a value that cannot be changed once it has been assigned. constants are declared using the const keyword. for example, the value of pi is a constant because it cannot be changed.
        const double pi = 3.14159;

        // emums provide a way to define a set of named integral constants that can be assigned to a variable. they are used to represent a set of related values in a more readable way. for example, you can use an enum to represent the days of the week.
        enum Temperatures{
            Cold = 0,
            FreezingPoint = 32,
            LightJacketWeather = 60,
            SwimmingWeather = 75,
            BurningHot = 100
        }
    }
}

// classes, objects and types

// a type represents a thing, sometimes the thing is abstract, such as a data table or thread, etc.

// a method is a function owned by your class. they are sometimes called member functions. methods are used to perform actions on your objects. they can also be used to return information about your objects.

// dot operator is used to access both method and properties of an object. the dot operator is also used to access static methods and properties of a class. static methods and properties are not owned by an object, they are owned by the class itself. 


// assignment
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int id { get; set; }

    Student(string name, int age, int id)
    {
        Name = name;
        Age = age;
        this.id = id;
    }
}

// employee class
public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int id { get; set; }

    Employee(string name, int age, int id)
    {
        Name = name;
        Age = age;
        this.id = id;
    }
}

// bank account class
public class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    BankAccount(string accountNumber, string accountHolderName, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolderName = accountHolderName;
        Balance = balance;
    }
}

// calculator class
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return (double)a / b;
    }
}

// student grade analysis
public class StudentGradeAnalysis
{
    public string StudentName { get; set; }
    public int[] Grades { get; set; }

    StudentGradeAnalysis(string studentName, int[] grades)
    {
        StudentName = studentName;
        Grades = grades;
    }

    public double CalculateAverage()
    {
        if (Grades.Length == 0)
        {
            throw new InvalidOperationException("No grades available to calculate average.");
        }
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Length;
    }

    public string GetLetterGrade()
    {
        double average = CalculateAverage();
        if (average >= 90)
            return "A";
        else if (average >= 80)
            return "B";
        else if (average >= 70)
            return "C";
        else if (average >= 60)
            return "D";
        else
            return "F";
    }
}