using MvcKhumaloCraft_Poe_Part2.Data.Base;
using MvcKhumaloCraft_Poe_Part2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcKhumaloCraft_Poe_Part2.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
    }
}
