using Microsoft.AspNetCore.Mvc;
using CSW306_Lab6.Services;
using CSW306_Lab6.Data;
using System.Linq;

namespace CSW306_Lab6.Controllers
{
 [ApiController]
 [Route("api/[controller]")]
 public class ChatController : ControllerBase
 {
 private readonly ConnectionManager _connectionManager;
 private readonly ChatDbContext _db;

 public ChatController(ConnectionManager connectionManager, ChatDbContext db)
 {
 _connectionManager = connectionManager;
 _db = db;
 }

 [HttpPost("join")]
 public async Task<IActionResult> JoinRoom([FromBody] JoinRoomRequest request)
 {
 // Logic x? l? khi user tham gia ph?ng (n?u c?n)
 return Ok();
 }

 [HttpPost("leave")]
 public async Task<IActionResult> LeaveRoom([FromBody] LeaveRoomRequest request)
 {
 // Logic x? l? khi user r?i ph?ng (n?u c?n)
 return Ok();
 }

 [HttpGet("users")]
 public IActionResult GetOnlineUsers()
 {
 // Tr? v? danh sách g?m ConnectionId và Username ð? Frontend hi?n th? và ch?n
 var users = _connectionManager.GetAllConnections()
 .Select(x => new { ConnectionId = x.Key, Username = x.Value });
 return Ok(users);
 }

 [HttpGet("history")]
 public IActionResult GetChatHistory()
 {
 // Tr? v? t?i ða100 tin nh?n g?n nh?t, s?p x?p theo th?i gian gi?m d?n
 var messages = _db.ChatMessages
 .OrderByDescending(m => m.Timestamp)
 .Take(100)
 .ToList();
 return Ok(messages);
 }
 
 public class JoinRoomRequest
 {
 public string RoomName { get; set; }
 public string User { get; set; }
 }
 public class LeaveRoomRequest
 {
 public string RoomName { get; set; }
 public string User { get; set; }
 }
 }
}
