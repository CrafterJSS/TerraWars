using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

// A blank Kyber Crystal, powerful things which, among other things, are used in the creation of lightsabers.

namespace TerraWars.Items
{
    public class KyberCrystal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Kyber Crystal");
            Tooltip.SetDefault("A blank Kyber Crystal. Clear and shiny!");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 100;
            item.value = Item.buyPrice(0, 50, 0, 0);
            item.rare = 12;
        }
    }
}
