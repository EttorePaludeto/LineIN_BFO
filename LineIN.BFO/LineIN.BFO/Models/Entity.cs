using LineIN.BFO.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LineIN.BFO.Models
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
        [NotMapped]
        public bool Valid { get; private set; } = true;
        [NotMapped]
        public bool InValid => !Valid;
        [NotMapped]
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
