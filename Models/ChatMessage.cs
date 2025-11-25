using System;

namespace CSW306_Lab6.Models
{
 public class ChatMessage
 {
 public int Id { get; set; }
 public string Sender { get; set; } = string.Empty;
 public string Message { get; set; } = string.Empty;
 // Nullable: tin nh?n có th? là Broadcast ho?c g?i nhóm
 public string? Receiver { get; set; }
 public string? GroupName { get; set; }
 public DateTime Timestamp { get; set; } = DateTime.Now;
 }
}
