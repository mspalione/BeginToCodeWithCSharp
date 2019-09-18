using SnapsLibrary;


    class FortuneTeller
    {
    public void StartProgram()
    {
        int dice = SnapsEngine.ThrowDice();


        SnapsEngine.SetTitleString("Would you like to hear your future?");
        string rollAgain = SnapsEngine.SelectFrom2Buttons(
                "yes",
                "no");

        while (rollAgain == "yes")
        {

            if (dice == 1)
                SnapsEngine.SpeakString("You will have 12 cats by the time you turn 70");
            if (dice == 2)
                SnapsEngine.SpeakString("You will hike the tallest mountain");
            if (dice == 3)
                SnapsEngine.SpeakString("You will love greatly and lose greatly");
            if (dice == 4)
                SnapsEngine.SpeakString("You will be the life of the party");
            if (dice == 5)
                SnapsEngine.SpeakString("You will enjoy the simple things");
            if (dice == 6)
                SnapsEngine.SpeakString("You will go far");

            SnapsEngine.SetTitleString("Would you like to hear your future again?");
            SnapsEngine.SelectFrom2Buttons(
                "yes",
                "no");

            if (rollAgain == "yes")
                SnapsEngine.ThrowDice();

            if (rollAgain == "no")
                SnapsEngine.SpeakString("Good-Bye");
        } 

       if (rollAgain == "no")
        SnapsEngine.SpeakString("Good-Bye");
    }
}

