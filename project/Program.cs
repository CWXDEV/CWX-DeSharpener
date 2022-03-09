using Aki.Common.Utils;
using BepInEx;

namespace DeSharpener
{
    [BepInPlugin("com.CWX.DeSharpener", "CWX-DeSharpener", "2.0.0")]
    public class Program : BaseUnityPlugin
    {
        private void Main()
        {
            Logger.LogMessage("Loading: CWX DESHARPENER");

            new DeSharpener().Enable();
        }
    }
}
