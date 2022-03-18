using PersonalBlog.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBlog.Application.Interfaces
{
    public interface IBlogPostService
    {
        List<BlogPostDto> GetOlderPosts(int id);
        List<BlogPostDto> GetLatestPosts();
        BlogPostDto GetPostText(string link);

    }
}
