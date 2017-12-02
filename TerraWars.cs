using Terraria.ModLoader;

namespace TerraWars
{
    class TerraWars : Mod
    {
        public TerraWars()
        {
            Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
        }
    }
}
