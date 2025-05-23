﻿namespace HantahaAPI.Core.Model
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
#nullable enable
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
#nullable disable
    }
}

