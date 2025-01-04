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
    internal class MovieRepository : BaseRepository<Movie>, IMovieRepository
    {
        internal MovieRepository(DbContext context) : base(context) { }
    }
}
