using ChildrenCare.Utilities.Pagination;

namespace ChildrenCare.DTOs.BlogDTOs;

public class GetBlogManagementListResponseDTO
{
    public int Id { get; set; }
    public int AuthorUserId { get; set; }
    public string AuthorName { get; set; }
    public int CategoryId { get; set; }
    public string Tittle { get; set; }
    public int Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public string ThumbnailUrl { get; set; }
}    