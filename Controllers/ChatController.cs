using Microsoft.AspNetCore.Mvc;
using CSW306_Lab6.Services;
using System.Linq;

namespace CSW306_Lab6.Controllers
{
 [ApiController]
 [Route("api/[controller]")]
 public class ChatController : ControllerBase
 {
 private readonly ConnectionManager _connectionManager;

 public ChatController(ConnectionManager connectionManager)
 {
 _connectionManager = connectionManager;
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
