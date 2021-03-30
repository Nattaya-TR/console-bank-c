using System;

namespace classes 
{ 

    public class Client
    {
        public Guid Id { get ; }
        public string Name { get; set; }
        public DateTime DateJoined { get; set; }
        
        public Client(string Name)
        {
            this.Id = Guid.NewGuid();
            this.Name = Name;
            this.DateJoined = DateTime.Now;
        }

    
    }
}