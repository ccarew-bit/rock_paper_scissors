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
      //Create a way for the user to choose a level of difficulty, normal, impossible, or easy.
      Console.WriteLine("please choose a mode: normal, impossible, or easy!");
      var mode = Console.ReadLine().ToLower();
      if (mode != "normal" && mode != "impossible" && mode != "easy")
      {
        Console.WriteLine("that is not an option, try the game again!");
      }
      else
      {
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
          if (mode == "normal")
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
          else if (mode == "impossible")
          {
            // You program should then decide who the winner is;
            //if user chooses rock
            if (userRPS == "rock")
            {
              Console.WriteLine("you LOSE!");
              Console.WriteLine("You Chose " + userRPS);
              Console.WriteLine("I chose paper!");
            }
            //if user chooses paper
            if (userRPS == "paper")
            {
              Console.WriteLine("you LOSE!");
              Console.WriteLine("You Chose " + userRPS);
              Console.WriteLine("I chose scissors!");
            }
            //if user chooses scissors
            if (userRPS == "scissors")
            {
              Console.WriteLine("you LOSE!");
              Console.WriteLine("You Chose " + userRPS);
              Console.WriteLine("I chose rock!");
            }
          }
          else if (mode == "easy")
          {
            // You program should then decide who the winner is;
            //if user chooses rock
            if (userRPS == "rock")
            {
              Console.WriteLine("you WIN!");
              Console.WriteLine("You Chose " + userRPS);
              Console.WriteLine("I chose Scissors!");
            }
            //if user chooses paper
            if (userRPS == "paper")
            {
              Console.WriteLine("you WIN!");
              Console.WriteLine("You Chose " + userRPS);
              Console.WriteLine("I chose Rock!");
            }
            //if user chooses scissors
            if (userRPS == "scissors")
            {
              Console.WriteLine("you WIN!");
              Console.WriteLine("You Chose " + userRPS);
              Console.WriteLine("I chose paper!");
            }
          }
        }
      }
    }
  }
}
