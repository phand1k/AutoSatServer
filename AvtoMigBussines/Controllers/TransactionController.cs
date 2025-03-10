﻿using AvtoMigBussines.Authenticate;
using AvtoMigBussines.CarWash.Models;
using AvtoMigBussines.CarWash.Services.Interfaces;
using AvtoMigBussines.Data;
using AvtoMigBussines.Detailing.Models;
using AvtoMigBussines.Detailing.Services.Interfaces;
using AvtoMigBussines.Exceptions;
using AvtoMigBussines.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace AvtoMigBussines.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [CheckSubscription]
    public class TransactionController : Controller
    {
        private readonly IWashOrderService _washOrderService;
        private readonly WebSocketHandler _webSocketHandler;
        private readonly IUserService _userService;
        private readonly UserManager<AspNetUser> _userManager;
        private readonly IServiceService _serviceService;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ApplicationDbContext _context;
        private readonly IWashServiceService _washService;
        private readonly ISalarySettingService salarySettingService;
        private readonly IWashOrderTransactionService washOrderTransactionService;
        private readonly INotificationCenterService notificationCenterService;
        private readonly IDetailingOrderService detailingOrderService;
        public TransactionController(
            IWashOrderService washOrderService,
            WebSocketHandler webSocketHandler,
            IUserService userService,
            UserManager<AspNetUser> userManager,
            IServiceService serviceService,
            IHttpClientFactory httpClientFactory,
            ApplicationDbContext context,
            IWashServiceService washService,
            ISalarySettingService salarySettingService,
            IWashOrderTransactionService washOrderTransactionService,
            INotificationCenterService notificationCenterService, IDetailingOrderService detailingOrderService)
        {
            this.detailingOrderService = detailingOrderService;
            _washOrderService = washOrderService;
            _webSocketHandler = webSocketHandler;
            _userService = userService;
            _userManager = userManager;
            _serviceService = serviceService;
            _httpClientFactory = httpClientFactory;
            _context = context;
            _washService = washService;
            this.salarySettingService = salarySettingService;
            this.washOrderTransactionService = washOrderTransactionService;
            this.notificationCenterService = notificationCenterService;
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

        [HttpGet("DetailsTransaction")]
        public async Task<IActionResult> DetailsTransaction([Required] int id)
        {
            var transaction = await washOrderTransactionService.GetWashOrderTransactionByIdAsync(id);
            if (transaction == null)
            {
                return NotFound(new { Message = "Wash service not found." });
            }

            return Ok(transaction);
        }
        [HttpPost("CreateTransactionAsync")]
        public async Task<IActionResult> CreateTransactionAsync([FromBody] WashOrderTransaction transaction, int washOrderId)
        {
            var washOrder = await _washOrderService.GetByIdWashOrderForComplete(washOrderId);
            if (washOrder == null)
            {
                return NotFound(new { Message = "Wash order not found." });
            }
            if (washOrderId == null)
            {
                return BadRequest(new { Message = "Wash order ID is required." });
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }
            try
            {
                await washOrderTransactionService.CreateWashOrderTransactionAsync(transaction, user.Id, washOrderId);
                return Ok(transaction);
            }
            catch (CustomException.WashOrderNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                // Логирование исключения
                // _logger.LogError(ex, "An error occurred while creating the wash service.");
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }
        [HttpPost("CreateDetailingTransaction")]
        public async Task<IActionResult> CreateDetailingTransaction([FromBody] DetailingOrderTransaction transaction, int detailingOrderId)
        {
            var detailingOrder = await detailingOrderService.GetByIdDetailingOrderForComplete(detailingOrderId);
            if (detailingOrder == null)
            {
                return NotFound(new { Message = "Detailing order not found." });
            }
            if (detailingOrderId == null)
            {
                return BadRequest(new { Message = "Detailing order ID is required." });
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }
            try
            {
                await washOrderTransactionService.CreateDetailingOrderTransactionAsync(transaction, user.Id, detailingOrderId);
                return Ok(transaction);
            }
            catch (CustomException.WashOrderNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                // Логирование исключения
                // _logger.LogError(ex, "An error occurred while creating the wash service.");
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }

        [HttpPost("CreateWashOrderTransactionAsync")]
        public async Task<IActionResult> CreateWashOrderTransactionAsync([FromBody] WashOrderTransaction transaction, int washOrderId)
        {
            var washOrder = await _washOrderService.GetByIdWashOrderForComplete(washOrderId);
            if (washOrder == null)
            {
                return NotFound(new { Message = "Wash order not found." });
            }
            if (washOrderId == null)
            {
                return BadRequest(new { Message = "Wash order ID is required." });
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }
            try
            {
                await washOrderTransactionService.CreateWashOrderTransactionAsync(transaction, user.Id, washOrderId);
                return Ok(transaction);
            }
            catch (CustomException.WashOrderNotFoundException ex)
            {
                return NotFound(new { Message = ex.Message });
            }
            catch (Exception ex)
            {
                // Логирование исключения
                // _logger.LogError(ex, "An error occurred while creating the wash service.");
                return StatusCode(500, new { Message = "An error occurred while processing your request." });
            }
        }
        [HttpGet("GetAllDetailingOrderTransactions")]
        public async Task<IActionResult> GetAllDetailingOrderTransactions(DateTime? dateOfStart, DateTime? dateOfEnd)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }

            if (!dateOfStart.HasValue && !dateOfEnd.HasValue)
            {
                DateTime today = DateTime.Today;
                dateOfStart = today.AddHours(5);  // Сегодня в 05:00
                dateOfEnd = today.AddHours(23).AddMinutes(59).AddSeconds(59);  // Сегодня в 23:59:59
            }

            var transactions = await washOrderTransactionService.GetAllDetailingOrderTransactions(user.Id, dateOfStart, dateOfEnd);
            return Ok(transactions);
        }
        [HttpGet("GetAllTransactions")]
        public async Task<IActionResult> GetAllTransactions(DateTime? dateOfStart, DateTime? dateOfEnd)
        {
            var user = await GetCurrentUserAsync();
            if (user == null)
            {
                return Unauthorized(new { Message = "User is not authenticated." });
            }

            if (!dateOfStart.HasValue && !dateOfEnd.HasValue)
            {
                DateTime today = DateTime.Today;
                dateOfStart = today.AddHours(5);  // Сегодня в 05:00
                dateOfEnd = today.AddHours(23).AddMinutes(59).AddSeconds(59);  // Сегодня в 23:59:59
            }

            var transactions = await washOrderTransactionService.GetAllTransactions(user.Id, dateOfStart, dateOfEnd);
            return Ok(transactions);
        }

    }
}
