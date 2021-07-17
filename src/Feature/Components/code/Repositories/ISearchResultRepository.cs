using Final.Feature.Components.Models;

namespace Final.Feature.Components.Repositories
{
    public interface ISearchResultRepository
    {
        SearchResultRenderingModel GetModel(string searchQuery);
    }
}
