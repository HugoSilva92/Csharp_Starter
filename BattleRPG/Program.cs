Random attack = new Random();
int heroe = 10;
int monster = 10;

do{
	int	moves = attack.Next(1, 10);
	monster -= moves;
	Console.WriteLine($"Monster was attacked for {moves}, it remains with {monster} of HP!");
	if (monster <= 0)
		break;
	moves = attack.Next(1, 10);
	heroe -= moves;
	Console.WriteLine($"Heroe was attacked for {moves}, it remains with {heroe} of HP!");

} while (heroe >= 0);

if (monster <= 0)
	Console.WriteLine("Heroe WON!");
else
	Console.WriteLine("Monster WON!");


//	String to Integer and check the value!
/* Console.WriteLine("Enter an integer value between 5 and 10");
while (true){
	string? inp;
	inp = Console.ReadLine();
	int	number;
	bool validNumber = int.TryParse(inp, out number);
	if (validNumber){
		if (number >= 5 && number <= 10){
			Console.WriteLine($"Your input ({number}) has been accepted.");
			break;
		}
		else
			Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
	}
	else
		Console.WriteLine("Sorry, you entered a invalid number, please try again.");
} */

//	Check string to see if it matches!
/* bool checkInput = true;

do {
	Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
	string? inp;
	inp = Console.ReadLine();
	switch (inp){
		case "Administrator":
			Console.WriteLine($"Your input value ({inp}) has been accepted");
			checkInput = false;
			break;
		case "Manager":
			Console.WriteLine($"Your input value ({inp}) has been accepted");
			checkInput = false;
			break;
		case "User":
			Console.WriteLine($"Your input value ({inp}) has been accepted");
			checkInput = false;
			break;
		default:
			Console.WriteLine($"The role name you entered, \"{inp}\" is not valid.");
			break;
	}
} while (checkInput); */


// My way to do the exercise of the strings!
/* string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string str in myStrings){
	string[] splited = str.Split('.');
	foreach (string split in splited){
		Console.WriteLine(split.Trim());
	}
} */
