using System;

public class Client
{
    public int Id
    {
        get { return Id; }
        set { Id = value; }
    }
    public string Name
    {
        get { return Name; }
        set { Name = value; }
    }
    public int DateJoined
    {
        get { return DateJoined; }
        set { DateJoined = value; }
    }
    public Client(int Id, string Name, int DateJoined)
    {
        this.Id = Id;
        this.Name = Name;
        this.DateJoined = DateJoined;
    }

    
}
