// Operador tenario

/*Random coinToss = new Random();

int	saleAmount = ;

Console.WriteLine($"Value: {saleAmount}");
Console.WriteLine($"Discount: {(coinToss.Next(0, 2000) > 10 ? "heads" : "tails")}");*/

string permission = "Manager";
int level = 10;

if (permission.Contains("Admin") && level > 55)
	Console.WriteLine("Welcome, Super Admin user.");
else if (permission.Contains("Admin") && level <= 55)
	Console.WriteLine("Welcome, Admin user.");
else if (permission.Contains("Manager") && level >= 20)
	Console.WriteLine("Contact an Admin for access.");
else if (permission.Contains("Manager") && level < 20)
	Console.WriteLine("You do not have sufficient privileges.");
else
	Console.WriteLine("You do not have sufficient privileges.");


// Tests made for another subject

/* int[] nb = {1, 5, 3, 2, 9, 7, 8, 4, 6, 10};

Array.Sort(nb);
Array.Clear(nb, 0, 5);
Array.Resize(ref nb, 5);

foreach (int i in nb)
	if (i != 0)
		Console.WriteLine(i); */

/* string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orders = orderStream.Split(',');

Array.Sort(orders);

foreach (string order in orders)
{
	if (order.Length != 4)
		Console.WriteLine(order + "	- Error");
	else
		Console.WriteLine(order);
} */
