using System;

namespace Domain
{
    public class TravelActivity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        
    }
}