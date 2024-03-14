string file = "tickets.csv";
string choice;
TicketHandle ticketHandle = new TicketHandle(file);

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
        ticketHandle.ReadTicket();
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

            Ticket ticket = new Ticket(ticketID, summary, status, priority, submitter, assignedTo, watcher);
            ticketHandle.CreateTicket(ticket);
        }
        sw.Close();
    }
} while (choice == "1" || choice == "2");