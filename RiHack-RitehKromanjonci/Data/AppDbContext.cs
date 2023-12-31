﻿using Microsoft.EntityFrameworkCore;
using RiHack_RitehKromanjonci.Models;
using static System.Net.Mime.MediaTypeNames;

namespace RiHack_RitehKromanjonci.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<PostModel> Posts { get; set; }
    public DbSet<DiscussionPost> DiscussionPosts { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    { }
}