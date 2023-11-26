using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

namespace ETC.KettleTools {
    [CustomEditor(typeof(Readme), true)]
    public class ReadmeEditor : UnityEditor.Editor {
        public override void OnInspectorGUI() {
            Readme readme = (Readme)target;
            if (readme == null) return;
            readme.DrawReadmeSections();
        }
    }
}