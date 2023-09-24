namespace HantahaAPI.Core.DTOs
{
	public class UserListDto
	{
		//DTO amacı sadece ihtiyacımız olan alanlar
		public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Country { get; set; }
        public string IsActive { get; set; }

        #nullable enable
        public string? Email { get; set; }

        public string UserVisibiltyType { get; set; }
        public DateTime LastLoginDate { get; set; }

#nullable disable
    }
}

