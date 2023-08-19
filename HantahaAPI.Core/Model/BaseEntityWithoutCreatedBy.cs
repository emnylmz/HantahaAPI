using System;
namespace HantahaAPI.Core.Model
{
	public abstract class BaseEntityWithoutCreatedBy
    {
        public int Id { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}

