using Microsoft.EntityFrameworkCore;
using CSW306_Lab6.Models;

namespace CSW306_Lab6.Data
{
 public class ChatDbContext : DbContext
 {
 public ChatDbContext(DbContextOptions<ChatDbContext> options) : base(options) { }

 public DbSet<ChatMessage> ChatMessages { get; set; }
 }
}
