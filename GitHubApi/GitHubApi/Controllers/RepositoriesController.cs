using GitHubApi.Facade;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitHubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoriesController : ControllerBase
    {
        private readonly IRepositoriesApiFacade _repositoriesApiFacade;

        public RepositoriesController(IRepositoriesApiFacade repositoriesApiFacade)
        {
            _repositoriesApiFacade = repositoriesApiFacade;
        }

        [HttpGet("repositories")]
        public async Task<IActionResult> GetRepositoryAsync()
        {
            var response = await _repositoriesApiFacade.GetRepositoriesAsync();
            return Ok(response);
        }
    }
}
