using AutoMapper;
using Microsoft.Extensions.Configuration;
using PersonalBlog.Application.Dto;
using PersonalBlog.Application.Interfaces;
using PersonalBlog.Domain;

namespace PersonalBlog.Application.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly IConfiguration _configuration;

        public BlogPostService(IBlogPostRepository blogPostRepository, IConfiguration configuration)
        {
            _blogPostRepository = blogPostRepository;
            _configuration = configuration;

        }
        public List<BlogPostDto> GetLatestPosts()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BlogPost, BlogPostDto>());
            var blogs = _blogPostRepository.GetLatestPosts();
            var map = new Mapper(config);
            var result = map.Map<List<BlogPostDto>>(blogs);
            return result;
        }

        public List<BlogPostDto> GetOlderPosts(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BlogPost, BlogPostDto>());
            var blogs = _blogPostRepository.GetOlderPosts(id);
            var map = new Mapper(config);
            var result = map.Map<List<BlogPostDto>>(blogs);
            return result;
        }

        public BlogPostDto GetPostText(string link)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BlogPost, BlogPostDto>());
            var map = new Mapper(config);
            var blogPostDto = map.Map<BlogPostDto>(_blogPostRepository.GetPostText(link));
            return blogPostDto;
        }
    }
}
