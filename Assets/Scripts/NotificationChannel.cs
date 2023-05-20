using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Notifications.Android;

public class NotificationChannel : MonoBehaviour
{
    AndroidNotificationChannel defaultChannel;

    int id;

    void Start()
    {

        AndroidNotificationCenter.CancelAllNotifications();

        defaultChannel = new AndroidNotificationChannel()
        {
            Id = "default_channel",
            Name = "Default Channel",
            Description = "Generic Notification",
            Importance = Importance.Default,
        };
        AndroidNotificationCenter.RegisterNotificationChannel(defaultChannel);

        AndroidNotification notification = new AndroidNotification()
        {
            Title = "Initial Notification",
            Text = "Welcome to BasketGO, maintain your app updated for more future content",
            SmallIcon = "icon_0",
            LargeIcon = "icon_1",
            FireTime = System.DateTime.Now.AddSeconds(10),
        };

        id = AndroidNotificationCenter.SendNotification(notification, defaultChannel.Id);
    }

    public void CheckNotification()
    {
        if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotification newNotification = new AndroidNotification()
            {
                Title = "Initial Notification",
                Text = "Welcome to BasketGO, maintain your app updated for more future content",
                FireTime = System.DateTime.Now.AddSeconds(5),
            };

            AndroidNotificationCenter.CancelNotification(id);
            AndroidNotificationCenter.SendNotification(newNotification, defaultChannel.Id);
        }
        else if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Delivered)
        {
            AndroidNotificationCenter.CancelNotification(id);
        }
        else if (AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Unknown)
        {
            AndroidNotification notification = new AndroidNotification()
        {
            Title = "Initial Notification",
            Text = "Welcome to BasketGO, maintain your app updated for more future content",
            FireTime = System.DateTime.Now.AddSeconds(10),
        };

        id = AndroidNotificationCenter.SendNotification(notification, defaultChannel.Id);
        }
    }
}
