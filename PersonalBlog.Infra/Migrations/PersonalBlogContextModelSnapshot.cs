﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalBlog.Infra.DBContext;

#nullable disable

namespace PersonalBlog.Infra.Migrations
{
    [DbContext(typeof(PersonalBlogContext))]
    partial class PersonalBlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PersonalBlog.Domain.BlogPost", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"), 1L, 1);

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.ToTable("BlogPost");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            ShortDescription = "How to use fetch to get a list of blog posts",
                            Title = "How to capture posts via APIs"
                        },
                        new
                        {
                            PostId = 2,
                            ShortDescription = "How to save a list of posts using IndexedDB",
                            Title = "Using Indexed DB"
                        },
                        new
                        {
                            PostId = 3,
                            ShortDescription = "How to use the Cache API to store blog posts that can be available offline",
                            Title = "Using Cache to store Blog posts"
                        },
                        new
                        {
                            PostId = 4,
                            ShortDescription = "How to use Service Workers to get data from cache when user is offline",
                            Title = "Obtaining cache data from Service Worker"
                        },
                        new
                        {
                            PostId = 5,
                            ShortDescription = "How to create the files that allow you to install your site as an App on your phone",
                            Title = "Creating a Installable Web App"
                        },
                        new
                        {
                            PostId = 6,
                            ShortDescription = "How to send push notifications to call your user attention to something on your app",
                            Title = "Sending push notifications"
                        },
                        new
                        {
                            PostId = 7,
                            ShortDescription = "How powerful the native file inputs can be",
                            Title = "Camera, Microphone and Video"
                        },
                        new
                        {
                            PostId = 8,
                            ShortDescription = "How to know where your user is located using geocoding",
                            Title = "Geolocation"
                        },
                        new
                        {
                            PostId = 9,
                            ShortDescription = "How to vibrate your phone",
                            Title = "Vibration"
                        },
                        new
                        {
                            PostId = 10,
                            ShortDescription = "How to capture phone gyroscope",
                            Title = "Gyroscope"
                        },
                        new
                        {
                            PostId = 11,
                            ShortDescription = "How to improve the implementation",
                            Title = "Code Improvements"
                        },
                        new
                        {
                            PostId = 12,
                            ShortDescription = "How connect to a Phone and debug from there",
                            Title = "Debugging on the Phone"
                        },
                        new
                        {
                            PostId = 13,
                            ShortDescription = "Using AutoMapper",
                            Title = "Using AutoMapper"
                        },
                        new
                        {
                            PostId = 14,
                            ShortDescription = "Using AutoMapper part 2",
                            Title = "Using AutoMapper part 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}