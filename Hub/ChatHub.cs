using Microsoft.AspNetCore.SignalR;
namespace CSW306_Lab6.Hubs

{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        // 2. Phương thức tham gia nhóm (Dành cho Bài 2)
        public async Task JoinGroup(string groupName, string user)
        {
            // Thêm ConnectionId hiện tại vào nhóm có tên groupName
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName);

            // Thông báo cho mọi người trong nhóm biết có người mới vào
            await Clients.Group(groupName).SendAsync("ReceiveMessage", "Hệ thống", $"{user} đã tham gia nhóm {groupName}.");
        }

        // 3. Phương thức gửi tin nhắn riêng cho NHÓM (Dành cho Bài 2)
        public async Task SendGroupMessage(string groupName, string user, string message)
        {
            // Thêm prefix để phân biệt tin nhắn nhóm
            await Clients.Group(groupName).SendAsync("ReceiveMessage", user, $"[Nhóm] {message}");
        }

        public async Task LeaveGroup(string groupName, string user)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
            await Clients.Group(groupName).SendAsync("ReceiveMessage", "Hệ thống", $"{user} đã rời nhóm {groupName}.");
        }
    }
}
