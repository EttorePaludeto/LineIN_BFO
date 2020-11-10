using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineIN.BFO.Notifications
{
    public class Notification
    {
		public string Key { get; }
		public string Message { get; }

		public Notification(string key, string message)
		{
			Key = key;
			Message = message;
		}
	}

	public class NotificationContext
	{
		private readonly List<Notification> _notifications;
		public IReadOnlyCollection<Notification> Notifications => _notifications;
		public bool HasNotifications => _notifications.Any();

		public NotificationContext()
		{
			_notifications = new List<Notification>();
		}

		public void AddNotification(string key, string message)
		{
			_notifications.Add(new Notification(key, message));
		}

		public void AddNotification(Notification notification)
		{
			_notifications.Add(notification);
		}

		public void AddNotifications(IReadOnlyCollection<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}

		public void AddNotifications(IList<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}

		public void AddNotifications(ICollection<Notification> notifications)
		{
			_notifications.AddRange(notifications);
		}

		//public void AddNotifications(ValidationResult validationResult)
		//{
		//	foreach (var error in validationResult.ErrorMessage)
		//	{
		//		AddNotification(error., error.ErrorMessage);
		//	}
		//}
	}

	public class NotificationFilter : IAsyncResultFilter
	{
		private readonly NotificationContext _notificationContext;

		public NotificationFilter(NotificationContext notificationContext)
		{
			_notificationContext = notificationContext;
		}

		public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
		{
			if (_notificationContext.HasNotifications)
			{
				//context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
				//context.HttpContext.Response.ContentType = "application/json";

				var notifications = JsonConvert.SerializeObject(_notificationContext.Notifications);
				await context.HttpContext.Response.WriteAsync(notifications);

				return;
			}

			await next();
		}
	}
}
