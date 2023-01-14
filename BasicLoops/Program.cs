bool playagain = false;
do
{
    bool isValidNum;
    Console.Write("Enter a number: ");
    string number = Console.ReadLine();

    isValidNum = int.TryParse(number, out int num);

    if (!isValidNum)
    {
        Console.WriteLine("Sorry, please enter a number to proceed");
        playagain = true;
    }

    if (isValidNum)
    {
        for (int i = num; i >= 0; i--)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
        for (int i = 0; i <= num; i++)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("");
        Console.Write("Would you like to continue (y/n)? ");
        string answer = Console.ReadLine();

        //determine to loop depending on user's answer
        if (answer == "y")
        {
            playagain = true;
        }
        else if (answer == "n")
        {
            Console.WriteLine("Goodbye!");
            playagain = false;
        }
    }
} while (playagain);