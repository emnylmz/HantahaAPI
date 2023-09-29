namespace HantahaAPI.Core.DTOs
{
	public class UserListDto
	{
		public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string LastLoginIP { get; set; }
        public string Country { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }

        public int UserVisibilityType { get; set; }
#nullable enable
        public DateTime? LastLoginDate { get; set; }
#nullable disable
        public DateTime CreatedOn { get; set; }


    }
}

