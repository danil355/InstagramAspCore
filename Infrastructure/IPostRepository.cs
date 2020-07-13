using InstagramAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramAspCore.Infrastructure
{
    public interface IPostRepository
    {
        Post Create(Post post);

        IList<Post> GetAll();

        Post Get(int id);
    }
}
