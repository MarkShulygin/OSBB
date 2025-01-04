using DAL.Entities;
using DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Impl
{
    public class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        internal MovieRepository(DbContext context) : base(context) { }
        public IEnumerable<Movie> SearchMoviesByTitle(string title)
        {
            // Перевіряємо, чи рядок пошуку не є порожнім або null
            if (string.IsNullOrWhiteSpace(title))
            {
                return Enumerable.Empty<Movie>();
            }

            // Виконуємо пошук за частковим збігом назви (регістр незалежний)
            return _set.Where(movie => movie.Title.ToLower().Contains(title.ToLower())).ToList(); 
        }
    }
}
