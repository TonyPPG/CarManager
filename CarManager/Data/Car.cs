using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarManager.Data
{
    public enum BodyType
    {
        Sedan = 0,
        Truck,
        Hatchback,
        Coupe,
        Convertible
    }

    public class Car
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public BodyType Body { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        public Car()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string GetDescription()
        {
            return "Make: " + Make + " Model: " + Model + " Year: " + Year + " Body: " + Body + " Color: " + Color + " Price: " + Price;
        }
    }
}
