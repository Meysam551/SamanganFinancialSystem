﻿
using Microsoft.AspNetCore.Identity;

namespace SFS.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    public string? Code { get; set; }
    public string? FName { get; set; }
    public string? LName { get; set; }
    public string? Image { get; set; }
    public string? Role { get; set; }
    public string? PartTitle { get; set; }
    public DateTime LastLoginDate { get; set; }
    public bool IsActive { get; set; }
    public DateTime CDT { get; set; }
    public DateTime MDT { get; set; }
}

public class AppRole : IdentityRole<Guid>
{
    public string Description { get; set; } = string.Empty;
}
