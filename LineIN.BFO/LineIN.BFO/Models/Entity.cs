using LineIN.BFO.Notifications;
using System;
using System.Collections.Generic;

namespace LineIN.BFO.Models
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        public bool Valid { get; private set; } = true;
        public bool InValid => !Valid;
        private NotificationContext NotificationContext {get; set; }
       
        public Entity()
        {
            Id = Guid.NewGuid();
            NotificationContext = new NotificationContext();
        }

        public void AddNotification(string Key, string Message)
        {
            NotificationContext.AddNotification(Key, Message);
            Valid = false;
        }

        public IEnumerable<Notification> Notifications()
        {
            return NotificationContext.Notifications;
        }

       
    }


}
