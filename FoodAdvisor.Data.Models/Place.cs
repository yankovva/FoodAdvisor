using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FoodAdvisor.Constants.EntityValidationConstants.Place;

namespace FoodAdvisor.Data.Models
{
    public class Place
    {
        [Key]
        [Comment("The Unique Identifier of the Place.")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(NameMaxLenght)]
        [Comment("The Name of the Place.")]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        [Comment("The Description of the Place.")]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLenght)]
        [Comment("The Address of the Place.")]
        public string Address { get; set; } = null!;

        [Required]
        [Comment("The Rating of the Place.")]
        public double Rating { get; set; }

        [MaxLength(URLMaxLEnght)]
        [Comment("An Image Url of the Place.")]
        public string? ImageURL { get; set; }

        [Required]
        [Comment("The City Id.")]
        public Guid CityId { get; set; }
        [ForeignKey(nameof(CityId))]
        public City City { get; set; } = null!;

        [Required]
        [Comment("The Publisher Id.")]
        public Guid PublisherId { get; set; }

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        [Required]
        [Comment("The Category Id.")]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}
