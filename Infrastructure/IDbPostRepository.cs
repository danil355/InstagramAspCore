using InstagramAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramAspCore.Infrastructure
{
    public interface IDbPostRepository
    {
        DbPost Create(DbPost post);

        IList<DbPost> GetAll();

        DbPost Get(int id);
    }
}
