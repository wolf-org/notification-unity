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
- 