using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace ETC.KettleTools {
    // Menu for adding monobehaviour
    [AddComponentMenu("Editor/Readme")]
    public class ReadmeComponent : MonoBehaviour {
        public Readme Readme;
    }
}