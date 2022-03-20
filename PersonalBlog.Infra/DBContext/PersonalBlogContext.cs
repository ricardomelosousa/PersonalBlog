﻿using Microsoft.EntityFrameworkCore;
using PersonalBlog.Domain;

namespace PersonalBlog.Infra.DBContext
{
    public class PersonalBlogContext : DbContext
    {

        public PersonalBlogContext(DbContextOptions<PersonalBlogContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPost { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>().HasKey(a => a.PostId);
            modelBuilder.Entity<BlogPost>()
                .HasData(new BlogPost { PostId = 1, Title = "How to capture posts via APIs", ShortDescription = "How to use fetch to get a list of blog posts" },
                      new BlogPost { PostId = 2, Title = "Using Indexed DB", ShortDescription = "How to save a list of posts using IndexedDB" },
                      new BlogPost { PostId = 3, Title = "Using Cache to store Blog posts", ShortDescription = "How to use the Cache API to store blog posts that can be available offline" },
                      new BlogPost { PostId = 4, Title = "Obtaining cache data from Service Worker", ShortDescription = "How to use Service Workers to get data from cache when user is offline" },
                      new BlogPost { PostId = 5, Title = "Creating a Installable Web App", ShortDescription = "How to create the files that allow you to install your site as an App on your phone" },
                      new BlogPost { PostId = 6, Title = "Sending push notifications", ShortDescription = "How to send push notifications to call your user attention to something on your app" },
                      new BlogPost { PostId = 7, Title = "Camera, Microphone and Video", ShortDescription = "How powerful the native file inputs can be" },
                      new BlogPost { PostId = 8, Title = "Geolocation", ShortDescription = "How to know where your user is located using geocoding" },
                      new BlogPost { PostId = 9, Title = "Vibration", ShortDescription = "How to vibrate your phone" },
                      new BlogPost { PostId = 10, Title = "Gyroscope", ShortDescription = "How to capture phone gyroscope" },
                      new BlogPost { PostId = 11, Title = "Code Improvements", ShortDescription = "How to improve the implementation" },
                      new BlogPost { PostId = 12, Title = "Debugging on the Phone", ShortDescription = "How connect to a Phone and debug from there" },
                      new BlogPost { PostId = 13, Title = "Using AutoMapper", ShortDescription = "Using AutoMapper" },
                      new BlogPost { PostId = 14, Title = "Using AutoMapper part 2", ShortDescription = "Using AutoMapper part 2" });

        }

    }
}