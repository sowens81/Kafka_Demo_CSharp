using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Car
    {
        [JsonProperty("make")]
        [Required(ErrorMessage = "Car make is required!")]
        public string Make { get; set; }
        
        [JsonProperty("model")]
        [Required(ErrorMessage = "Car model is required!")]
        public string Model { get; set; }
        
        [JsonProperty("engineSize")]
        [Required(ErrorMessage = "Car engine size is required!")]
        public double EngineSize { get; set; }

        [JsonProperty("color")]
        [Required(ErrorMessage = "Car color is required!")]
        public string Color { get; set; }

        [JsonProperty("year")]
        [Required(ErrorMessage = "Car manufatured year is required!")]
        public int Year { get; set; }

    }
}
