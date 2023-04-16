using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Base;
using MovieStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }


    }
}
