Random rng = new Random();
int rand = rng.Next(1, 101); 
int guess = 0;
int P_turns = 0;
bool start1 = false;
Console.WriteLine("To start enter !");
while(!start1) {
    string start2 = Console.ReadLine();
    if (start2 == "!"){
        start1 = true;    
    } 
}while (start1) {
    P_turns++;
    if (P_turns == 0) {
        Console.WriteLine("Guess the right number between 1 and 100 to win.");
    }
    Console.Write("Guess" + P_turns + ": ");
    guess = Convert.ToInt32(Console.ReadLine());
    if (guess == rand) {
        Console.WriteLine("You win!!!");
        Console.WriteLine("It took " + P_turns + " turns for you to get it.");
        start1 = false;
    } 
    /*else if (guess == 111) {
        Console.WriteLine(rand);
    }*/ 
    else if (guess < rand) {
        Console.WriteLine("Your number is to small.");
        Console.WriteLine("Try again:");
    } else if (guess > rand) {
        Console.WriteLine("Your number is to high.");
        Console.WriteLine("Try again:");
    }
}
