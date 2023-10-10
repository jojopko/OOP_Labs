using System;

public enum Gender { Male, Female }

public class Parent
{
    public string FirstName { get; set; }
    public string Patronymic { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }

    public Parent(string firstName, string patronymic, string lastName, Gender gender)
    {
        FirstName = firstName;
        Patronymic = patronymic;
        LastName = lastName;
        Gender = gender;
    }

    public virtual void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {Patronymic} {LastName}");
    }
}

public class Child : Parent
{
    public Child(string firstName, Gender gender, Parent parent) : base(firstName, parent.Patronymic, parent.LastName, parent.Gender)
    {
        if (gender == Gender.Male)
        {
            Patronymic = parent.FirstName + "ovich";
        }
        else
        {
            Patronymic = parent.FirstName + "ovna";
        }
    }

    public override void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {Patronymic} {LastName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Parent parent = new Parent("Ivan", "Ivanovich", "Ivanov", Gender.Male);
        parent.PrintFullName();

        Child child1 = new Child("Anna", Gender.Female, parent);
        Child child2 = new Child("Dmitry", Gender.Male, parent);
        child1.PrintFullName();
        child2.PrintFullName();
    }
}

