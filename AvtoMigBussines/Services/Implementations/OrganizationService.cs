using AvtoMigBussines.Authenticate;
using AvtoMigBussines.Exceptions;
using AvtoMigBussines.Methods;
using AvtoMigBussines.Models;
using AvtoMigBussines.Repositories.Implementations;
using AvtoMigBussines.Repositories.Interfaces;
using AvtoMigBussines.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace AvtoMigBussines.Services.Implementations
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepository organizationRepository;
        private readonly UserManager<AspNetUser> userManager;
        private readonly ISubscriptionService subscriptionService;
        public OrganizationService(IOrganizationRepository organizationRepository, UserManager<AspNetUser> userManager, ISubscriptionService subscriptionService)
        {
            this.organizationRepository = organizationRepository;
            this.userManager = userManager;
            this.subscriptionService = subscriptionService;
        }


        public async Task<Organization> GetOrganizationPassword(double? password)
        {
            return await organizationRepository.GetPasswordrganization(password);
        }
        public async Task<Organization> GetOrganizationByIdAsync(int? id)
        {
            return await organizationRepository.GetByIdAsync(id);
        }
        public async Task<Organization> GetOrganizationByNumberAsync(string number)
        {
            return await organizationRepository.GetByNumberAsync(number);
        }
        public async Task<IEnumerable<Organization>> GetAllOrganizationsAsync()
        {
            return await organizationRepository.GetAllAsync();
        }

        public async Task<int> CreateAutomaticOrganization(int? typeOfOrganizationId)
        {
            Organization organization = new Organization();
            organization.Number = GenerateOrganizationNumber.Generate();

            if (await organizationRepository.ExistsWithNumber(organization.Number))
            {
                throw new CustomException.OrganizationExistsException("Organization with the same number already exists.");
            }

            organization.TypeOfOrganizationId = typeOfOrganizationId;
            organization.Name = "ТЕСТ";
            organization.FullName = "ИП ТЕСТ";
            await organizationRepository.AddAsync(organization);

            await subscriptionService.CreateSubscriptionAsync(organization.Id);

            Random rnd = new Random();
            AspNetUser defaultUser = new AspNetUser
            {
                FirstName = "Стандартный",
                LastName = "Пользователь",
                SurName = "Для назначения услуг",
                OrganizationId = organization.Id,
                PhoneNumber = Guid.NewGuid().ToString()
            };

            await userManager.CreateAsync(defaultUser);
            return organization.Id;
        }


        public async Task<bool> CreateOrganizationAsync(Organization organization)
        {

            if (await organizationRepository.ExistsWithNumber(organization.Number))
            {
                throw new CustomException.OrganizationExistsException("Organization with the same number already exists.");
            }

            await organizationRepository.AddAsync(organization);
            Random rnd = new Random();
            AspNetUser defaultUser = new AspNetUser
            {
                FirstName = "Стандартный",
                LastName = "Пользователь",
                SurName = "Для назначения услуг",
                OrganizationId = organization.Id,
                PhoneNumber = Guid.NewGuid().ToString()
            };
            await userManager.CreateAsync(defaultUser);
            return true;
        }

        public async Task UpdateOrganizationAsync(Organization organization)
        {
            await organizationRepository.UpdateAsync(organization);
        }

        public async Task DeleteOrganizationAsync(int id)
        {
            await organizationRepository.DeleteAsync(id);
        }
    }
}
