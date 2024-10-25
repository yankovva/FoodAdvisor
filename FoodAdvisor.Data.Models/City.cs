using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static FoodAdvisor.Constants.EntityValidationConstants.City;

namespace FoodAdvisor.Data.Models
{
    public class City
    {
        [Key]
        [Comment("Unique Identifier for the city.")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(NameMaxLenght)]
        [Comment("The Name of the city.")]
        public string Name { get; set; } = null!;

        [Comment("A collection of the Places in the cities.")]
        public virtual ICollection<Place> Places { get; set; } = new List<Place>();
    }
}