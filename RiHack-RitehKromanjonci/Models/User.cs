﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiHack_RitehKromanjonci.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string OIB { get; set; } = string.Empty;
    public int Points { get; set; } = 0;
    public Rank Ranks { get; set; } = Rank.Empty;
    public List<PostModel> Posts { get; set; } = new List<PostModel>();
    public List<User> Friends { get; set; } = new List<User>();
}
