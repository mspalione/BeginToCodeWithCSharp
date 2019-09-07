using SnapsLibrary;


class Ch04_06_TimeDisplay
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Current Time");

        var time = true;


        while (time)
        {
            int hourValue = SnapsEngine.GetHourValue();
            int minuteValue = SnapsEngine.GetMinuteValue();
            int secondValue = SnapsEngine.GetSecondsValue();
            string currentTime = hourValue.ToString() + ":" + minuteValue.ToString() + ":" + secondValue.ToString();
            SnapsEngine.Delay(1);
            SnapsEngine.DisplayString(currentTime);
        }
    }
}