using DAL.Repositories.Impl;
using DAL.Repositories.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly OSBBContext _context;
        private MovieRepository _movieRepository;
        private MovieSessionRepository _movieSessionRepository;

        public EFUnitOfWork(DbContextOptions options)
        {
            _context = new OSBBContext(options);
        }

        public IMovieRepository Movies =>
            _movieRepository ??= new MovieRepository(_context);

        public IMovieSessionRepository MovieSessions =>
            _movieSessionRepository ??= new MovieSessionRepository(_context);

        public void Save() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
