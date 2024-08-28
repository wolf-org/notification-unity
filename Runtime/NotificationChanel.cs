using System;
using System.IO;
using UnityEngine;

namespace VirtueSky.Notifications
{
    [CreateAssetMenu(fileName = "notification_channel_data.asset",
        menuName = "Unity-Common/Notification Channel")]
    public class NotificationChanel : ScriptableObject
    {
        [Serializable]
        public class NotificationData
        {
            public string title;
            public string message;

            public NotificationData(string title, string message)
            {
                this.title = title;
                this.message = message;
            }
        }

        [SerializeField] private string identifier;

        [SerializeField] private int minute;

        [SerializeField] private bool repeat;
        [SerializeField] private NotificationData[] datas;

        [Tooltip("File big picture must be place in folder StreamingAsset, Name Picture must contains file extension ex .jpg"), SerializeField]
        internal bool bigPicture;

        [SerializeField] internal string namePicture;

        [SerializeField] internal bool overrideIcon;
        [SerializeField] internal string smallIcon = "icon_0";
        [SerializeField] internal string largeIcon = "icon_1";


        public void Send()
        {
            if (!Application.isMobilePlatform) return;
            if (datas.Length == 0) return;
            var data = datas[UnityEngine.Random.Range(0, datas.Length)];

            string pathPicture = Path.Combine(Application.persistentDataPath, namePicture);
            NotificationConsole.Send(identifier,
                data.title,
                data.message,
                smallIcon: smallIcon,
                largeIcon: largeIcon,
                bigPicture: bigPicture,
                namePicture: pathPicture);
        }

        public void Schedule()
        {
            if (!Application.isMobilePlatform) return;
            if (datas.Length == 0) return;
            var data = datas[UnityEngine.Random.Range(0, datas.Length)];

            string pathPicture = Path.Combine(Application.persistentDataPath, namePicture);

            NotificationConsole.Schedule(identifier,
                data.title,
                data.message,
                TimeSpan.FromMinutes(minute),
                smallIcon: smallIcon,
                largeIcon: largeIcon,
                bigPicture: bigPicture,
                namePicture: pathPicture,
                repeat: repeat);
        }

        public void CancelAllScheduled()
        {
            if (!Application.isMobilePlatform) return;
            NotificationConsole.CancelAllScheduled();
        }

        public void ClearBadgeCounterIOS()
        {
            if (!Application.isMobilePlatform) return;
            NotificationConsole.ClearBadgeCounterIOS();
        }
    }
}