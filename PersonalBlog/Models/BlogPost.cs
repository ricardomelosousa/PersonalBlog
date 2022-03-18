using PersonalBlog.Extension;

namespace PersonalBlog.Models
{
    public class BlogPostViewModel
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }

        public string Link { get 
            {
                return ShortDescription.UrlFriendly(50);    
            }
        }

        //    set { ShortDescription.UrlFriendly()};

        //}

    }
}
