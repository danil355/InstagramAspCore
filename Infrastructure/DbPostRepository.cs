using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstagramAspCore.Data;
using InstagramAspCore.Models;
using Microsoft.EntityFrameworkCore;

namespace InstagramAspCore.Infrastructure
{
    public class DbPostRepository : IDbPostRepository
    {
        private readonly ApplicationDbContext _context;

        public DbPostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public DbPost Create(DbPost post)
        {
            var entry = _context.DbPosts.Add(post);
            return entry.Entity;
        }

        public DbPost Get(int id)
        {
            return _context.DbPosts.Find(id);
        }

        public IList<DbPost> GetAll()
        {
            return _context.DbPosts.Include(x => x.User).ToList();
        }
    }
}
