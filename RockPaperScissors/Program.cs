using RockPaperScissors;

HumanPlayer human = new HumanPlayer();
Console.WriteLine("what is your name");

try
{
    human.PlayerName = Console.ReadLine();
}
catch (Exception)
{

    human.PlayerName = "Generic Name";
}
int numberOfWins = 0;
int numberOfLosses = 0;
int numberOfTies = 0;
bool playAgain = true;
Roshambo opponentRosham = Roshambo.Rock;
while (playAgain == true)
{


    Console.WriteLine("Please pick an opponent. (Rock or Random) any incorrect choice will select rock opponent");

    string opponentChoice = Console.ReadLine();
    if (opponentChoice.ToLower() == "random")
    {
        RandomPlayer randomPlayer = new RandomPlayer();
        opponentRosham = randomPlayer.GenerateRoshambo();
        Console.WriteLine("You have selected Random as your opponent");
    }
    else
    {
        RockPlayer rockPlayer = new RockPlayer();
        opponentRosham = rockPlayer.GenerateRoshambo();
        Console.WriteLine("You have selected Rock as your opponent");
    }



    Console.WriteLine("pick rock/paper/scissors please");

    human.RoshamValue = human.GenerateRoshambo();
    

    

    CalculateWinner();
    PrintScore();
    Console.WriteLine("would you like to play again? (y?)");

    if (Console.ReadLine().ToLower() != "y")
    {
        playAgain = false;
    }
}
Console.WriteLine($"thanks for playing {human.PlayerName}");
















void CalculateWinner()
{
    if (human.RoshamValue == opponentRosham)
    {
        numberOfTies++;
        OpponentChoicePrint();
        Console.WriteLine($"you have both picked {human.RoshamValue} and tied your opponent");

    }
    else if (human.RoshamValue == Roshambo.Rock && opponentRosham == Roshambo.Scissors)
    {
        numberOfWins++;
        OpponentChoicePrint();
        Console.WriteLine("you have beat your opponent");

    }
    else if (human.RoshamValue == Roshambo.Rock && opponentRosham == Roshambo.Paper)
    {
        numberOfLosses++;
        OpponentChoicePrint();
        Console.WriteLine("your opponent has beat you");

    }
    else if (human.RoshamValue == Roshambo.Paper && opponentRosham == Roshambo.Rock)
    {
        numberOfWins++;
        OpponentChoicePrint();
        Console.WriteLine("you have beat your opponent");

    }
    else if (human.RoshamValue == Roshambo.Paper && opponentRosham == Roshambo.Scissors)
    {
        numberOfLosses++;
        OpponentChoicePrint();
        Console.WriteLine("your opponent has beat you");

    }
    else if (human.RoshamValue == Roshambo.Scissors && opponentRosham == Roshambo.Paper)
    {
        numberOfWins++;
        OpponentChoicePrint();
        Console.WriteLine("you have beat your opponent");

    }
    else if (human.RoshamValue == Roshambo.Scissors && opponentRosham == Roshambo.Rock)
    {
        numberOfLosses++;
        OpponentChoicePrint();
        Console.WriteLine("your opponent has beat you");

    }
}


void OpponentChoicePrint()
{
    Console.WriteLine($"your opponent has chosen {opponentRosham}");
}


void PrintScore()
{
    Console.WriteLine($"you have {numberOfWins} Wins, {numberOfTies} Ties, and {numberOfLosses} Losses");
}