﻿using Newtonsoft.Json;

namespace HobbyHorseApi.Entities
{
    public class ParkTrail : Trail
    {
        public string PracticeStyle { get; set; }
        public string? PracticeStyle2 { get; set; } = String.Empty;
        public int? Capacity { get; set; } = 300;
        public Location Location { get; set; }

        public int OpeningHour { get; set; }
        public int ClosingHour { get; set; }

    }
}
