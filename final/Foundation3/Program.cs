using System;
using System.Security.AccessControl;

class Program
{

    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Cityville", "State", "12345");
        Address address2 = new Address(" ", " ", " ", " ");
        Address address3 = new Address("The Ranch", "Loveland", "CO", "80534");


        Lecture lecture = new Lecture("AI: The Battle for the Future", "Exploring the Future of AI", new DateTime(2024, 3, 4, 12, 0, 0), address1, "Elon Musk", 500);
        Reception reception = new Reception("Trophies and Tires", "Award ceremony for profit goals", new DateTime(2024, 6, 14, 18, 30, 0), address2, "rsvp@discounttire.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Overland Expo", "Overlanding Event Series", new DateTime(2024, 8, 23, 8, 0, 0), address3);

        Console.WriteLine("===============================");
        Console.WriteLine("Lecture Details:");
        Console.WriteLine("------------------");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("------------------");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("------------------");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();


        Console.WriteLine("===============================");
        Console.WriteLine("Reception Details:");
        Console.WriteLine("------------------");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("------------------");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("------------------");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        

        Console.WriteLine("===============================");
        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine("------------------");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("------------------");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("------------------");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();

    }

}