using SnapsLibrary;

class Ch10_04_TimeTracker
{
    struct Contact
    {
        public string ContactName;
        public string ContactAddress;
        public string ContactPhone;
        public int ContactMinutesSpent;

        public Contact(string name, string address, string phone)
        {
            this.ContactName = name;
            this.ContactAddress = address;
            this.ContactPhone = phone;
            this.ContactMinutesSpent = 0;
        }
    }

    void makeTestData()
    {
        string[] testNames = {
            "Rob", "Mary", "David", "Jenny",
            "Simon", "Kevin", "Helen", "Chris",
            "Amanda", "Sally" };

        // the number of minutes for contacts
        int minutes = 0;

        foreach (string name in testNames)
        {
            Contact newContact = new Contact(name: name,
                address: name + "'s house",
                phone: name + "'s phone");
            newContact.ContactMinutesSpent = minutes;
            minutes = minutes + 30;
            storeContact(newContact);
        }
    }

    Contact[] contacts = new Contact[100];

    bool storeContact(Contact contact)
    {
        for (int position = 0; position < contacts.Length; position = position + 1)
        {
            if (contacts[position].ContactName == null)
            {
                contacts[position] = contact;
                return true;
            }
        }
        return false;
    }

    void newContact()
    {
        SnapsEngine.SetTitleString("New Contact");
        string name = SnapsEngine.ReadString("Enter new contact name");
        foreach (Contact contact in contacts)
            while (contact.ContactName == name)
            {
                name = SnapsEngine.ReadString(name + " is already in your contact. \nPlease enter a unique name or use our 'Find Contact' option.");
            }

        string address = SnapsEngine.ReadMultiLineString("Enter contact address");
        string phone = SnapsEngine.ReadString("Enter contact phone");
        string confirm = SnapsEngine.SelectFrom2Buttons("Save Contact", "Cancel");

        switch (confirm)
        {
            case "Save Contact":
                Contact newContact = new Contact(name: name, address: address, phone: phone);
                if (storeContact(newContact))
                {
                    SnapsEngine.DisplayString("Contact stored");
                    SnapsEngine.ClearTextDisplay();
                }
                else
                {
                    SnapsEngine.DisplayString("Storage failed");
                }
                break;

            case "Cancel":
                SnapsEngine.ClearTextDisplay();
                break;
        }

        
    }

    void findContact()
    {
        SnapsEngine.SetTitleString("Find Contact");

        string name = SnapsEngine.ReadString("Enter contact name");

        bool foundAContact = false;

        SnapsEngine.ClearTextDisplay();

        foreach (Contact contact in contacts)
        {
            if (contact.ContactName == name)
            {
                SnapsEngine.AddLineToTextDisplay("Name: " + contact.ContactName);
                SnapsEngine.AddLineToTextDisplay("Address: " + contact.ContactAddress);
                SnapsEngine.AddLineToTextDisplay("Phone: " + contact.ContactPhone);
                SnapsEngine.AddLineToTextDisplay("Minutes: " + contact.ContactMinutesSpent.ToString());
                foundAContact = true;
                break;
            }
        }

        if (!foundAContact)
            SnapsEngine.AddLineToTextDisplay("Contact not found");

        SnapsEngine.WaitForButton("Continue");
        SnapsEngine.ClearTextDisplay();
    }

    void addMinutes()
    {
        SnapsEngine.SetTitleString("Add Minutes");
        bool foundContact = false;
        string name = SnapsEngine.ReadString("Enter contact name");
        foreach (Contact contact in contacts)
        {
            if (contact.ContactName == name)
            {
                foundContact = true;
                int minutes = SnapsEngine.ReadInteger("Enter contact minutes");

                while (minutes <= 0)                     
                    {
                        minutes = SnapsEngine.ReadInteger("You entered an invalid number. \nPlease enter a number greater than zero.");
                    }

                SnapsEngine.ClearTextDisplay();

                for (int position = 0; position < contacts.Length; position = position + 1)
                {
                    if (contacts[position].ContactName == name)
                    {
                        SnapsEngine.AddLineToTextDisplay("Added " + minutes + " minutes\n" +
                            "to " + name);
                        contacts[position].ContactMinutesSpent = contacts[position].ContactMinutesSpent + minutes;
                        SnapsEngine.WaitForButton("Continue");
                        SnapsEngine.ClearTextDisplay();
                    }
                }
            }
        }

        if (foundContact == false)
        {
            SnapsEngine.AddLineToTextDisplay("Contact not found");
            SnapsEngine.WaitForButton("Continue");
            SnapsEngine.ClearTextDisplay();
        }
    }

    void displaySummary()
    {
        SnapsEngine.SetTitleString("Display Summary");

        for (int pass = 0; pass < contacts.Length - 1; pass = pass + 1)
        {
            for (int i = 0; i < contacts.Length - 1; i = i + 1)
            {
                if (contacts[i].ContactMinutesSpent < contacts[i + 1].ContactMinutesSpent)
                {
                    // the elements are in the wrong order, need to swap them round
                    Contact temp = contacts[i];
                    contacts[i] = contacts[i + 1];
                    contacts[i + 1] = temp;
                }
            }
        }

        SnapsEngine.SetTitleString("Contact Times");

        SnapsEngine.ClearTextDisplay();

        for (int position = 0; position < 5; position = position + 1)
        {
            if (contacts[position].ContactName == null)
                break;
            SnapsEngine.AddLineToTextDisplay(contacts[position].ContactName +
                ":" + contacts[position].ContactMinutesSpent);
        }

        SnapsEngine.WaitForButton("Continue");

        SnapsEngine.ClearTextDisplay();
    }

    public void StartProgram()
    {


        // Remove this statement before you sell the program 
        //makeTestData();

        while (true)
        {
            SnapsEngine.SetTitleString("Time Tracker");

            string command = SnapsEngine.SelectFrom4Buttons("New Contact", "Find Contact",
                "Add Minutes", "Display Summary");

            switch (command)
            {
                case "New Contact":
                    newContact();
                    break;

                case "Find Contact":
                    findContact();
                    break;

                case "Add Minutes":
                    addMinutes();
                    break;

                case "Display Summary":
                    displaySummary();
                    break;
            }
        }
    }
}
