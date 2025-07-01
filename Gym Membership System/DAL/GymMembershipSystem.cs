using GymManagement.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL
{
    public class GymMembershipSystem : DbContext
    {
        public GymMembershipSystem() : base("GymMembershipSystem") { }

        public DbSet<Member> Members { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
    }
}
