// so I'm gonna probably need to plan this one out prior. The plan is to make this a more efficient and thought-out version of calculator one. I realise I should plan all my programs but uhmm I'm too lazy
    // first, some issues w/ calculator 1:
    // limited operations. Only 4. Could do exponent, modulo, et cetera
    // I don't like having the entire thing inside a single switch. and I also need to practice using function and procedures so might as well try use those
    // this might be beyond me atm but could I have the ability to swap operation in the middle of the calculation? or in some way save the numbers in persistent storage. Might be a mark 3 thing.

// ok, so initially we have three functions: Add/subtract, Divide, Multiply. These will be the basic ones and I can tack on fancy stuff elsewhere
    // main priority is to make these better trimmed and easier to read than on mark 1, L spaghetticode :hiyorisuffer: - I don't really know how I'll accomplish this because I'm very much the same programmer that I was 2 weeks ago
    // under divide will be three sub options - Modulus, Integer, and "regular". Might need a fancier name for that idk what the official term is, it works for now
    // can have, under multiplication, exponent and mayyybe factorial? idk how off the top of my head I'd do factorials but we will see.


Console.WriteLine("---------Welcome!---------");
Console.WriteLine("Please, select a starting operation: \n1 - Addition/Subtraction: \n2 - Division: \n3 - Multiplication: ");

int OperatorChoice = Convert.ToInt32(Console.ReadLine());

// lets see if I remember how functions work


static int Addition();

static int Multiplication();

static int Division();