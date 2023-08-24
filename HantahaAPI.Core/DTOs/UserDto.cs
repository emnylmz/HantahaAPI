using System;
using System.ComponentModel.DataAnnotations;

namespace HantahaAPI.Core.DTOs
{
	public class UserDto
	{
		//DTO amacı sadece ihtiyacımız olan alanlar
		public int Id { get; set; }
        public string RePassword { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage ="Ad alanı boş bırakılamaz.")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]
        public string Lastname { get; set; }
        public int CountryId { get; set; }

#nullable enable
        public string? Email { get; set; }

        public int UserVisibiltyType { get; set; }

#nullable disable
    }
}

