using System.ComponentModel.DataAnnotations;

namespace AvtoMigBussines.Models
{
    public class ClientOrganization
    {
        public int Id { get; set; }
        [StringLength(11)]
        public string? PhoneNumber { get; set; }
        public int? OrganizationId { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public DateTime? DateOfCreated { get; set; } = DateTime.UtcNow;
    }
}
