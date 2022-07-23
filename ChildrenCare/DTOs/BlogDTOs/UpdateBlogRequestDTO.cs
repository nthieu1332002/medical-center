using System.ComponentModel.DataAnnotations;
using System.Net;
using ChildrenCare.Utilities;

namespace ChildrenCare.DTOs.BlogDTOs;

//TODO: Change blog Status
public class UpdateBlogRequestDTO
{
    [Required]
    public int Id { get; set; }

    [Required]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Tittle { get; set; }

    [Required]
    [MaxLength(255)]
    public string BriefInfo { get; set; }

    [Required]
    public string BlogBody { get; set; }

    public IFormFile ThumbnailFile { get; set; }

    public Entities.Blog MapAndUpdateArticle(Entities.Blog blog, string? thumbnailUrl = null)
    {
        var hasChanged = false;

        if (!string.IsNullOrWhiteSpace(Tittle) && Tittle != blog.Tittle)
        {
            blog.Tittle = Tittle;
            hasChanged = true;
        }

        // if (!string.IsNullOrWhiteSpace(Status) && Status.ToLower() != blog.Status.ToLower())
        // {
        //     if (!GlobalVariables.ArticleStatuses.Contains(Status.ToLower()))
        //     {
        //         throw new HttpStatusCodeException(HttpStatusCode.BadRequest, "Article Status must be: " + string.Join(", ", GlobalVariables.ArticleStatuses));
        //     }
        //     blog.Status = Status.ToLower();
        //     hasChanged = true;
        // }

        if (!string.IsNullOrWhiteSpace(BriefInfo))
        {
            blog.BriefInfo = BriefInfo;
            hasChanged = true;
        }

        if (!string.IsNullOrWhiteSpace(BlogBody))
        {
            blog.BlogBody = BlogBody;
            hasChanged = true;
        }

        if (thumbnailUrl != null)
        {
            blog.ThumbnailUrl = thumbnailUrl;
            hasChanged = true;
        }

        if (hasChanged)
        {
            blog.LastUpdate = DateTime.Now;
        }
        else
        {
            //TODO: Handle Exception
        }

        return blog;
    }
}