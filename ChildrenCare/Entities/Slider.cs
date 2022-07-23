using System.ComponentModel.DataAnnotations;

namespace ChildrenCare.Entities;

public class Slider
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Required]
    public int Status { get; set; }

    [Required]
    public string BackLink { get; set; }

    [Required]
    public string ThumbnailUrl { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }

    [Required]
    public DateTime LastUpdate { get; set; }

}