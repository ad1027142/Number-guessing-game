// make int for guess
int guess = 0;
int count = 0;
int randy = 0;
bool play = true;
string plays = "y";
string diff = "0";
Random rand = new Random();
do
{
    while (!(diff == "1" || diff == "2" || diff == "3"))
    {
       // output difficulty options
        Console.WriteLine("Choose a difficulty: ");
        Console.WriteLine("1: 1-10 ");
        Console.WriteLine("2: 1-50");
        Console.WriteLine("3: 1-100");
        Console.WriteLine("");
        // input decision of difficulty, stored as variable
        Console.Write(">> ");
        diff = Console.ReadLine() + "";
        // switch for difficulty
        switch (diff)
        {
            case "1":
                {
                    // Add one more to the max, since it is exclusive
                    randy = rand.Next(1, 11);
                    break;
                }
            case "2":
                {
                    randy = rand.Next(1, 51);
                    break;
                }
            case "3":
                {
                    randy = rand.Next(1, 101);
                    break;
                }
            default:
                Console.WriteLine($"{diff} is not an option");
                break;
        }
        // input their number
        // do while guess isn't correct
        // if guess is higher, tell them lower, if lower, tell higher, if correct, tell win 
    }
    Console.WriteLine("Guess a number: ");
    Console.WriteLine("");
    Console.Write(">> ");
    guess = Convert.ToInt32(Console.ReadLine());
    count++;
    if (guess > randy)
    {
        Console.WriteLine("Guess Lower.");
    }
    if (guess < randy)
    {
        Console.WriteLine("Guess Higher.");
    }
    if (guess == randy)
    {
        Console.WriteLine("Your guess is right!");
        Console.WriteLine($"It took {count} guesses");
        Console.WriteLine("Would you like to play again? Y/N");
        Console.WriteLine();
        Console.Write(">> ");
        plays = Console.ReadLine() + "";
        plays = plays.ToLower();
        switch (plays)
        {
            case ("y"):
                play = true;
                count = 0;
                diff = "0";
                break;
            case ("n"):
                Console.WriteLine("Bye");
                play = false;
                break;
        }
    }
    // adds one to the count counter
} while ((play == true));
