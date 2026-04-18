using Microsoft.VisualBasic;

class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int remaining)
    {
        return ExpectedMinutesInOven() - remaining;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int numberoflayer)
    {
        return numberoflayer * 2;        
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int numberoflayer, int remaining)
    {
        return PreparationTimeInMinutes(numberoflayer) + remaining;
    }

    static void Main()
    {
        var Lasagna = new Lasagna();
        int timetoremaining = Lasagna.RemainingMinutesInOven(30);
        int timetoprepare = Lasagna.PreparationTimeInMinutes(2);
        int total = Lasagna.ElapsedTimeInMinutes(3, 20);

        Console.WriteLine(timetoremaining);
        Console.WriteLine(timetoprepare);
        Console.WriteLine(total);
    }
}
