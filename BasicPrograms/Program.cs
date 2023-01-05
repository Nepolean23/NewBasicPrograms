using BasicPrograms;

Console.WriteLine("1.FlipcoinProgram");
Console.WriteLine("Enter your option to view the program");
int option=Convert.ToInt32(Console.ReadLine());
switch(option)
{
    case 1:
        FlipCoins.Coins();
        break;
}