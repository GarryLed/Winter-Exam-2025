using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    // enums to store types of events 
    public enum TypeOfEvent { Music, Comedy, Theatre }

    public class Event : IComparable<Event> // using Icomparable for sorting events by dates 
    {
        // properties 
        public string Name { get; set; }
        public DateTime EventDate { get; set; }

        public TypeOfEvent EventType { get; set; }
        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        // constructors 
       
         public Event (string name, DateTime dateTime, TypeOfEvent eventtype) 
     {
            Name = name;
            EventDate = dateTime;
            EventType = eventtype;
            Tickets = new List<Ticket> ();
        }
        
        
        // methods 
        // compare to method that is used to compare Event objects (using EventDate)
        public int CompareTo(Event other)

        {

            // guard clause  

            if (other == null) return 1;

            // sort by books publish date 

            Event otherEvent = other as Event;

            if (otherEvent != null)

            {
                return this.EventDate.CompareTo(otherEvent.EventDate);
            }

            else

            {

                throw new ArgumentException("Object is not a team object");
            }

        }
        
        // to string method 
        public override string ToString()
        {
            return $"{Name} - {EventDate}";
        }
    }
}
