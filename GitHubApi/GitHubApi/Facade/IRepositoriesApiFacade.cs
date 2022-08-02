using GitHubApi.Models;

namespace GitHubApi.Facade
{
    public interface IRepositoriesApiFacade
    {
        public Task<IEnumerable<Repositories>> GetRepositoriesAsync();
    }
}
