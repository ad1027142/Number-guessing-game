// make int for guess
int guess = 0;
int count = 0;
int randy = 0;
Random rand = new Random();
// output difficulty options
Console.WriteLine("Choose a difficulty: ");
Console.WriteLine("1: 1-10 ");
Console.WriteLine("2: 1-50");
Console.WriteLine("3: 1-100");
Console.WriteLine("");
// input decision of difficulty, stored as variable
Console.Write(">> ");
string diff = Console.ReadLine() + "";
// switch for difficulty
switch (diff)
{
    case "1":
        {
            randy = rand.Next(1, 10);
            break;
        }
    case "2":
        {
            randy = rand.Next(1, 50);
            break;
        }
    case "3":
        {
            randy = rand.Next(1, 100);
            break;
        }
    default:
        Console.WriteLine($"{diff} is not an option");
        break;
}
// input their number
// do while guess isn't correct
// if guess is higher, tell them lower, if lower, tell higher, if correct, tell win
do
{
    Console.WriteLine("Guess a number: ");
    Console.WriteLine("");
    Console.Write(">> ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess > randy)
    {
        Console.WriteLine("Guess Lower.");
    }
    if (guess < randy)
    {
        Console.WriteLine("Guess Higher.");
    }
    // adds one to te count counter
    count++;
} while (!(guess == randy));
Console.WriteLine("Your guess is right!");
Console.WriteLine($"It took {count} guesses");