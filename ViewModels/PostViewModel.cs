using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramAspCore.ViewModels
{
    public class PostViewModel
    {
        public string Description { get; set; }
        public IFormFile Photo { get; set; }
    }
}
