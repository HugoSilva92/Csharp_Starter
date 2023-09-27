void display()
{
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine(" 9. Exit Program");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");
}

void put_animal(string[,] ourAnimals, int maxPets)
{
    for (int i = 0; i < maxPets; i++)
    {
        switch (i)
        {
            case 0:
                ourAnimals[i, 0] = "ID #: " + "d1";
                ourAnimals[i, 1] = "Species: " + "dog";
                ourAnimals[i, 2] = "Age: " + "2";
                ourAnimals[i, 3] = "Nickname: " + "Lola";
                ourAnimals[i, 4] = "Personality" + "Loves to have her belly rubbed. Gives alot of kisses.";
                ourAnimals[i, 5] = "Physical description: " + "medium sized cream colored female golden retriever, 65 pounds. Housebroken.";
                break;
            case 1:
                ourAnimals[i, 0] = "ID #: " + "d2";
                ourAnimals[i, 1] = "Species: " + "dog";
                ourAnimals[i, 2] = "Age: " + "9";
                ourAnimals[i, 3] = "Nickname: " + "loki";
                ourAnimals[i, 4] = "Personality" + "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
                ourAnimals[i, 5] = "Physical description: " + "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
                break;
            case 2:
                ourAnimals[i, 0] = "ID #: " + "c3";
                ourAnimals[i, 1] = "Species: " + "cat";
                ourAnimals[i, 2] = "Age: " + "1";
                ourAnimals[i, 3] = "Nickname: " + "Puss";
                ourAnimals[i, 2] = "Personality" + "friendly";
                ourAnimals[i, 2] = "Physical description: " + "small white female weighing about 8 pounds. litter box trained.";
                break;
            case 3:
                ourAnimals[i, 0] = "ID #: " + "c4";
                ourAnimals[i, 1] = "Species: " + "cat";
                ourAnimals[i, 2] = "Age: " + "?";
                ourAnimals[i, 3] = "Nickname: " + "";
                ourAnimals[i, 4] = "Personality" + "";
                ourAnimals[i, 5] = "Physical description: " + "";
                break;
            default:
                ourAnimals[i, 0] = "ID #: " + "";
                ourAnimals[i, 1] = "Species: " + "";
                ourAnimals[i, 2] = "Age: " + "";
                ourAnimals[i, 3] = "Nickname: " + "";
                ourAnimals[i, 4] = "Personality" + "";
                ourAnimals[i, 5] = "Physical description: " + "";
                break;
        }
    }
}

void showAnimals(string[,] ourAnimals, int i)
{
    if (ourAnimals[i, 0] != "ID #: ")
    {
        Console.WriteLine(ourAnimals[i, 0]);
        Console.WriteLine(ourAnimals[i, 1]);
        Console.WriteLine(ourAnimals[i, 2]);
        Console.WriteLine(ourAnimals[i, 3]);
        Console.WriteLine(ourAnimals[i, 4]);
        Console.WriteLine(ourAnimals[i, 5]);
        Console.WriteLine();
    }
}

int countAnimals(string[,] ourAnimals, int maxPets)
{
    int count = 0;

    for (int i = 0; i < maxPets; i++)
    {
        if (ourAnimals[i, 0] != "ID #: ")
            count++;
    }
    return (count);
}

void addAnimal(string[,] ourAnimals, int maxPets, string? readResult)
{
    int petCount = countAnimals(ourAnimals, maxPets);

    if (petCount < maxPets)
    {
        int age = 0;
        bool isInt = false;
        string animalPhysicalDescription = "";
        string animalPersonalityDescription = "";
        Console.WriteLine("You want to add another animal to our list?");
        readResult = Console.ReadLine();
        if (readResult == "yes" || readResult == "y")
        {
            Console.WriteLine("Enter the animal's ID number: ");
            readResult = Console.ReadLine();
            ourAnimals[petCount, 0] = "ID #: " + readResult;
            Console.WriteLine("Enter the animal's species: ");
            readResult = Console.ReadLine();
            if (readResult != "dog" && readResult != "cat")
            {
                Console.WriteLine("You did not enter a valid species, so we will not add another animal at this time.");
                ourAnimals[petCount, 0] = "ID #: ";
                return;
            }
            ourAnimals[petCount, 1] = "Species: " + readResult;
            Console.WriteLine("Enter the animal's age: ");
            readResult = Console.ReadLine();
            if (readResult != null)
                isInt = int.TryParse(readResult, out age);
            if (!isInt)
            {
                Console.WriteLine("You did not enter a valid age, so we will not add another animal at this time.");
                ourAnimals[petCount, 0] = "ID #: ";
                return;
            }
            ourAnimals[petCount, 2] = "Age: " + readResult;
            Console.WriteLine("Enter the animal's nickname: ");
            readResult = Console.ReadLine();
            ourAnimals[petCount, 3] = "Nickname: " + readResult;
            {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPersonalityDescription = readResult.ToLower();
                    if (animalPersonalityDescription == "")
                    {
                        animalPersonalityDescription = "tbd";
                    }
                    ourAnimals[petCount, 4] = "Personality: " + animalPersonalityDescription;
                }
            } while (animalPersonalityDescription == "") ;
            do
            {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPhysicalDescription = readResult.ToLower();
                    if (animalPhysicalDescription == "")
                    {
                        animalPhysicalDescription = "tbd";
                    }
                    ourAnimals[petCount, 5] = "Personality: " + animalPhysicalDescription;
                }
            } while (animalPhysicalDescription == "");
        }
        else
            Console.WriteLine("You did not enter yes or y, so we will not add another animal at this time.");
    }
    else
        Console.WriteLine("Sorry, we are at maximum capacity and cannot add another animal at this time.");
}

string[,] ourAnimals = new string[8, 6];
string menuSelection = "";
string? readResult;
int maxPets = 8;

put_animal(ourAnimals, maxPets);

do
{
    display();
    readResult = Console.ReadLine();
    if (readResult != null)
        menuSelection = readResult.ToLower();
    switch (menuSelection)
    {
        case "1":
            Console.Clear();
            for (int i = 0; i < maxPets; i++)
                showAnimals(ourAnimals, i);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "2":
            addAnimal(ourAnimals, maxPets, readResult);
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "9":
            menuSelection = "exit";
            break;
        case "exit":
            menuSelection = "exit";
            break;
        default:
            Console.WriteLine("You did not select a valid menu option");
            break;
    }
} while (menuSelection != "exit");

/*Console.WriteLine($"You selected menu option {menuSelection}.");
Console.WriteLine("Press the Enter key to continue");*/

// pause code execution
readResult = Console.ReadLine();
