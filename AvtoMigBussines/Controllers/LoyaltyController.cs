using AvtoMigBussines.Authenticate;
using AvtoMigBussines.Detailing.Repositories.Interfaces;
using AvtoMigBussines.Models;
using AvtoMigBussines.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Telegram.Bot.Requests.Abstractions;
using Telegram.Bot.Types;

namespace AvtoMigBussines.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoyaltyController : Controller
    {
        private readonly ILoyaltyService _loyaltyService;
        private readonly IClientRepository clientRepository;
        private readonly UserManager<AspNetUser> userManager;
        public LoyaltyController(ILoyaltyService _loyaltyService, IClientRepository clientRepository, UserManager<AspNetUser> userManager)
        {
            this._loyaltyService = _loyaltyService;
            this.clientRepository = clientRepository;
            this.userManager = userManager;
        }

        /*[HttpPost("NewsLetter")]
        public async Task<IActionResult> NewsLetter([FromBody] NewsLetterRequest request)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {//ert
                return Unauthorized(new { Message = "User is not authenticated" });
            }

            if (string.IsNullOrWhiteSpace(request.Message))
            {
                return BadRequest(new { Message = "Message cannot be empty" });
            }
            try
            {
                var listClients = await clientRepository.GetAllClients(user.OrganizationId);
                await _loyaltyService.MarketingSendMessage(user.OrganizationId, listClients, request.Message);
                return Ok(new { Message = "Messages sent successfully" });
            }
            catch (Exception ex) 
            {
                return Ok(ex.Message);
            }
        }*/
        [HttpGet("TestSendMesage")]
        public async Task<IActionResult> TestSendMesage(string? phoneNumber, string? message)
        {
            await _loyaltyService.Test(phoneNumber, message);
            return Ok();
        }


        private async Task<AspNetUser> GetCurrentUserAsync()
        {
            var userName = User.FindFirstValue(ClaimTypes.Name);
            if (string.IsNullOrEmpty(userName))
            {
                return null;
            }

            var aspNetUser = await userManager.FindByEmailAsync(userName);
            if (aspNetUser == null)
            {
                return null;
            }

            var user = await userManager.FindByIdAsync(aspNetUser.Id);
            return user;
        }
        
    }
}
