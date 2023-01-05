using BasicPrograms;

Console.WriteLine("1.FlipcoinProgram,2.LeapYear");
Console.WriteLine("Enter your option to view the program");
int option=Convert.ToInt32(Console.ReadLine());
switch(option)
{
    case 1:
        FlipCoins.Coins();
        break;

    case 2:
        LeapYear.Year();
        break;
}