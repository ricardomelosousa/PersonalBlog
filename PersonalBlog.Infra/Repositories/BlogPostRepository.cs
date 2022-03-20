using PersonalBlog.Application.Interfaces;
using PersonalBlog.Domain;
using PersonalBlog.Infra.DBContext;

namespace PersonalBlog.Infra.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly PersonalBlogContext _personalBlogContext;
        public BlogPostRepository(PersonalBlogContext personalBlogContext)
        {
            _personalBlogContext = personalBlogContext ?? throw new ArgumentNullException(nameof(personalBlogContext));
        }
        public List<BlogPost> GetLatestPosts()
        {
            return _personalBlogContext.BlogPost.ToList();
        }

        public List<BlogPost> GetOlderPosts(int id)
        {
            return _personalBlogContext.BlogPost.Where(s => s.PostId == id).ToList();
        }

        public BlogPost GetPostText(string link) => _personalBlogContext.BlogPost.FirstOrDefault(s => s.ShortDescription == link);
    }
}
