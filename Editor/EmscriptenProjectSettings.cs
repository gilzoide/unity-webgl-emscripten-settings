using UnityEditor;
using UnityEngine;

namespace Gilzoide.WebGLEmscriptenSettings.Editor
{
    public class EmscriptenProjectSettings
    {
        private static GUIContent _emscriptenArgsLabel = new GUIContent("Emscripten Args", "Arguments passed to the emscripten compiler during WebGL builds");

        [SettingsProvider]
        public static SettingsProvider CreateEmscriptenProjectSettings()
        {
            return new SettingsProvider("Project/WebGL Emscripten Settings", SettingsScope.Project)
            {
                guiHandler = searchContext =>
                {
                    PlayerSettings.WebGL.emscriptenArgs = EditorGUILayout.TextField(_emscriptenArgsLabel, PlayerSettings.WebGL.emscriptenArgs);
                },
            };
        }
    }
}
