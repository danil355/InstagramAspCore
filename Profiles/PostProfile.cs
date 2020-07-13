using AutoMapper;
using InstagramAspCore.Models;
using InstagramAspCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramAspCore.Profiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostViewModel>();
            CreateMap<PostViewModel, Post>();
            CreateMap<DbPost, PostViewModel>();
            CreateMap<PostViewModel, DbPost>();
        }
    }
}
