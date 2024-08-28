using UnityEditor;
using UnityEngine;
using VirtueSky.Notifications;


namespace VirtueSky.NotificationsEditor
{
    [CustomEditor(typeof(NotificationChanel), true)]
    public class NotificationChanelEditor : Editor
    {
        private SerializedProperty identifier;
        private SerializedProperty minute;
        private SerializedProperty repeat;
        private SerializedProperty datas;
        private SerializedProperty bigPicture;
        private SerializedProperty namePicture;
        private SerializedProperty overrideIcon;
        private SerializedProperty smallIcon;
        private SerializedProperty largeIcon;

        private void Init()
        {
            identifier = serializedObject.FindProperty("identifier");
            minute = serializedObject.FindProperty("minute");
            repeat = serializedObject.FindProperty("repeat");
            datas = serializedObject.FindProperty("datas");
            bigPicture = serializedObject.FindProperty("bigPicture");
            namePicture = serializedObject.FindProperty("namePicture");
            overrideIcon = serializedObject.FindProperty("overrideIcon");
            smallIcon = serializedObject.FindProperty("smallIcon");
            largeIcon = serializedObject.FindProperty("largeIcon");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            Init();
            GUILayout.Label("Notification Chanel Data", new GUIStyle(EditorStyles.boldLabel)
            {
                fontSize = 15
            });
            GUILayout.Space(5);
            EditorGUILayout.PropertyField(identifier);
            EditorGUILayout.PropertyField(minute);
            EditorGUILayout.PropertyField(repeat);
            EditorGUILayout.PropertyField(datas);
            EditorGUILayout.PropertyField(bigPicture);
            if (bigPicture.boolValue)
            {
                EditorGUILayout.HelpBox("File big picture must be place in folder StreamingAsset, Name Picture must contains file extension ex .jpg", MessageType.Info);
                EditorGUILayout.PropertyField(namePicture);
            }

            EditorGUILayout.PropertyField(overrideIcon);
            if (overrideIcon.boolValue)
            {
                EditorGUILayout.PropertyField(smallIcon);
                EditorGUILayout.PropertyField(largeIcon);
            }

            EditorUtility.SetDirty(target);
            serializedObject.ApplyModifiedProperties();
        }
    }
}