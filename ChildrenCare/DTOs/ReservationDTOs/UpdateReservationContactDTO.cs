using System.ComponentModel.DataAnnotations;
using ChildrenCare.Utilities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ChildrenCare.DTOs.ReservationDTOs;

public class UpdateReservationContactDTO
{
    [Required]
    public int Id { get; set; }
    [Required]
    [MinLength(3), MaxLength(100)]
    public string? CustomerName { get; set; }
    [Required]
    public int CustomerGender { get; set; }
    [Required]
    [StringLength(10)]
    [RegularExpression(GlobalVariables.PhoneNumberRegex, ErrorMessage = "Must be 10 digits")]
    public string? PhoneNumber { get; set; }
    [Required]
    public string? Address { get; set; }
    public IEnumerable<SelectListItem>? GenderList { get; set; }
    [MaxLength(500)]
    public string? Notes { get; set; }
    
    [RegularExpression(GlobalVariables.DateRegex)]
    public string PreservedDate { get; set; }
    
    public int Hour { get; set; }
    public int Minute { get; set; }
}