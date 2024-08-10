start:
Console.WriteLine("Welcome to the rock paper scissors game please select an option");

var options = new List<string> { "1. play against computer", "2. play against friend", "3. exit" };

Console.WriteLine("Options:");
foreach (var option in options)
    Console.WriteLine(option);

int gameMode;
Console.Write("Your choice: ");
var playMode = Console.ReadLine();
gameMode =
    Convert.ToInt32(playMode);
try
{
    switch (gameMode)
    {
        case 1:
            Console.WriteLine("Play against computer");
            break;
        case 2:
            Console.WriteLine("Play against friend");
            break;
        case 3:
            Console.WriteLine("Exit");
            return;
        default:
            throw new Exception("Invalid Option. Please enter a valid option.");
    }
}
catch (FormatException e)
{
    Console.WriteLine(e);
    goto start;
}


int rounds;
while (true)
{
    Console.WriteLine("What score would you like the game to end at? Enter a number between 1 and 30:");
    try
    {
        rounds = Convert.ToInt32(Console.ReadLine());
        if (rounds < 1 || rounds > 30)
            Console.WriteLine("Number of rounds must be between 1 and 30. Please try again.");
        else

            break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a numeric value.");
        goto start;
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

switch (gameMode)
{
    case 1 :
        PlayComputer(rounds);
        break;
    
    case 2 :
        PlayFriend(rounds);
        break;
}

static void PlayComputer(int rounds)
{
    int playerScore = 0, computerScore = 0;
    Random random = new Random();
    int round = 1;
    while (true)
    {
        Console.WriteLine("Round " + (round));
        Console.WriteLine("Enter your choice (Rock, Paper, Scissors)");
        string playerChoice = Console.ReadLine().ToLower();
        string computerChoice = ((Choice)random.Next(0, 3)).ToString().ToLower();
        Console.WriteLine("Computer chose:"+ computerChoice);
        if (playerChoice == computerChoice)
        {
            Console.WriteLine("It is a tie!");
            
        }
        else if ((playerChoice == "paper" && computerChoice == "rock") || 
                 (playerChoice == "rock" && computerChoice == "scissors" )||
                 (playerChoice == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("Player win this round!");
            playerScore++;

        }
        else
        {
            Console.WriteLine("Computer win this round!");
            computerScore++;

        }
        Console.WriteLine("Round " +round+ " Score: Player- "+ playerScore + " Computer- "+ computerScore);
        round++;
        if (playerScore == rounds || computerScore == rounds )
        {
            break;
        }
        
    }
    Console.WriteLine("Final Score: Player- "+ playerScore + " Computer- "+ computerScore);
    if (playerScore > computerScore)
    {
        Console.WriteLine("Player win this game!");
    }
    else if (playerScore < computerScore)
    {
        Console.WriteLine("Computer win this game");
    }
}

static void PlayFriend(int rounds)
{
    int player1Score = 0, Player2Score = 0;
    int round = 1;
    while (true)
    {
        Console.WriteLine("Round " + (round));
        Console.WriteLine("Enter your choice player 1 (Rock, Paper, Scissors)");
        string player1Choice = Console.ReadLine().ToLower();
        Console.WriteLine("Enter your choice player 2 (Rock, Paper, Scissors)");
        string player2Choice = Console.ReadLine().ToLower();
        if (player1Choice == player2Choice)
        {
            Console.WriteLine("It is a tie!");
            
        }
        else if ((player1Choice == "paper" && player2Choice == "rock") || 
                 (player1Choice == "rock" && player2Choice == "scissors" )||
                 (player1Choice == "scissors" && player2Choice == "paper"))
        {
            Console.WriteLine("Player 1 win this round!");
            player1Score++;

        }
        else
        {
            Console.WriteLine("Player 2 win this round!");
            Player2Score++;

        }
        Console.WriteLine("Round " +round+ " Score: Player 1- "+ player1Score + " Player 2- " +Player2Score);
        round++;
        if (player1Score == rounds || Player2Score == rounds )
        {
            break;
        }
        
    }
    Console.WriteLine("Final Score: Player 1- " + player1Score + " Player 2- " + Player2Score);
    if (player1Score > Player2Score)
    {
        Console.WriteLine("Player 1 win this game!");
    }
    else if (player1Score < Player2Score)
    {
        Console.WriteLine("Player 2 win this game");
    }
}
internal enum Choice
{
    Rock,
    Paper,
    Scissors
}
