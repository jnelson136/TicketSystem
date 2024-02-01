string file = "tickets.csv";
string choice;

static string UppercaseFirst(string s)
{
    char[] a = s.ToCharArray();
    a[0] = char.ToUpper(a[0]);
    return new string(a);
}

do
{
    Console.WriteLine("1) Read Existing Ticket");
    Console.WriteLine("2) Create Ticket");
    Console.WriteLine("Enter any other key to exit.");

    choice = Console.ReadLine();



    if (choice == "1")
    {
        if (File.Exists(file))
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string[] arr = line.Split('|');

                Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
            }
            sr.Close();
        }

        else
        {
            Console.WriteLine("File does not exist");
        }
    }

    else if (choice == "2")
    {
        StreamWriter sw = new StreamWriter(file);
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Submit a new ticket (Y/N)?");

            string response = Console.ReadLine().ToUpper();
            
            if (response != "Y")
            {
                break;
            }

            Console.WriteLine("Enter Ticket ID");
            string ticketID = Console.ReadLine();

            Console.WriteLine("Enter a brief summary");
            string summary = Console.ReadLine();

            Console.WriteLine("Enter the ticket status (open or closed)");
            string status = Console.ReadLine();

            Console.WriteLine("Enter the ticket priority (Low, Medium, High)");
            string priority = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter the submitter name");
            string submitter = Console.ReadLine();

            Console.WriteLine("Enter who is assigned");
            string assignedTo = Console.ReadLine();

            Console.WriteLine("Enter the watcher");
            string watcher = Console.ReadLine();

            status = UppercaseFirst(status);
            submitter = UppercaseFirst(submitter);
            assignedTo = UppercaseFirst(assignedTo);
            watcher = UppercaseFirst(watcher);

            sw.WriteLine("TicketID: {0} | Summary: {1} | Status: {2} | Priority Level: {3} | Submitter: {4} | Assigned To: {5} | Watcher: {6}", ticketID, summary, status, priority, submitter, assignedTo, watcher);
        }
        sw.Close();
    }
} while (choice == "1" || choice == "2");