using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalBlog.Application.Dto;
using PersonalBlog.Application.Interfaces;
using PersonalBlog.Models;
using System.Diagnostics;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly ILogger<HomeController> _logger;
        
        private readonly IHostingEnvironment _env;
        public HomeController(ILogger<HomeController> logger,   IBlogPostService blogPostService, IHostingEnvironment env)
        {
            _logger = logger;
            
            _blogPostService = blogPostService;
            _env = env;
        }

        public IActionResult Index()
        {
            _blogPostService.GetLatestPosts();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public JsonResult LatestBlogPost()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BlogPostDto, BlogPostViewModel>());
            var map = new Mapper(config);
            var blogPostView = map.Map<BlogPostViewModel>(_blogPostService.GetLatestPosts());          
            return Json(blogPostView);
        }

        public JsonResult MoreBlogPosts(int oldestBlogPostId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BlogPostDto, BlogPostViewModel>());
            var map = new Mapper(config);
            var blogPostView = map.Map<BlogPostViewModel>(_blogPostService.GetOlderPosts(oldestBlogPostId));           
            return Json(blogPostView);
        }

        public ContentResult Post(string link)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BlogPostDto, BlogPostViewModel>());          
            var map = new Mapper(config);
            var blogPostView = map.Map<BlogPostViewModel>(_blogPostService.GetPostText(link));
            var text = System.IO.File.ReadAllText($"{_env.ContentRootPath}/wwwroot/Posts/{blogPostView.PostId}_post.md");
            return Content(text);
        }
    }
}
