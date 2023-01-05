using BasicPrograms;

Console.WriteLine("1.FlipcoinProgram,2.LeapYear,3.PowerOfTwo,4.HarmonicNumber,5.PrimeFactor,6.QuotientAndReminder,\n7.SwapTwoNumbers,8.EvenOrOddNumber");


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

    case 6:
        QuotientAndReminder.values();
        break;

    case 7:
        SwapTwoNumbers.SwapingNumbers();
        break;

    case 8:
        EvenOrOddNumber.Checkingnumber();
        break;



}
