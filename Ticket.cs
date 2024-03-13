public class Ticket
{
    public string TicketID { get; set; }
    public string Summary { get; set; }
    public string Status { get; set; }
    public string Priority { get; set; }
    public string Submitter { get; set; }
    public string AssignedTo { get; set; }
    public string Watcher { get; set; }

    public Ticket(string ticketID, string summary, string status, string priority, string submitter, string assignedTo, string watcher)
    {
        TicketID = ticketID;
        Summary = summary;
        Status = status;
        Priority = priority;
        Submitter = submitter;
        AssignedTo = assignedTo;
        Watcher = watcher;
    }

    public override string ToString()
    {
        return $"TicketID: {TicketID} | Summary: {Summary} | Status: {Status} | Priority Level: {Priority} | Submitter: {Submitter} | Assigned To: {AssignedTo} | Watcher: {Watcher}";
    }
}
