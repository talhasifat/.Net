using DAL.Interfaces;
using GymManagement.DAL.Models;
using GymManagement.DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static IRepo<Member, int, Member> MemberData()
        {
            return new MemberRepo();
        }
    }
}
