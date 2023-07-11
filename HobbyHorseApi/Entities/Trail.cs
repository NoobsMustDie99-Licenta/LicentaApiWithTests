﻿
using Newtonsoft.Json;

namespace HobbyHorseApi.Entities
{
    public abstract class Trail
    {
        public string Id { get; set; }
        public string? Name { get; set; } = String.Empty;
    }
}
