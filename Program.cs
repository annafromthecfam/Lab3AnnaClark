// While loop
while (true)
{
    Console.Write("Please pick a number between 10 and 99: ");
    string userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        Console.WriteLine("Thank you for playing!");
        Environment.Exit(1);
    }

    int userNumber = int.Parse(userInput);

    if (userNumber%23 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break; //IF PROGRAM DOESN'T WORK, REMOVE THE BRAKES FOR NOW.
    }
    
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        break;
    }
}

// Do While loop
do 
{
    Console.Write("Please pick a number between 10 and 99: ");
    string userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        Console.WriteLine("Thank you for playing!");
        Environment.Exit(1);
    }

    int userNumber = int.Parse(userInput);

    if (userNumber%34 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break;
    }
    
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        break;
    }
} while (true);

// For loop
for (;;)
{
    Console.Write("Please pick a number between 10 and 99: ");
    string userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        Console.WriteLine("Thank you for playing!");
        Environment.Exit(1);
    }

    int userNumber = int.Parse(userInput);

    if (userNumber%33 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break;
    }
    
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        break;
    }
}

while (true)
{
    Console.Write("Which operator would you like to use? (+ - x or /): ");
    string userInput = Console.ReadLine();

    switch(userInput)
    {
        case "exit":
            Console.WriteLine("Thank you for playing!");
            Environment.Exit(1);
            break;

        case "+":
            Console.Write("Please choose your first integer: ");
            int numberOneAddition = int.Parse(Console.ReadLine());
            Console.Write("Please choose your second integer: ");
            int numberTwoAddition = int.Parse(Console.ReadLine());
            int additionResult = numberOneAddition + numberTwoAddition;
            Console.WriteLine(numberOneAddition + " + " + numberTwoAddition + " = " + additionResult);
            break;

        case "-":
            Console.Write("Please choose your first integer: ");
            int numberOneSubtraction = int.Parse(Console.ReadLine());
            Console.Write("Please choose your second integer: ");
            int numberTwoSubtraction = int.Parse(Console.ReadLine());
            int subtractionResult = numberOneSubtraction - numberTwoSubtraction;
            Console.WriteLine(numberOneSubtraction + " - " + numberTwoSubtraction + " = " + subtractionResult);
            break;

        case "x":
            Console.Write("Please choose your first integer: ");
            int numberOneMultiplication = int.Parse(Console.ReadLine());
            Console.Write("Please choose your second integer: ");
            int numberTwoMultiplication = int.Parse(Console.ReadLine());
            int multiplicationResult = numberOneMultiplication * numberTwoMultiplication;
            Console.WriteLine(numberOneMultiplication + " x " + numberTwoMultiplication + " = " + multiplicationResult);
            break;

        case "/":
            Console.Write("Please choose your first integer: ");
            double numberOneDivision = double.Parse(Console.ReadLine());
            Console.Write("Please choose your second integer: ");
            double numberTwoDivision = double.Parse(Console.ReadLine());
            double divisionResult = numberOneDivision / numberTwoDivision;
            Console.WriteLine(numberOneDivision + " / " + numberTwoDivision + " = " + divisionResult);
            break;
    }
    break;
}