﻿namespace AvtoMigBussines.Models
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? IsDeleted { get; set; } = false;
    }
}
