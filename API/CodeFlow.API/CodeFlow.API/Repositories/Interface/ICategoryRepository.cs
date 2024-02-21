using CodeFlow.API.Models.Domain;

namespace CodeFlow.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
