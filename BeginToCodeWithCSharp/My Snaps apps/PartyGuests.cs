using SnapsLibrary;

class PartyGuests
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Party Guests");

        // Find out how many guests are coming to the party
        int numOfGuests = SnapsEngine.ReadInteger("How many guests are coming to the party?");
        string[] guests = new string[numOfGuests];

        // Loop round and read the sales values
        for (int count = 0; count < guests.Length; count = count + 1)
        {
            if (count == 0)
            {
                guests[count] = SnapsEngine.ReadString("Enter the name of your first guest:");
            }
            else if (count == guests.Length)
            {
                guests[count] = SnapsEngine.ReadString("Enter the name of your last guest:");
            }
            else
            {
                guests[count] = SnapsEngine.ReadString("Enter the name of your next guest:");
            }
        }

        // Got the guest names, now display them

        SnapsEngine.ClearTextDisplay();

        // Add a line to the display for each sales figure
        for (int count = 0; count < guests.Length; count = count + 1)
        {
            int displayCount = count + 1;
            SnapsEngine.AddLineToTextDisplay("Guest Number " + displayCount + ": " + guests[count]);

        }

        
    }
}
