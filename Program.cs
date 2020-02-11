using System;

namespace rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      //As a user, I should see a welcome message.
      Console.WriteLine("welcome to a fun game of rock, paper, scissors!");
      Console.WriteLine("Prepare to LOSE to a computer!");
      //As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
      Console.WriteLine("Rock, Paper, Scissors, SHOOT!");
      Console.WriteLine("Please choose rock, paper or scissors.");
      var userRPS = Console.ReadLine().ToLower();
      if (userRPS != "rock" && userRPS != "paper" && userRPS != "scissors")
      {
        Console.WriteLine("That is not an option, try the game again!");
      }
      else
      {
        //The computer should randomly decide one of the options.
        Random rnd = new Random();
        string[] randomRPS = { "rock", "paper", "scissors" };
        var randomRPSIndex = rnd.Next(randomRPS.Length);
        // You program should then decide who the winner is;
        //if user chooses rock
        if (userRPS == "rock")
          if (randomRPS[randomRPSIndex] == "rock")
          {
            Console.WriteLine("Tie!");
          }
          else if (randomRPS[randomRPSIndex] == "paper")
          {
            Console.WriteLine("you LOSE!");
          }
          else if (randomRPS[randomRPSIndex] == "scissors")
          {
            Console.WriteLine("you WIN!");
          }
        //if user chooses paper
        if (userRPS == "paper")
          if (randomRPS[randomRPSIndex] == "paper")
          {
            Console.WriteLine("Tie!");
          }
          else if (randomRPS[randomRPSIndex] == "scissors")
          {
            Console.WriteLine("you LOSE!");
          }
          else if (randomRPS[randomRPSIndex] == "rock")
          {
            Console.WriteLine("you WIN!");
          }
        //if user chooses scissors
        if (userRPS == "scissors")
          if (randomRPS[randomRPSIndex] == "scissors")
          {
            Console.WriteLine("Tie!");
          }
          else if (randomRPS[randomRPSIndex] == "rock")
          {
            Console.WriteLine("you LOSE!");
          }
          else if (randomRPS[randomRPSIndex] == "paper")
          {
            Console.WriteLine("you WIN!");
          }




        // The user should then see the randomly selected option, as well as a win or lose message.
        Console.WriteLine("you chose " + userRPS);
        Console.WriteLine("I chose " + randomRPS[randomRPSIndex]);
        //add some validation around user input.
      }
    }
  }
}
