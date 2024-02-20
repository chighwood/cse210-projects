using System;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Cityville", "State", "12345");
        Address address2 = new Address(" ", " ", " ", " ");
        Address address3 = new Address("The Ranch", "Loveland", "CO", "80534");


        Event lecture = new Lecture("AI: The Battle for the Future", "Exploring the Future of AI", new DateTime(2024, 3, 4), new DateTime(12, 0, 0), address1, "Elon Musk", 500);
        Event reception = new Reception("Trophies and Tires", "Award ceremony for profit goals", new DateTime(2024, 6, 14), new DateTime(16, 0, 0), address2, "rsvp@discounttire.com");
        Event outdoorGathering = new OutdoorGathering("Overland Expo", "Overlanding Event Series", new DateTime(2024, 8, 23-25), new DateTime(24, 0, 0), address3);


        Console.WriteLine("Lecture Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();


        Console.WriteLine("Reception Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();
        

        Console.WriteLine("Outdoor Gathering Details:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();

    }
}