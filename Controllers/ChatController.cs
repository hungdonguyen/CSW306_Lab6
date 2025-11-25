using Microsoft.AspNetCore.Mvc;

namespace CSW306_Lab6.Controllers
{
 [ApiController]
 [Route("api/[controller]")]
 public class ChatController : ControllerBase
 {
 [HttpPost("join")]
 public async Task<IActionResult> JoinRoom([FromBody] JoinRoomRequest request)
 {
 // Logic ð? x? l? khi user tham gia ph?ng (n?u c?n)
 return Ok();
 }

 [HttpPost("leave")]
 public async Task<IActionResult> LeaveRoom([FromBody] LeaveRoomRequest request)
 {
 // Logic ð? x? l? khi user r?i ph?ng (n?u c?n)
 return Ok();
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
