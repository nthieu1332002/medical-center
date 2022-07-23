using System.ComponentModel.DataAnnotations;
using ChildrenCare.Utilities;

namespace ChildrenCare.DTOs.BlogDTOs
{
    public class CreateBlogRequestDTO
    {

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

        public IFormFile? ThumbnailFile { get; set; }

        public Entities.Blog ToNewBlog(int authorId, string? thumbnailUrl = null)
        {
            var result = new Entities.Blog()
            {
                Tittle = Tittle,
                BriefInfo = BriefInfo,
                BlogBody = BlogBody,
                CategoryId = CategoryId,
                CreatedDate = DateTime.Now,
                LastUpdate = DateTime.Now,
                AuthorUserId = authorId,
                Status = GlobalVariables.ActiveBlogStatusId
            };
            if (thumbnailUrl != null)
            {
                result.ThumbnailUrl = thumbnailUrl;
            }
            return result;
        } 
    }
}
