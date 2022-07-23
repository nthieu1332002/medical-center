using System.ComponentModel.DataAnnotations;
using ChildrenCare.DTOs.ServiceDTOs;
using ChildrenCare.Utilities;

namespace ChildrenCare.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        public string Description { get; set; }

        [MaxLength(255)]
        public string BriefInfo { get; set; }

        [Required]
        public long Price { get; set; }

        public long? SalePrice { get; set; }

        [Required]
        public int Status { get; set; }

        public string ThumbnailUrl { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }

        [Required]
        public bool IsFeatured { get; set; }
        
    }
}
