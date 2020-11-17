using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public bool IsPrivate { get; set; }

        //jxn tables
        public virtual ICollection<UserTravelPlan> UserTravelPlans {get;set;}

        
    }
}