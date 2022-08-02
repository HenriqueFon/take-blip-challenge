using GitHubApi.Models;
using GitHubApi.Services;
using System.Linq;

namespace GitHubApi.Facade
{
    public class RepositoriesApiFacade : IRepositoriesApiFacade
    {
        private readonly IGitHubRepository _repository;

        public RepositoriesApiFacade(IGitHubRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Repositories>> GetRepositoriesAsync()
        {
            var response = await _repository.GetRepositoryAsync();
            var filteredData = response
                .Where((response) => response.Language == "C#")
                .Take(5);
            return filteredData;
        }
    }
}
