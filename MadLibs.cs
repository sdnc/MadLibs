using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program takes user input where each word is part of a certain word group and uses those word inputs to create a story.
      Author: SDNC
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Prepare to hear a story like you've never heard before!");


      // Mad Lib story title:
      string title = "Just a regular Saturday";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.Write("Enter a name: ");
      string mainCharacter = Console.ReadLine();

      Console.WriteLine("Now, give me three adjectives. Write one adjective, press enter, then repeat till you have three.");
      string adjective1 = Console.ReadLine();
      string adjective2 = Console.ReadLine();
      string adjective3 = Console.ReadLine();

      Console.Write("Enter one verb: ");
      string verb = Console.ReadLine();

      Console.WriteLine("Now, I need two nouns. Write one noun, press enter, then repeat.");
      string noun1 = Console.ReadLine();
      string noun2 = Console.ReadLine();

      Console.Write("Pick an animal: ");
      string animal = Console.ReadLine();

      Console.Write("What food is on your mind?: ");
      string food = Console.ReadLine();

      Console.Write("A fruit, please: ");
      string fruit = Console.ReadLine();

      Console.Write("Insert Superhero here: ");
      string superHero = Console.ReadLine();

      Console.Write("Choose a country: ");
      string country = Console.ReadLine();

      Console.Write("Give me a yummy dessert: ");
      string dessert = Console.ReadLine();

      Console.Write("Pick a year: ");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {mainCharacter} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {mainCharacter} texted {superHero}, who flew {mainCharacter} to {country} and dropped {mainCharacter} in a puddle of frozen {dessert}. {mainCharacter} woke up in the year {year}, in a world where {noun2}s ruled the world.";

      Console.WriteLine(story);

    }
  }
}
