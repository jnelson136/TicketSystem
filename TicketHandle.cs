using System;
using System.Collections.Generic;
using System.IO;

public class TicketHandle
{
    private string filePath;

    public TicketHandle(string filePath)
    {
        this.filePath = filePath;
    }

    public void ReadTicket()
    {
        StreamReader sr = new StreamReader(filePath);
        try
        {
            if (File.Exists(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("File Does Not Exist");
            }
        }
        finally
        {
            sr.Close();
        }
    }
}
