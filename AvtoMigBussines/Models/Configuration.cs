namespace AvtoMigBussines.Models
{
    public class Configuration
    {
        public int Id { get; set; }
        public string? URL { get; set; }
        public bool? IsProd { get; set; }

        public bool? IsDeleted { get; set; } = false;
    }
}
