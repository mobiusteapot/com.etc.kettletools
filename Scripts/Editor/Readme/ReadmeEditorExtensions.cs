using UnityEngine;
using UnityEditor;

namespace ETC.KettleTools {
    public static class ReadmeEditorExtensions {
        public static void DrawReadmeSections(this Readme readme) {
            if (readme.icon != null) {
                readme.DrawReadmeIconHeader();
            }
            foreach (var section in readme.sections) {
                if (!string.IsNullOrEmpty(section.heading)) {
                    GUILayout.Label(section.heading, readme.HeadingStyle);
                }
                if (!string.IsNullOrEmpty(section.text)) {
                    GUILayout.Label(section.text, readme.BodyStyle);
                }
                if (!string.IsNullOrEmpty(section.linkText)) {
                    if (readme.LinkLabel(new GUIContent(section.linkText))) {
                        Application.OpenURL(section.url);
                    }
                }
                GUILayout.Space(20f);
            }
        }

        public static void DrawReadmeIconHeader(this Readme readme) {
            const float k_Space = 16f;
            var iconWidth = Mathf.Min(EditorGUIUtility.currentViewWidth / 3f - 20f, 128f);

            GUILayout.BeginHorizontal("In BigTitle");
            {
                if (readme.icon != null) {
                    GUILayout.Space(k_Space);
                    GUILayout.Label(readme.icon, GUILayout.Width(iconWidth), GUILayout.Height(iconWidth));
                }
                GUILayout.Space(k_Space);
                GUILayout.BeginVertical();
                {

                    GUILayout.FlexibleSpace();
                    GUILayout.Label(readme.title, readme.TitleStyle);
                    GUILayout.FlexibleSpace();
                }
                GUILayout.EndVertical();
                GUILayout.FlexibleSpace();
            }
            GUILayout.EndHorizontal();
        }
    }
}