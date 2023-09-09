using Microsoft.VisualBasic.FileIO;

Random dice = new Random();
int	roll = dice.Next();
int	roll1 = dice.Next(4647);
int	roll2 = dice.Next(-34, 15484684);

Console.WriteLine($"{roll}\n {roll1} \n {roll2}");

dice.Next();
