bool runProgram = true;

//Arrays
string[] students = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] foods = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };
string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };

while (runProgram)
    {
    //Ask about student by number
    Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-17:");

    //Index the number -1 to adjust for 0 counting
    int index1 = int.Parse(Console.ReadLine()) - 1;

    //Validate user number ***fails when anything outside of range is input***
    if (index1 < 0 || index1 > students.Length - 1)
    {
        Console.WriteLine("Input out of range, please try again. Enter a number 1-17");
    }
    else
    //Respond back with number and name / prompt for hometown or fav food
    Console.WriteLine($"Student {index1 + 1} is {students[index1]}. What would you like to know? Enter \"hometown\" or \"favorite food\":");
    
    //Creating a loop for hometown / fav food for improper entry control
    bool runHometown = true;
    while (runHometown)
    {
        //Save the input
        string index2 = (Console.ReadLine().ToLower().Trim());
        //Choices
        //Hometown
        if (index2 == "hometown" || index2 == "town" || index2 == "home")
        {
            Console.WriteLine($"{students[index1]} is from {hometown[index1]}.");
            runHometown = false;
        }
        //Favorite Food
        else if (index2 == "favorite food" || index2 == "food" || index2 == "favorite")
        {
            Console.WriteLine($"{students[index1]} favorite food is {foods[index1]}.");
            runHometown = false;
        }
        else
        {
            //Loops to prompt with improper entry
            Console.WriteLine($"That category does not exist. Please try again. Enter \"hometown\" or \"favorite food\":");
            runHometown = true;
        }
    }

    //breakout code ***fails when code is ran thgough with non y/n answers***
    Console.WriteLine($"Would you like to learn about another student? Enter \"y\" or \"n\":");
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower().Trim() == "y")
    {
        runProgram = true;
    }
    else if (loopChoice.ToLower().Trim() == "n")
    {
        Console.WriteLine("Thanks!");
        runProgram = false;
    }
    else
    {
        Console.WriteLine($"Incorrect response, please enter \"y\" or \"n\":");
    }
}
