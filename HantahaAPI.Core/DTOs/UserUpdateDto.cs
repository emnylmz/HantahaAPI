using System;
using System.ComponentModel.DataAnnotations;

namespace HantahaAPI.Core.DTOs
{
	public class UserUpdateDto
    {
		public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}

