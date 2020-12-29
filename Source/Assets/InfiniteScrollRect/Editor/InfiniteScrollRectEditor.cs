using UnityEditor;
using UnityEditor.UI;
using Yejun.UGUI;

namespace YejunEditor.UGUI
{
    [CustomEditor(typeof(InfiniteScrollRect), true)]
    [CanEditMultipleObjects]
    public class InfiniteScrollRectEditor : ScrollRectEditor
    {
        SerializedProperty m_buffer;
        SerializedProperty m_autoInactive;
        SerializedProperty m_loopMode;
        SerializedProperty m_snapshotMode;

        protected override void OnEnable()
        {
            base.OnEnable();

            m_buffer = serializedObject.FindProperty("m_buffer");
            m_autoInactive = serializedObject.FindProperty("m_autoInactive");
            m_loopMode = serializedObject.FindProperty("m_loopMode");
            m_snapshotMode = serializedObject.FindProperty("m_snapshotMode");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            EditorGUILayout.PropertyField(m_buffer);
            EditorGUILayout.PropertyField(m_autoInactive);

            if (m_loopMode.boolValue)
            {
                m_snapshotMode.boolValue = false;

                EditorGUILayout.PropertyField(m_loopMode);
                EditorGUILayout.PropertyField(m_snapshotMode);
            }

            if (m_snapshotMode.boolValue)
            {
                m_loopMode.boolValue = false;

                EditorGUILayout.PropertyField(m_loopMode);
                EditorGUILayout.PropertyField(m_snapshotMode);
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}