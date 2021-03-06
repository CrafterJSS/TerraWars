﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//This class was based on the sword from the barebones mod generator

namespace TerraWars.Items
{
    public class LightsaberBlue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Lightsaber");
            Tooltip.SetDefault("A blue energy blade. Says voom and bzzt. The first item in the mod.");
        }
        public override void SetDefaults()
        {
            item.damage = 9000;
            item.melee = true;
            item.width = 48;
            item.height = 48;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = Item.buyPrice(1, 0, 0, 0);
            item.rare = 12;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}