Console.Write("Hello, please select an operation, 1-4: " + "\n" + "1. Addition" + "\n" + "2. Subtraction" + "\n" + "3. Division" + "\n" + "4. Multiplication" + "\n");
int choice = Convert.ToInt32(Console.ReadLine());
// pretty simple so far. Should split up each category onto it's own line, I've just got to actually make them functional now lol.

// addition = done, subtraction = working on it, division = not done, multiplication = not done.  

switch (choice)
{
    case 1:
        Console.WriteLine("You selected Addition");
            Console.WriteLine("How many numbers do you want to add?");

            int NumCount = Convert.ToInt32(Console.ReadLine());
            int sum = 0; // this is a running total that will be used to add the numbers together.

            for (int i = 0; i < NumCount; i++) // for loop. The first part sets the starting point (i) to zero. The second part sets the condition for the loop to break once greater than "numcount", the last part is the same as i+= 1.
        {
            Console.WriteLine("Please enter a number to add: ");
            int CurrentNum = Convert.ToInt32(Console.ReadLine()); 
            sum += CurrentNum; // adds the current number to a running total.

            if (CurrentNum > 2147483000) // the 32 bit integer limit. This will prevent errors being thrown in the case that the number is too large. there is definitely a prettier way to do this.
            {
                // im going to save and exit for now, it's up to future me to figure out how to do this.
                break;
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum + "\n"); 
        }
        break;

    case 2:
        Console.WriteLine("You selected Subtraction");
        Console.WriteLine("What is your first number?");
        int StartingNum = Convert.ToInt32(Console.ReadLine()); // I think I'll have the user start with an initial number here, then make it continue to subtract entered numbers until they stop.
        int SubtractionNum  = 1;
        // this is the variable for the subtraction storage number. I need to put it here because otherwise it wont work in the do while loop because im an idiot  


        
        do // my first attempt at a do while loop. Theoretically this should continue to ask the user to enter numbers to subtract until they enter a specific key.
        {
            Console.WriteLine("Please enter a number to subtract: " + "\n" + "Alternatively, enter zero to stop subtracting numbers ");
            SubtractionNum = Convert.ToInt32(Console.ReadLine());
            StartingNum -= SubtractionNum;

            if (SubtractionNum != 0)
            {
                Console.WriteLine("The Current total is: {0}", StartingNum + "\n");
            }
        }
        while (SubtractionNum != 0);
        break;  // this shitty fucking loop doesnt work and infinitely repeats why is this language like this man
        // fuck this bro im doing case 2 later smd 

    case 3:
        Console.WriteLine("You selected Division");
        break;
    
    case 4:
        Console.WriteLine("You selected Multiplication");
        break;
}

//fweh homoxide schyeah coding is bs anyway I'm going to get a job as a binman 
// i have zero clue what I was doing
