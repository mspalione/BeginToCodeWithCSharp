using SnapsLibrary;

public class Countdown
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Countdown");
        SnapsEngine.DisplayString("Let the countdown begin! \n10");
        SnapsEngine.SpeakString("Let the countdown begin! Ten");
        SnapsEngine.DisplayString("Nine");
        SnapsEngine.SpeakString("Nine");
        SnapsEngine.DisplayString("Eight");
        SnapsEngine.SpeakString("Eight");
        SnapsEngine.DisplayString("Seven");
        SnapsEngine.SpeakString("Seven");
        SnapsEngine.DisplayString("Six");
        SnapsEngine.SpeakString("Six");
        SnapsEngine.DisplayString("Five");
        SnapsEngine.SpeakString("Five");
        SnapsEngine.DisplayString("Four");
        SnapsEngine.SpeakString("Four");
        SnapsEngine.DisplayString("Three");
        SnapsEngine.SpeakString("Three");
        SnapsEngine.DisplayString("Two");
        SnapsEngine.SpeakString("Two");
        SnapsEngine.DisplayString("One");
        SnapsEngine.SpeakString("One");
        SnapsEngine.DisplayString("Zero");
        SnapsEngine.SpeakString("Zero");
    }
}


