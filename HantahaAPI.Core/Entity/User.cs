using System;
using HantahaAPI.Core.Model;

namespace HantahaAPI.Core.Entity
{
    public class User : BaseEntityWithoutCreatedBy
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int CountryId { get; set; }

#nullable enable
        public string? Email { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string? LastLoginIP { get; set; }

#nullable disable
        public bool IsActive { get; set; }

        public int UserVisibiltyType { get; set; }
        public bool IsAdmin { get; set; }
        public string LastIV { get; set; }

        public ICollection<Feedback> FeedBacks { get; set; }
        public ICollection<UserPasswordResetToken> UserPasswordResetTokens { get; set; }

        public Country Country { get; set; }
    }
}

