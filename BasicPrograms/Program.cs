using BasicPrograms;

Console.WriteLine("1.FlipcoinProgram,2.LeapYear,3.PowerOfTwo,4.HarmonicNumber,5.PrimeFactor");
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

    case 3:
        PowerOfTwo.Squareofnumber(); 
        break;

    case 4:
        HarmonicNumber.Harmonicseries(); 
        break;

    case 5:
        PrimeFactors.Numbers();
        break;



}
