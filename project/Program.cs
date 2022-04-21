using BepInEx;
using BepInEx.Configuration;

namespace DeSharpener
{
    [BepInPlugin("com.CWX.DeSharpener", "CWX-DeSharpener", "1.3.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<float> sharpness;

        private void Awake()
        {
            sharpness = Config.Bind
                (
                "Sharpness Value",
                "Sharpness",
                0.7f,
                "Set the sharpness value for your game to run at, " +
                "this will not change when using painkillers"
                );
            new DeSharpener().Enable();
        }
    }
}
