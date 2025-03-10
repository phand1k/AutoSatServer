﻿using AvtoMigBussines.Attributes;
using AvtoMigBussines.Authenticate;
using AvtoMigBussines.Authenticate.Models;
using AvtoMigBussines.Data;
using AvtoMigBussines.Services.Implementations;
using AvtoMigBussines.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestSharp;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using static AvtoMigBussines.Exceptions.CustomException;

namespace AvtoMigBussines.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<AspNetUser> userManager;
        private readonly ApplicationDbContext context;
        private readonly IOrganizationService organizationService;
        public AuthenticateController(IUserService userService, UserManager<AspNetUser> userManager, ApplicationDbContext context, IOrganizationService organizationService)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.context = context;
            this.organizationService = organizationService;
        }

        [HttpGet("SendOTP")]
        public async Task<IActionResult> SendOTP(string? phoneNumber)
        {
            try
            {
                await userService.SendOTP(phoneNumber);
                return Ok("Код был отправлен.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("RegisterWithoutOrganizationNumber")]
        public async Task<IActionResult> RegisterWithoutOrganizationNumber([Required][FromBody] RegisterWithoutOrganizationModel model, int? typeOfOrganizationId)
        {
            try
            {
                await userService.RegisterUserWithOutOrganizationNumberAsync(model, typeOfOrganizationId);
                return Ok(new { Message = "Registration successful" });
            }

            catch (UserAlreadyExistsException ex)
            {
                return StatusCode(401, new { Message = ex.Message });
            }

            catch (OrganizationNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }

            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request" });
            }
        }

        /*
         * [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([Required] [FromBody] RegisterModel model)
        {
            try
            {
                await userService.RegisterUserAsync(model);
                return Ok(new { Message = "Registration successful" });
            }
            catch (UserAlreadyExistsException ex)
            {
                return StatusCode(401, new { Message = ex.Message });
            }
            catch (OrganizationNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request" });
            }
        }
         */
        [HttpPatch("SetUserFullName")]
        public async Task<IActionResult> SetUserFullName(string? firstName, string? lastName)
        {
            var user = await GetCurrentUserAsync();

            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }

            user.FirstName = firstName;
            user.LastName = lastName;
            await userManager.UpdateAsync(user);
            return Ok();
        }

        [HttpGet("VerifyOTP")]
        public async Task<IActionResult> VerifyOTP(string? phoneNumber, string? code)
        {
            try
            {
                await userService.VerifyOTP(phoneNumber, code);
                var token = await userService.GenerateToken(phoneNumber);
                return Ok(new { Token = token });
            }
            catch (ArgumentException ex)
            {
                return Unauthorized(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("ConfirmResetPasswordCode")]
        public async Task<IActionResult> ConfirmResetPasswordCode(double? code, string? phoneNumber)
        {
            try
            {
                // Проверяем код и получаем JWT токен после успешной проверки
                var token = await userService.ConfirmResetPasswordCodeAndGenerateToken(code, phoneNumber);
                return Ok(new { Token = token });
            }
            catch (ArgumentException ex)
            {
                return Unauthorized(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }

        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword(string? phoneNumber)
        {
            try
            {
                await userService.ResetPasswordWithWhatsapp(phoneNumber);
                return Ok("Код для сброса пароля был отправлен.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("ResetPasswordWithWhatsapp")]
        public async Task<IActionResult> ResetPasswordWithWhatsapp(string? phoneNumber)
        {
            try
            {
                await userService.ResetPasswordWithWhatsapp(phoneNumber);
                return Ok("Код для сброса пароля был отправлен.");
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpGet("InviteUser")]
        public async Task<IActionResult> InviteUser()
        {
            var user = await context.Users
       .Include(u => u.Organization) // Убедитесь, что Organization загружено
       .FirstOrDefaultAsync(u => u.Id == GetCurrentUserAsync().Result.Id); // Метод для получения текущего пользователя

            if (user == null)
            {
                return NotFound();
            }

            if (user.Organization == null)
            {
                return BadRequest("Организация не найдена для текущего пользователя.");
            }

            var inviteUrl = "https://autosat.kz/invite-user.html?organizationId=" + user.Organization.Number;
            return Ok(inviteUrl);
        }

        [Authorize]
        [HttpGet("CheckUserFullName")]
        public async Task<IActionResult> CheckUserFullName()
        {
            var user = await GetCurrentUserAsync();
            if (user.FirstName == null || user.LastName == null)
            {
                return StatusCode(204);
            }
            return Ok();
        }

        [Authorize]
        [HttpPatch("DeleteUser")]
        public async Task<IActionResult> DeleteUser(string? id)
        {
            await userService.DeleteUserAsync(id);
            return Ok("Succes for delete user: " + id);
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

        [HttpGet]
        [Authorize]
        [Route("GetRole")]
        public async Task<IActionResult> GetRole()
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }
            var role = await userManager.GetRolesAsync(user);
            return Ok(role);
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(model.PhoneNumber);
                if (user == null || user.IsDeleted == true)
                {
                    return Unauthorized(new { Message = "Invalid username or password, or the account has been deleted." });
                }

                if (!await userManager.CheckPasswordAsync(user, model.Password))
                {
                    return Unauthorized(new { Message = "Invalid username or password." });
                }

                var token = await userService.LoginUserAsync(model);
                return Ok(new { Token = token });
            }
            catch (ArgumentException ex)
            {
                return Unauthorized(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request.", Details = ex.Message });
            }
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([Required] [FromBody] RegisterModel model)
        {
            try
            {
                await userService.RegisterUserAsync(model);
                return Ok(new { Message = "Registration successful" });
            }
            catch (UserAlreadyExistsException ex)
            {
                return StatusCode(401, new { Message = ex.Message });
            }
            catch (OrganizationNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "An error occurred while processing your request" });
            }
        }
    }
}
