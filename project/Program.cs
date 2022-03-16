using BepInEx;

namespace DeSharpener
{
    [BepInPlugin("com.CWX.DeSharpener", "CWX-DeSharpener", "2.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new DeSharpener().Enable();
        }
    }
}
