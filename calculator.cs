Console.Write("Hello, please select an operation, 1-4: " + "\n" + "1. Addition" + "\n" + "2. Subtraction" + "\n" + "3. Division" + "\n" + "4. Multiplication" + "\n");
int choice = Convert.ToInt32(Console.ReadLine());
// pretty simple so far. Should split up each category onto it's own line, I've just got to actually make them functional now lol.

// addition = done, subtraction = done, division = working on it, multiplication = not done.  

switch (choice)
{
    case 1:
    {
        Console.WriteLine("You selected Addition");
            Console.WriteLine("How many numbers do you want to add?");

            float NumCount = Convert.ToSingle(Console.ReadLine());
            float sum = 0; // this is a running total that will be used to add the numbers together.

            for (int i = 0; i < NumCount; i++) // for loop. The first part sets the starting point (i) to zero. The second part sets the condition for the loop to break once greater than "numcount", the last part is the same as i+= 1.
            // this approach is not at all optimal, don't get me wrong. i just needed an excuse and application to test out doing for loops.
        {
            Console.WriteLine("Please enter a number to add: ");
            float CurrentNum = Convert.ToSingle(Console.ReadLine()); 
            sum += CurrentNum; // adds the current number to a running total.

            if (CurrentNum > 2147483000) // the 32 bit integer limit. This will prevent errors being thrown in the case that the number is too large. there is definitely a prettier way to do this.
            {
                // im going to save and exit for now, it's up to future me to figure out how to do this.
                break;
            }
            Console.WriteLine("The sum of the numbers is: {0}", sum + "\n"); 
        }
        break;
    }
    
    case 2:
    {
        Console.WriteLine("You selected Subtraction");
        Console.WriteLine("What is your first number?");
        float StartingNum = Convert.ToSingle(Console.ReadLine()); // I think I'll have the user start with an initial number here, then make it continue to subtract entered numbers until they stop.
        float SubtractionNum  = 1;
        // this is the variable for the subtraction storage number. I need to put it here because otherwise it wont work in the do while loop because im an idiot  


        
        do // my first attempt at a do while loop. Theoretically this should continue to ask the user to enter numbers to subtract until they enter a specific key.
        {
            Console.WriteLine("Please enter a number to subtract: \n Alternatively, enter zero to stop subtracting numbers.");
            SubtractionNum = Convert.ToSingle(Console.ReadLine());
            StartingNum -= SubtractionNum;

            if (SubtractionNum != 0)
            {
                Console.WriteLine("The Current total is: {0}", StartingNum + "\n");
            }
        }
        while (SubtractionNum != 0);
        break;  // I COULD HAVE DONE ALL THIS IN THE ADDITION PART FML
                // literal waste of time. I can just use negative numbers in addition which is the EXACT SAME THING as subtraction. why am I such a fucking idiot
    }
    
    case 3:

    {
        Console.WriteLine("You selected Division");
        Console.WriteLine("What is your first number?");
        float StartingNum = Convert.ToSingle(Console.ReadLine());
        float DivisionNum = 1;

        do
        {
            Console.WriteLine("Please enter a number to divide by: \n Alternatively, enter zero to stop dividing numbers.");
            DivisionNum = Convert.ToInt32(Console.ReadLine());
            StartingNum /= DivisionNum;

            Console.WriteLine("The current value is {0}. \n", StartingNum);
        }
        while (DivisionNum != 0);
        break; // I feel like Dr. Frankenstein making the freakish mess work
    }
    
    case 4: // last one brah I got this brah. Then I need to make calculator 2 :(
    {
        Console.WriteLine("You selected Multiplication \n What is your first number?\n");
        float StartingNum = Convert.ToSingle(Console.ReadLine());
        float multiplier = 1;

        do
            {
            Console.WriteLine("Please enter a number to multiply by: \n Alternatively, enter zero to stop multipling numbers.");
            multiplier = Convert.ToSingle(Console.ReadLine());
            StartingNum *= multiplier;

            Console.WriteLine("The current value is {0}. ", StartingNum);
            }
        while (multiplier != 0);

        break;
    }    
}

//fweh homoxide schyeah coding is bs anyway I'm going to get a job as a binman 
// i have zero clue what I was doing
// i feel like putting this entire thing in a single switch is so messy but I dunno how else to do it. could do them in 4 different functions ig. too late now whoops 
