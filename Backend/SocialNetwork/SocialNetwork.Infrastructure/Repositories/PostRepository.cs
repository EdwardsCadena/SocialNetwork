using SocialNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.Infrastructure.Repositories
{
    public class PostRepository
    {
        public IEnumerable<Post> GetPosts()
        {
            var posts = Enumerable.Range(1, 10).Select(x => new Post
            {
                PostId = x,
                Description = $"Description {x}",
                Date = DateTime.Now,
                Image = $"https://ticjob.co/es/job/desarrollador-net-wcf/8466?utm_source=neuvoo&utm_medium=ppc&utm_campaign=medium{x}",
                UserId = x * 2
            });
            return posts;
        }
    }
}
