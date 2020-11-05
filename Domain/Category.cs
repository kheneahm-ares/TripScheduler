using System;
using System.Collections.Generic;

namespace Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Guid TravelPlanId { get; set; }
        public virtual TravelPlan TravelPlan { get; set; }
        public virtual ICollection<TravelActivity> TravelActivities { get; set; }

    }
}