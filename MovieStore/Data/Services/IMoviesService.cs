using MovieStore.Data.Base;
using MovieStore.Data.ViewModels;
using MovieStore.Models;
using System.Threading.Tasks;

namespace MovieStore.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);

    }
}
