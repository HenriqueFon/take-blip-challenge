using GitHubApi.Models;
using RestEase;

namespace GitHubApi.Services

{
    [Header("User-Agent", "GitAPI/v1")]
    
    public interface IGitHubRepository
    {
        [Get("/orgs/takenet/repos")]
        public Task<IEnumerable<Repositories>> GetRepositoryAsync();
    }
}
