using ChildrenCare.DTOs.BlogDTOs;
using ChildrenCare.Entities;
using ChildrenCare.Utilities;
using ChildrenCare.Utilities.Pagination;

namespace ChildrenCare.Services.Interface
{
    public interface IBlogService
    {
        Task<Blog?> GetBlogAsync(int id);
        Task<PagedList<GetBlogListResponseDTO>> GetBlogList(GetBlogListRequestDTO dto);
        Task<PagedList<GetBlogManagementListResponseDTO>> GetBlogManagementList(GetBlogManagementListRequestDTO dto);
        Task<CustomResponse> CreateBlog(CreateBlogRequestDTO dto);
        Task<BlogDetailDTO?> GetBlogDetail(int id);
    }
}
