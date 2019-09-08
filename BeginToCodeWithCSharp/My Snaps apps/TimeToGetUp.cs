using SnapsLibrary;

class TimeToGetUp
{
    public void StartProgram()
    {
        int hourValue = SnapsEngine.GetHourValue();
        int minuteValue = SnapsEngine.GetMinuteValue();
        if (hourValue >= 19 && minuteValue >= 15)
            SnapsEngine.DisplayString("It is time to get up");
        else
            SnapsEngine.DisplayString("Go to bed");
    }
}