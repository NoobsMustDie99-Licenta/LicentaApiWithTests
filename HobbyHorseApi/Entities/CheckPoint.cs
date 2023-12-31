﻿namespace HobbyHorseApi.Entities
{
    public class CheckPoint
    {
        public string Id { get; set; }
        public string? Name { get; set; } = String.Empty;
        public int Order { get; set; }
        public string CustomTrailId { get; set; }
        public Location Location { get; set; }
    }
}
