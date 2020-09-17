using Microsoft.EntityFrameworkCore;
using RedSocial.Core.Entities;
using RedSocial.Core.Interfaces;
using RedSocial.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial.Infrastructure.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly SocialMediaContext _contex;

        public PostRepository(SocialMediaContext context)
        {
            _contex = context;
        }

        public async Task<IEnumerable<Publicacion>> GetPosts()
        {
            var posts = await _contex.Publicacion.ToListAsync();
            return posts;
        }
    }
}
