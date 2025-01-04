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
    internal class MovieSessionRepository : BaseRepository<MovieSession>, IMovieSessionRepository
    {
        internal MovieSessionRepository(DbContext context) : base(context) { }
    }
}
