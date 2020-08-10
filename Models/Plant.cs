using System;
using System.ComponentModel.DataAnnotations;


namespace PlantAPI.Models
{
    public class Plant
    {
        [Key]
        public int PlantId { get; set; }
        public string  PlantName { get; set; }
        public DateTime? DateLastWatered { get; set; }
        public string WateringStatus { get; set; }
    }
}