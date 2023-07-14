using ExamProjectASP.Entities;
using ExamProjectASP.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;

namespace ExamProjectASP.Hubs
{
	public class ChatHub:Hub
	{
		private UserManager<CustomIdentityUser> _userManager;
		private IHttpContextAccessor _contextAccessor;
		private CustomIdentityDbContext _context;

		public ChatHub(UserManager<CustomIdentityUser> userManager, IHttpContextAccessor contextAccessor, CustomIdentityDbContext context)
		{
			_userManager = userManager;
			_contextAccessor = contextAccessor;
			_context = context;
		}

		public async override Task OnConnectedAsync()
		{
			var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
            var userItem = _context.Users.SingleOrDefault(x => x.Id == user.Id);
			userItem.IsOnline = true;
            await _context.SaveChangesAsync();
            UserHelper.ActiveUsers.Add(user);

			string info = user.UserName + " connected successfully" ;
			foreach (var item in UserHelper.ActiveUsers)
			{
				info += item.ToString() + '\n';
			}
			await Clients.Others.SendAsync("Connect", info);
		}

		public async override Task OnDisconnectedAsync(Exception? exception)
		{
			var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
			if (user != null)
			{
				var userItem = _context.Users.SingleOrDefault(x => x.Id == user.Id);
				userItem.IsOnline = false;
				await _context.SaveChangesAsync();
				UserHelper.ActiveUsers.RemoveAll(u => u.Id == user.Id);
			}
			string info = user.UserName + " disconnected";
			await Clients.Others.SendAsync("Disconnect", info);
		}


		public async Task SendFollow(string id)
		{
			await Clients.Others.SendAsync("Test2");
		}

        public async Task Funksiya()
        {
			var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
            await Clients.All.SendAsync("GetAllOnline",user.Id);
        }


        public async Task SendChat(string user, string message)
        {
            await Clients.User(user).SendAsync("GetMessage", user, message);
        }

		public async Task SendFriendRequest(string sender,string receiver)
		{
			await Clients.User(receiver).SendAsync("SendFriendRequestFunction", sender);
		}


		public async Task DeclineRequest(string id)
		{
            var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
            await Clients.User(id).SendAsync("DeclineRequestFunction",user.Id);
		}

		public async Task AcceptRequest(string id)
		{
			var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
			await Clients.User(id).SendAsync("AcceptRequestFunction", user.Id);
		}

		public async Task UnFollowRequest(string id)
		{
			var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
			await Clients.User(id).SendAsync("UnFollowFunction", user.Id);
		}

	}
}
