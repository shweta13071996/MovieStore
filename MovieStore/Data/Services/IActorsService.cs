using MovieStore.Data.Base;
using MovieStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieStore.Data.Services
{
    public interface IActorsService : IEntityBaseRepository<Actor>
    {
    }
}
