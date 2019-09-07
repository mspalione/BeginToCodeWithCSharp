using SnapsLibrary;

class Ch03_12_EggTimerStart
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Egg Timer");
        SnapsEngine.DisplayString("There are five minutes left");
        SnapsEngine.Delay(60);
        SnapsEngine.DisplayString("There are four minutes left");
        SnapsEngine.Delay(60);
        SnapsEngine.DisplayString("There are three minutes left");
        SnapsEngine.Delay(60);
        SnapsEngine.DisplayString("There are two minutes left");
        SnapsEngine.Delay(60);
        SnapsEngine.DisplayString("There is one minute left");
        SnapsEngine.Delay(50);
        SnapsEngine.SpeakString("Ten");
        SnapsEngine.SpeakString("Nine");
        SnapsEngine.SpeakString("Eight");
        SnapsEngine.SpeakString("Seven");
        SnapsEngine.SpeakString("Six");
        SnapsEngine.SpeakString("Five");
        SnapsEngine.SpeakString("Four");
        SnapsEngine.SpeakString("Three");
        SnapsEngine.SpeakString("Two");
        SnapsEngine.SpeakString("One");
        SnapsEngine.SpeakString("Your egg is ready. Eat up!");
    }
}