using System;

namespace cs_day1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("hello! what is your name?");
      var name = Console.ReadLine().Trim();
      Console.WriteLine();
      Console.WriteLine($"Hello, {name}");
      while (true)
      {
        Random rnd = new Random();
        String[] choices = new String[3]{
        "rock",
        "paper",
        "sicsors"
      };
        var compChoice = rnd.Next(3);
        Console.WriteLine("Rock paper siccors?");
        var userInput = Console.ReadLine().Trim().ToLower();
        switch (userInput[0])
        {
          case 'r':
            switch (compChoice)
            {
              case 0:
                Console.WriteLine($"{name} chose Rock, computer chose {choices[compChoice]}. you and the computer tie'd.");
                break;
              case 1:
                Console.WriteLine($"{name} chose Rock, computer chose {choices[compChoice]}. the Computer Won.");
                break;
              case 2:
                Console.WriteLine($"{name} chose Rock, computer chose {choices[compChoice]}. {name} Won.");
                Console.Beep();
                break;
            }
            break;
          case 'p':
            switch (compChoice)
            {
              case 0:
                Console.WriteLine($"{name} chose Paper, computer chose {choices[compChoice]}. {name} Won.");
                Console.Beep();
                break;
              case 1:
                Console.WriteLine($"{name} chose Paper, computer chose {choices[compChoice]}. you and the computer tie'd.");
                break;
              case 2:
                Console.WriteLine($"{name} chose Paper, computer chose {choices[compChoice]}. the Computer Won.");
                break;
            }
            break;
          case 's':
            switch (compChoice)
            {
              case 0:
                Console.WriteLine($"{name} chose Sicisors, computer chose {choices[compChoice]}. the Computer Won.");
                break;
              case 1:
                Console.WriteLine($"{name} chose Sicisors, computer chose {choices[compChoice]}. {name} Won.");
                Console.Beep();
                break;
              case 2:
                Console.WriteLine($"{name} chose Sicisors, computer chose {choices[compChoice]}. you and the computer tie'd.");
                break;
            }
            break;
          default:
            Console.WriteLine("that was not a valid move");
            break;
        }


      end:
        Console.WriteLine("does {name} wish to continue? (y/n)");
        var answer = Console.ReadLine().Trim().ToLower();
        if (answer.StartsWith('n'))
        {
          break;
        }
        else if (answer.StartsWith('y'))
        {
          continue;
        }
        else
        {
          goto end;
        }
      }
    }
  }
}
