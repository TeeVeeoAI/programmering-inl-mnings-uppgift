bool Inf_game = true;
int wins = 0;
Console.Clear();
while (Inf_game) {
    Random rng = new Random();
    int rand = rng.Next(1, 101); 
    int guess = 0;
    int P_turns = 0;
    bool start = false;
    int smallest = 1;
    int biggest = 100;
    if (wins == 0) {
        Console.WriteLine("To start enter ! and ? to end");
    } else if (wins > 0) {
        Console.WriteLine("To start again enter ! and ? to end");
        Console.WriteLine("You have won " + wins + " times");
    }
    while (!start) {
        string startup = Console.ReadLine();
        if (startup == "!"){
            start = true;    
            Console.Clear();
        } if(startup == "?") {
            Inf_game = false;
            break;
        } 
    } while (start) {
        if (P_turns == 0 && wins == 0) {
            Console.WriteLine("Guess the right number between 1 and 100 to win.");
        }
        P_turns++;
        if (P_turns > 1) {
            Console.WriteLine("Your number is between " + smallest + " and the " + biggest);
        }
        Console.Write("Guess " + P_turns + ": ");
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess == rand) {
            Console.Clear();
            Console.WriteLine("You win!!!");
            Console.WriteLine();
            Console.WriteLine("It took " + P_turns + " turns for you to get it.");
            Console.WriteLine();
            wins++;
            start = false;
        } 
        /*else if (guess == 111) {
            Console.WriteLine(rand);
        }*/ 
        else if (guess < rand) {
            Console.Clear();
            Console.WriteLine("Your number is to small.");
            Console.WriteLine();
            Console.WriteLine("Try again");
            Console.WriteLine();
            if (guess > smallest) {
                smallest = guess;
            }
        } else if (guess > rand) {
            Console.Clear();
            Console.WriteLine("Your number is to high.");
            Console.WriteLine();
            Console.WriteLine("Try again");
            Console.WriteLine();
            if (guess < biggest) {
                biggest = guess;
            }
        }
    }
}