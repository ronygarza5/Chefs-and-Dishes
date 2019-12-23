using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}
        [Required]
        [MinLength(3)]
        public string FirstName {get; set;}
        [Required]
        [MinLength(3)]
        public string LastName {get; set;}
        [Required]
        [Range(18,100)]
        public int Age {get; set;}
        public List<Dish> ChefDishes {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}