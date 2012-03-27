﻿namespace ConcurrencyModel
{
    using System.ComponentModel.DataAnnotations;

    public class Driver
    {
        [Timestamp]
        public byte[] Version { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
        public int? CarNumber { get; set; }
        public int Championships { get; set; }
        public int Races { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Poles { get; set; }
        public int FastestLaps { get; set; }

        public virtual Team Team { get; set; }
        public int TeamId { get; set; }
    }
}