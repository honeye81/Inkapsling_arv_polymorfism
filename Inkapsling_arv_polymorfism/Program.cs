using Inkapsling_arv_polymorfism;
using System;

class Program
{
    static void Main(string[] args)
    {


        //
        try
        {
            PersonHandler handler = new PersonHandler();

            
            Person person1 = handler.CreatePerson(25, "Hanieh", "Fathali", 1.70, 71);

            handler.SetAge(person1, 42);

            Console.WriteLine($"Name: {person1.FName} {person1.LName}, Age: {person1.Age}, Height: {person1.Height}, Weight: {person1.Weight}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }


        //Polymorfism
        List<UserError> errorList = new List<UserError>
        {
            new NumericInputError(),
            new TextInputError(),
        };

        // Loop through the list and print out error messages
        foreach (var error in errorList)
        {
            Console.WriteLine(error.UEMessage());
        }



        //Inheritance:
        List<Animal> animals = new List<Animal>
        {
            new Dog("Rex", 30, 5, "German Shepherd"),
            new Swan("Pete", 15, 10, 2.5),
            new Wolfman("Wolfy", 70, 35)
        };

        // Print animal stats and sounds
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Stats());
            animal.DoSound();

            // Check if the animal is also an IPerson
            if (animal is IPerson person)
            {
                person.Talk();
            }
        }

    }
}