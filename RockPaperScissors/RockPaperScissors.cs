string rock = "Rock";
string paper = "Paper";
string scissors = "Scissors";

Console.Write("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();

if (playerMove == "r" || playerMove == "rock")
{
    playerMove = rock;
}
else if(playerMove == "p" || playerMove == "paper")
{
    playerMove = paper;
}
else if(playerMove == "s" || playerMove == "scissors")
{
    playerMove = scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);

string computerMove = "";

switch(computerRandomNumber)
{
    case 1:
        computerMove = rock;
        break;
    case 2:
        computerMove = paper;
        break;
    case 3:
        computerMove = scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");

if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper))
{
    Console.WriteLine("You win.");
}
else if((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("This game was a draw.");
}