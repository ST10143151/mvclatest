using MvcKhumaloCraft_Poe_Part2.Data.Base;
using MvcKhumaloCraft_Poe_Part2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKhumaloCraft_Poe_Part2.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
