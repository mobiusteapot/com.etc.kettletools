using System;
namespace ETC.KettleTools {
    [Flags]
    public enum SceneReadmeVisibility {
        doNotShowReadme = 0,
        showReadmeOnSelect = 1 << 0,
        showReadmeOnSceneOpen = 1 << 1,
        showReadmeAlways = ~0,
    }
}