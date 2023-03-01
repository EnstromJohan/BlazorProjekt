﻿namespace VOD.Membership.Database.Entities
{
    public class Director : IEntity
    {
        public int Id { get; set; }
        [MaxLength(50), Required]
        public string? Name { get; set; }
        public int FilmId { get; set; }
    }
}
