using EventEaseApp.Models; // Ensure the namespace matches your project structure

namespace EventEaseApp.Services
{
    public class EventService
    {
        private List<Event> _events = new List<Event>();
        private Dictionary<string, List<Attendee>> _attendees = new();

        public void AddEvent(Event newEvent)
        {
            _events.Add(newEvent);
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }
        public void RegisterAttendee(string eventId, Attendee attendee)
        {
            if (!_attendees.ContainsKey(eventId))
            {
                _attendees[eventId] = new List<Attendee>();
            }

            _attendees[eventId].Add(attendee);
        }

        public List<Attendee> GetAttendees(string eventId)
        {
            return _attendees.ContainsKey(eventId) ? _attendees[eventId] : new List<Attendee>();
        }
    }
    
}

