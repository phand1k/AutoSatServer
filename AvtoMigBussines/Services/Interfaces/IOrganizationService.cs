﻿using AvtoMigBussines.Authenticate;
using AvtoMigBussines.Models;

namespace AvtoMigBussines.Services.Interfaces
{
    public interface IOrganizationService
    {
        Task<IEnumerable<Organization>> GetAllOrganizationsAsync();
        Task<bool> CreateOrganizationAsync(Organization organization);
        Task UpdateOrganizationAsync(Organization car);
        Task DeleteOrganizationAsync(int id);
        Task<Organization> GetOrganizationByNumberAsync(string number);
        Task<Organization> GetOrganizationByIdAsync(int? id);
        Task<Organization> GetOrganizationPassword(double? password);
        Task<int> CreateAutomaticOrganization(int? typeOfOrganizationId);
    }
}
