using System.ComponentModel.DataAnnotations;

namespace AvtoMigBussines.Models
{
    public class WhatsappSender
    {
        public string chatId { get; set; }
        public string? replyTo { get; set; }
        public string text { get; set; }
        public bool linkPreview { get; set; }
        public string session { get; set; }
    }

}
