namespace EventEaseApp.Models
{
    public class Event
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Id { get; set; } // Unique identifier for routing
    }
}
