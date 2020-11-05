using Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base (options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<TravelActivity> TravelActivities { get; set; }
        public DbSet<TravelPlan> TravelPlans { get; set; }
        public DbSet<UserTravelPlan> UserTravelPlans { get; set; }
        public DbSet<UserTravelRole> UserTravelRoles { get; set; }


        protected override void OnModelCreating (ModelBuilder builder)
        {
            //allows to give app user with primary key
            base.OnModelCreating (builder);

            //the UserTravelPlan has a primary key  consisting of appuserid and UserTravelPlanId
            builder.Entity<UserTravelPlan> (x => x.HasKey (utp => new { utp.UserId, utp.TravelPlanId }));

            //appUser 1:M  UserTravelPlan, TravelPlan 1:M UserTravelPlan; essentially appUsers M:M TravelPlan
            builder.Entity<UserTravelPlan> ().HasOne (u => u.AppUser).WithMany (appU => appU.UserTravelPlans).HasForeignKey (utp => utp.UserId);
            builder.Entity<UserTravelPlan> ().HasOne (a => a.TravelPlan).WithMany (tp => tp.UserTravelPlans).HasForeignKey (utp => utp.TravelPlanId);

        }   
    }
}