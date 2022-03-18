using PersonalBlog.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Application.Interfaces
{
    public interface IBlogPostRepository
    {
        List<BlogPost> GetOlderPosts(int id);
        List<BlogPost> GetLatestPosts();
        BlogPost GetPostText(string link);
    }
}
