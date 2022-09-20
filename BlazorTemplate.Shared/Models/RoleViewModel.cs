﻿namespace BlazorTemplate.Shared.Models;

public class RoleViewModel
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "نام فارسی الزامی است")]
    public string? PersianName { get; set; }

    [Required(ErrorMessage = "نام انگلیسی الزامی است")]
    public string? Name { get; set; }
}