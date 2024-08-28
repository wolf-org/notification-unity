<p align="left">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
    <img alt="License" src="https://img.shields.io/github/license/wolf-org/notification-unity?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/wolf-org/notification-unity?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/wolf-org/notification-unity?logo=VirtualBox">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/wolf-org/notification-unity?include_prereleases&logo=Dropbox&color=yellow">
  </a>
</p>

## What

Support scheduling local one-time or repeatable notifications for Unity games (Android and iOS)

## How To Install

### Add the line below to `Packages/manifest.json`

for version `1.0.0`
```csharp
"com.wolf-org.notifications":"https://github.com/wolf-org/notification-unity.git#1.0.0",
```
dependency `com.unity.mobile.notifications-2.3.2` and `com.cysharp.unitask-2.5.5`
```csharp
"com.unity.mobile.notifications": "2.3.2",
"com.cysharp.unitask": "https://github.com/Cysharp/UniTask.git?path=src/UniTask/Assets/Plugins/UniTask#2.5.5",
```

## Use

- Add define symbol `VIRTUESKY_NOTIFICATION`
- Create `NotificationChanel` (via `Create` > `Unity-Common` > `Notification Chanel`)


![Unity_Sc8gP1veiY](https://github.com/user-attachments/assets/62050ab1-36a2-40c2-af80-3b4898bde874)


![Screenshot 2024-08-28 135421](https://github.com/user-attachments/assets/0e4688ac-b718-4f2a-b8bb-9875ba628953)

- `Identifier`
- `Minute` (after t minute notification will be sent)
- `Repeat` (is it repeatable or not)
- `Pig Picture` (only android)
- `Name Picture` (name pig picture notification)
`Note: File big picture must be place in folder StreamingAsset, Name Picture must contains file extension ex .jpg`

![mJSRu](https://github.com/user-attachments/assets/d50145c2-1d6f-4d25-9ec3-424211eff43c)

- `Override Icon`
- `Small Icon` (custom small icon)
- `Large Icon` (custom large icon)

- `NotificationPrepare`
Attach NotificationPrepare to scene to prepare notification android bigpicture, RequestUserPermission android and schedule

![Screenshot 2024-08-28 140819](https://github.com/user-attachments/assets/8a905a11-7b17-4d36-bea5-61fd9f412484)

- Send notification

```csharp
  public NotificationChanel notificationChanel;

  private void Start()
  {
    notificationChanel.Send();
  }
```
- Schedule notification

```csharp
  public NotificationChanel notificationChanel;

  private void Start()
  {
    notificationChanel.Schedule();
  }
```
- Cancel All Scheduled

```csharp
  public NotificationChanel notificationChanel;

  private void Start()
  {
    notificationChanel.CancelAllScheduled();
  }
```


