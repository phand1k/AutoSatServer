using AvtoMigBussines.Authenticate;
using AvtoMigBussines.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AvtoMigBussines.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MarketingController : Controller
    {
        private readonly IMarketingService marketingService;
        private readonly UserManager<AspNetUser> _userManager;
        public MarketingController(IMarketingService marketingService, UserManager<AspNetUser> userManager)
        {
            this.marketingService = marketingService;
            this._userManager = userManager;
        }

        private async Task<AspNetUser> GetCurrentUserAsync()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userName))
            {
                return null;
            }

            var aspNetUser = await _userManager.FindByEmailAsync(userName);
            if (aspNetUser == null)
            {
                return null;
            }

            var user = await _userManager.FindByIdAsync(aspNetUser.Id);
            return user;
        }

        [HttpGet("BusiestDays")]
        public async Task<IActionResult> BusiestDays()
        {
            var user = await GetCurrentUserAsync();
            var result = await marketingService.GetBusiestDays(user.OrganizationId);
            return Ok(result);
        }

        [HttpGet("GetRevenue")]
        public async Task<IActionResult> GetRevenue()
        {
            var user = await GetCurrentUserAsync();
            var result = await marketingService.GetRevenue(user.OrganizationId);
            return Ok(result);
        }

        [HttpGet("ClientStatistics")]
        public async Task<IActionResult> GetClientStatistics()
        {
            var user = await GetCurrentUserAsync();
            var statistics = await marketingService.GetClientStatistics(user.OrganizationId);
            return Ok(statistics);
        }


        [HttpGet("MostPopularServices")]
        public async Task<IActionResult> MostPopularServices()
        {
            var user = await GetCurrentUserAsync();
            var result = await marketingService.MostPopularServices(user.OrganizationId);
            return Ok(result);
        }

        [HttpGet("MostPopularCars")]
        public async Task<IActionResult> MostPopularCars()
        {
            var user = await GetCurrentUserAsync();
            var result = await marketingService.MostPopularCars(user.OrganizationId);
            return Ok(result);
        }

    }
}
