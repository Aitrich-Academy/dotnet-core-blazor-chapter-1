﻿using HireMeNow_BlazorApp.Enums;
using HireMeNow_BlazorApp.Models;
using System.ComponentModel.DataAnnotations;

namespace HireMeNow_BlazorApp.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string? Gender { get; set; }
        public string? Location { get; set; }
        public long? Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public Roles Role { get; set; }

        //Profile Properties
        public string? About { get; set; }
        public List<string>? Skills { get; set; } = new List<string>();
        public List<Education>? Educations { get; set; } = new List<Education>();
        public List<Experience>? Experiences { get; set; } = new List<Experience>();

        public string? Designation { get; set; }

        public Guid? companyId { get; set; }

        public string? Image { get; set; }

        public UserDto()
        {
            
        }
        public UserDto(string firstName, string lastName, string email, string gender, string? location, long phone, string password, Roles role)
        {
            FirstName=firstName;
            LastName=lastName;
            Email=email;
            Gender=gender;
            Location=location;
            Phone=phone;
            Password=password;
            Role=role;
        }
    }
}
