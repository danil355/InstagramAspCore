using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramAspCore.Infrastructure
{
    public interface IUnitOfWork
    {
        IPostRepository Posts { get; set; }
        IDbPostRepository DbPosts { get; set; }

        int Save();
    }
}
