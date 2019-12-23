using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Dish
    {
        
        [Key]
        public int DishId {get; set;}
        [Required]
        [MinLength(3)]
        public string Name {get; set;}
        [Required]
        [Range(1, 5)]
        public int Tastiness {get; set;}
        [Required]
        [Range(1,2000)]
        public int Calories {get; set;}
        public int ChefId {get; set;}
        // Navigation property for related User object
        public Chef Maker{get; set;}
        [Required]
        [MinLength(10)]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}