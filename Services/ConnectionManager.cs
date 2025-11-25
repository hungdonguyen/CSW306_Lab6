using System.Collections.Concurrent;
using System.Linq;

namespace CSW306_Lab6.Services
{
 public class ConnectionManager
 {
 // Key: ConnectionId, Value: Username
 private static readonly ConcurrentDictionary<string, string> _onlineUsers = new ConcurrentDictionary<string, string>();

 public void AddUser(string connectionId, string username)
 {
 _onlineUsers.TryAdd(connectionId, username);
 }

 public void RemoveUser(string connectionId)
 {
 _onlineUsers.TryRemove(connectionId, out _);
 }

 public List<string> GetOnlineUsers()
 {
 return _onlineUsers.Values.Distinct().ToList();
 }
 
 // Hàm l?y ConnectionId t? Username (n?u c?n g?i b?ng username)
 // Ho?c l?y danh sách ð?y ð? ð? tr? v? API
 public Dictionary<string, string> GetAllConnections() 
 {
 // Tr? v? Dictionary <ConnectionId, Username>
 return new Dictionary<string, string>(_onlineUsers);
 }
 }
}
